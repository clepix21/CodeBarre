using System;
using System.Data.SQLite;

namespace CodeBarre.SQL
{
    class script_sql
    {
        private string connectionString = "Data Source=..\\..\\SQL\\bd.db";

        public void ExecuteQuery()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT EAN FROM Produits";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"EAN: {reader["EAN"]}");
                        }
                    }
                }
            }
        }
    }
}
