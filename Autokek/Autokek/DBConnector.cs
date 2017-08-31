using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Autokek
{
    class DBConnector
    {
        private static string server = "sql9.freemysqlhosting.net";
        private static string database = "sql9192197";
        private static string username = "sql9192197";
        private static string password = "PlzlLkqUnH";
        private static MySqlConnection connection = null;

        private static void Connect()
        {
            string connectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}", server, database, username, password);
            connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection successful");
        }

        private static void Close()
        {
            connection.Close();
            Console.WriteLine("Connection closed");
        }


        public static void AddUser(User user)
        {
            Connect();
            MySqlCommand command = connection.CreateCommand();
            string insertString = string.Format("INSERT INTO Users (username, email, password) VALUES ('{0}', '{1}', '{2}')", user.username, user.email, PasswordHash.HashPassword(user.password));
            command.CommandText = insertString;
            command.ExecuteNonQuery();
            Close();
        }

        private static MySqlDataReader GetData(string query)
        {
            Connect();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        private static List<User> GetUsers(string username)
        {
            var reader = GetData(string.Format("SELECT * FROM Users WHERE username = '{0}'", username));
            List<User> users = new List<User>();
            while (reader.Read())
            {
                users.Add(new User(reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
            }
            Close();
            return users;
        }

        public static string GetPassword(string username)
        {
            return (GetUsers(username)[0].password);
        }

        public bool UserExists(string username)
        {
            Connect();
            string queryString = string.Format("SELECT * FROM Users WHERE username = '{0}'", username);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = queryString;
            MySqlDataReader reader = command.ExecuteReader();
            bool result =  reader.HasRows;
            Close();
            return result;
        }

    }
}
