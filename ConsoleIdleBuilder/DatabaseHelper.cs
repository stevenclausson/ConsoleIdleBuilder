using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ConsoleIdleBuilder
{
    class DatabaseHelper
    {
        public static string connectionString = @"Data Source=..\..\..\Files\IdleBuilder.db;Version=3";

        public static void InitializeDatabase()
        {
            if (!File.Exists(@"..\..\..\Files\IdleBuidler.db"))
            {
                SQLiteConnection.CreateFile(@"..\..\..\Files\IdleBuilder.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string createCityTableQuery = @"
                        CREATE TABLE IF NOT EXISTS city (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        name TEXT NOT NULL,
                        size INTEGER NOT NULL
                        )";

                    string createResourcesTableQuery = @"
                        CREATE TABLE IF NOT EXISTS resources (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        name TEXT NOT NULL,
                        quantity INTEGER NOT NULL,
                        type TEXT NOT NULL
                        )";

                    using (var command = new SQLiteCommand(connection)) 
                    {
                        command.CommandText = createCityTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText += createResourcesTableQuery;
                        command.ExecuteNonQuery();
                    }
                        
                }
            }
        }
    }
}
