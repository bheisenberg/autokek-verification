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
        private string server = "sql9.freemysqlhosting.net";
        private string database = "sql9192197";
        private string username = "sql9192197";
        private string password = "PlzlLkqUnH";
        private MySqlConnection connection = null;

        private void Connect()
        {
            string connectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}", server, database, username, password);
            connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection successful");
        }

        private void Close()
        {
            connection.Close();
            Console.WriteLine("Connection closed");
        }


        public void AddUser(User user)
        {
            Connect();
            MySqlCommand command = connection.CreateCommand();
            string insertString = string.Format("INSERT INTO Users VALUES ({0}, {1}, {2})", user.username, user.email, user.password);
            command.CommandText = insertString;
            command.ExecuteNonQuery();
            Close();
        }

        public bool UserExists(User user)
        {
            Connect();
            string queryString = string.Format("SELECT * FROM Users WHERE username = '{0}'", user.username);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = queryString;
            MySqlDataReader reader = command.ExecuteReader();
            Close();
            return reader.HasRows;
        }


    }
}
