using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Reflection.PortableExecutable;
using static Mysqlx.Expect.Open.Types;
namespace TaskNexus.WebApi.DatabaseConnect
{
    public static class DatabaseConnector {
        private static string connectionString = "Server=server164.hosting.reg.ru;Database=u2615099_tasknexus;Uid=u2615099_tasknex;Pwd=levandjenia228;CharSet=utf8;";
        public static MySqlConnection Connector { get; } = new MySqlConnection(connectionString);

        static DatabaseConnector() {
            Connector.Open();
        }

        public static List<Dictionary<string, object>> ExecuteQuery(string query) {
            MySqlCommand command = new MySqlCommand(query, Connector);
            MySqlDataReader reader = command.ExecuteReader();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            while (reader.Read()) {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++) {
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }
                rows.Add(row);
            }
            reader.Close();
            return rows;
        }

    }

    public static class DatabaseConnection
    {

        internal static List<Dictionary<string, object>> addUserSession(string session, string user_id) {
            string request = "DELETE FROM `connection` WHERE USER='" + user_id + "'";
            DatabaseConnector.ExecuteQuery(request);

            request = "INSERT INTO `connection` (`SESSION`, `USER`) VALUES('" + session + "', '" + user_id + "')";
            return DatabaseConnector.ExecuteQuery(request);
        }


        public static List<Dictionary<string, object>> select(string table, string condition) {
            string request = "SELECT * FROM `" + table + "` WHERE " + condition;
            return DatabaseConnector.ExecuteQuery(request);
        }

        internal static List<Dictionary<string, object>> addUser(string name, string email, string pass) {
            string request = "SELECT MAX(ID) FROM `user`";
            List<Dictionary<string, object>> obj = DatabaseConnector.ExecuteQuery(request);
            var id = (Convert.ToInt32(obj[0]["MAX(ID)"]) + 1).ToString();


            request = "INSERT INTO `user` (`ID`, `NICKNAME`, `PASSWORD`, `EMAIL`) VALUES('"+id+"','"+ name + "', '"+ pass + "', '"+ email + "')";
            return DatabaseConnector.ExecuteQuery(request);
        }

        internal static string addProject(string title) {
            string request = "SELECT MAX(ID) FROM `project`";
            List<Dictionary<string, object>> obj = DatabaseConnector.ExecuteQuery(request);
            var id = "";
            if(obj[0]["MAX(ID)"] != DBNull.Value) {
                id = (Convert.ToInt32(obj[0]["MAX(ID)"]) + 1).ToString();
            }
            else {
                id = "0";
            }


            request = "INSERT INTO `project` (`ID`, `TITLE`) VALUES('" + id + "', '" + title + "')";
            DatabaseConnector.ExecuteQuery(request);
            return id;
        }

        internal static void addUserToProject(string id_project, string id_user) {
            string request = "SELECT * FROM `user_to_project` WHERE ID_USER='" + id_user + "' AND ID_PROJECT='"+ id_project + "'";
            List<Dictionary<string, object>> obj = DatabaseConnector.ExecuteQuery(request);
            if (obj.Count == 0) {
                request = "INSERT INTO `user_to_project` (`ID_PROJECT`, `ID_USER`) VALUES('" + id_project + "', '" + id_user + "')";
                DatabaseConnector.ExecuteQuery(request);
            }
        }

        internal static List<Dictionary<string, object>> getUserId(string session) {
            string request = "SELECT * FROM `connection` WHERE SESSION='" + session + "'";
            return DatabaseConnector.ExecuteQuery(request);
        }

        internal static List<Dictionary<string, object>> getProjects(string session) {
            string request = "SELECT * FROM `user_to_project` WHERE ID_USER='" + session + "'";
            return DatabaseConnector.ExecuteQuery(request);
        }

        internal static void getOut(string session) {
            string request = "DELETE FROM `connection` WHERE SESSION='" + session + "'";
            DatabaseConnector.ExecuteQuery(request);
        }

        internal static void renameProject(string id_user, string title, string count) {
            string request = "SELECT * FROM `user_to_project` WHERE ID_USER=" + id_user + " LIMIT 1 OFFSET " + count;
            List<Dictionary<string, object>> obj = DatabaseConnector.ExecuteQuery(request);

            if (obj[0]["ID_PROJECT"] != DBNull.Value) {
                request = "UPDATE `project` SET TITLE='" + title + "' WHERE ID='" + obj[0]["ID_PROJECT"].ToString() + "'";
                DatabaseConnector.ExecuteQuery(request);
            }
        }

        internal static void deleteProject(string id_user, string count) {
            string request = "SELECT * FROM `user_to_project` WHERE ID_USER=" + id_user + " LIMIT 1 OFFSET " + count;
            List<Dictionary<string, object>> obj = DatabaseConnector.ExecuteQuery(request);

            if (obj[0]["ID_PROJECT"] != DBNull.Value) {
                request = "DELETE FROM `project` WHERE ID='" + obj[0]["ID_PROJECT"].ToString() + "'";
                DatabaseConnector.ExecuteQuery(request);

                request = "DELETE FROM `user_to_project` WHERE ID_USER=" + id_user + " AND ID_PROJECT = " + obj[0]["ID_PROJECT"].ToString() + " LIMIT 1";
                DatabaseConnector.ExecuteQuery(request);
            }
        }


        internal static void addUserToProject(string id_user, string id_worker, string count) {
            string request = "SELECT * FROM `user_to_project` WHERE ID_USER=" + id_user + " LIMIT 1 OFFSET " + count;
            List<Dictionary<string, object>> obj = DatabaseConnector.ExecuteQuery(request);

            if (obj[0]["ID_PROJECT"] != DBNull.Value) {

                addUserToProject(obj[0]["ID_PROJECT"].ToString(), id_worker);
            }
        }

    }
}
