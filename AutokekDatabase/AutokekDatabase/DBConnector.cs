using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AutokekDatabase
{
    class DBConnector
    {
        private string server = "sql9.freemysqlhosting.net";
        private string database = "sql9192197";
        private string username = "sql9192197";
        private string password = "PlzlLkqUnH";
        private MySqlConnection connection = null;

        private void Connect ()
        {
            string connectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}", server, database, username, password);
            connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection successful");
        }

        private void Close ()
        {
            connection.Close();
            Console.WriteLine("Connection closed");
        }

        private void CreateTables()
        {
            MySqlCommand command = connection.CreateCommand();
            
            command.CommandText = @"DROP TABLE Users;
                                    CREATE TABLE Users (
                                        id int PRIMARY KEY AUTO_INCREMENT,
                                        username VARCHAR(16),
                                        email VARCHAR(100),
                                        password VARCHAR(50000)
                                    );";
            command.ExecuteNonQuery();
            Console.WriteLine("Tables created");
        }

        public void UpdateDB ()
        {
            Connect();
            CreateTables();
            Close();
        }
    }
}
