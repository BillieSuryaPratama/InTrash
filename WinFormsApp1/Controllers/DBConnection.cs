using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WinFormsApp1.Controllers
{
    internal class DBConnection
    {
        private static string Host = "localhost";
        private static string Username = "postgres";
        private static string Password = "malang05";
        private static string Database = "InTrash";
        private static string Port = "5432";
        public static NpgsqlConnection connection;
        public static NpgsqlCommand command;

        private static string ConnString = $"Host={Host};Username={Username};Password={Password};Database={Database};Port={Port};";

        public static void openConn()
        {
            connection = new NpgsqlConnection($"{ConnString}");
            connection.Open();

            command = new NpgsqlCommand();
            command.Connection = connection;
        }

        public static void closeConn()
        {
            connection.Close();
            command.Parameters.Clear();
        }
    }
}
