using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace ProjectFinante
{
    public static class Database
    {
        static SQLiteConnection m_dbConnection;

        public static void initDatabase()
        {
            String databaseName = "myDb.sqlite";
            if(!File.Exists(databaseName))
            {
                SQLiteConnection.CreateFile(databaseName);
                m_dbConnection = new SQLiteConnection("Data Source=" + databaseName + ";Version=3;"); 
                m_dbConnection.Open();

                SQLiteCommand command = new SQLiteCommand("CREATE TABLE venituri (descriere VARCHAR(500), valoare NUMERIC, recurenta VARCHAR(15), data_document datetime, tip VARCHAR(15))", m_dbConnection);
                command.ExecuteNonQuery();

                command = new SQLiteCommand("CREATE TABLE cheltuieli (descriere VARCHAR(500), valoare NUMERIC, recurenta VARCHAR(15), data_document datetime, tip VARCHAR(15))", m_dbConnection);
                command.ExecuteNonQuery();

            } else
            {
                m_dbConnection = new SQLiteConnection("Data Source=" + databaseName + ";Version=3;");
                m_dbConnection.Open();
            }
        }

        public static void insert(String sql) 
        {
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
    }
}
