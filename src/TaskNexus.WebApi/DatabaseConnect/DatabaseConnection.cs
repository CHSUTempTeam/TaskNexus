using System;
using System.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities;
namespace TaskNexus.WebApi.DatabaseConnect
{

    public static class DatabaseConnection
    {
        private static MySqlDataReader connect(string request) {
            string connectionString = "Server=server164.hosting.reg.ru;Database=u2615099_tasknexus;Uid=u2615099_tasknex;Pwd=levandjenia228;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(request, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        public static MySqlDataReader select(string table, string condition) {
            string request = "SELECT * FROM `" + table + "` WHERE " + condition;

            MySqlDataReader obj = connect(request);
            obj.Read();
            return obj;
        }


        //public static string Main()
        //{
        //    string connectionString = "Server=server164.hosting.reg.ru;Database=u2615099_tasknexus;Uid=u2615099_tasknex;Pwd=levandjenia228;";
        //    string queryString = "SELECT * FROM user";

        //    using (MySqlConnection connection = new MySqlConnection(connectionString))
        //    {
        //        MySqlCommand command = new MySqlCommand(queryString, connection);
        //        connection.Open();
        //        string temp = "";
        //        using (MySqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                temp += (String.Format("{0}, {1}", reader["ID"], reader["NICKNAME"]));
        //            }
        //        }
        //        return temp;
        //    }
        //}
    }    
}
