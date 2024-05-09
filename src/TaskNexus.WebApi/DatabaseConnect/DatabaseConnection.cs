using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace TaskNexus.WebApi.DatabaseConnect
{

    public static class DatabaseConnection
    {
        public static string Main()
        {
            string connectionString = "Server=server164.hosting.reg.ru;Database=u2615099_tasknexus;Uid=u2615099_tasknex;Pwd=levandjenia228;";
            string queryString = "SELECT * FROM user";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(queryString, connection);
                connection.Open();
                string temp = "";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp += (String.Format("{0}, {1}", reader["ID"], reader["NICKNAME"]));
                    }
                }
                return temp;
            }
        }
    }    
}
