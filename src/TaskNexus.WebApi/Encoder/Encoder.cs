using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities;
namespace TaskNexus.WebApi.DatabaseConnect
{

    public static class Encoder {
        public static string encode(string input) {

            string output = "";
            int sum = 0;

            for (int i = 0; i < input.Length; i++) {
                string integer = ((int)(char)input[i]*3).ToString();
                if (integer.Length < 3) integer = "0" +integer;
                if (integer.Length < 2) integer = "00" +integer;
                output += integer;
                //output += (char)input[i]*2;
                //output += (char)input[i]*3;
                //sum += (char)input[i] * 2 + (char)input[i] * 3;
            }

            // output += sum;

            return output;
        }

        public static string decode(string input) {
            string symbol = "";
            int sum = 0;
            string output = "";

            for (int i = 0; i < input.Length; i+=3) {
                symbol += input[i];
                symbol += input[i+1];
                symbol += input[i+2];

                int m = int.Parse(symbol) / 3;

                output += (char)m;

                symbol = "";
                // sum += (char)input[i] + (char)input[i];
            }

            //output += sum;

            return output;
        }

        internal static string generateSessionId() {
            int length = 20;
            string id = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
                                  .Select(s => s[new Random().Next(s.Length)]).ToArray());
            return id;
        }
    }    
}
