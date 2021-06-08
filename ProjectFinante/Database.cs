using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Collections;

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

        public static List<String> select(String sql)
        {

            List<String> returned = new List<string>();
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            
            //Debug.WriteLine(sql);

            SQLiteDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                //string FileNames = (string)r["FileName"];
                //returned.Add((string)r);
                Console.WriteLine(r);

            }

            return returned;
        }

        public static List<Dictionary<string,string>> read_table(string name)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            String query = "SELECT * FROM " + name;


            switch (name)
            {
                case "venituri":
                    {
                        System.Data.DataTable table = GetDataTable(query);
                        foreach (System.Data.DataRow row in table.Rows)
                        {
                            Console.WriteLine(row);
                            Dictionary<string, string> dict = new Dictionary<string, string>();
                            dict.Add("descriere", (string)row["descriere"]);
                            dict.Add("valoare", row["valoare"].ToString());
                            dict.Add("recurenta", row["recurenta"].ToString());
                            dict.Add("data_document", row["data_document"].ToString());
                            dict.Add("tip", (string)row["tip"]);
                            list.Add(dict);
                        }

                        break;

                    }
                case "cheltuieli":
                    {

                        System.Data.DataTable table = GetDataTable(query);
                        foreach (System.Data.DataRow row in table.Rows)
                        {
                            Console.WriteLine(row);
                            Dictionary<string, string> dict = new Dictionary<string, string>();
                            dict.Add("descriere", (string)row["descriere"]);
                            dict.Add("valoare", row["valoare"].ToString());
                            dict.Add("recurenta", row["recurenta"].ToString());
                            dict.Add("data_document", row["data_document"].ToString());
                            dict.Add("tip", (string)row["tip"]);
                            list.Add(dict);
                        }
                       
                        break;
                    }
                default:
                    break;
            }

            return list;


            return null;

        }

        public static ArrayList GetTables()
        {
            ArrayList list = new ArrayList();

            // executes query that select names of all tables in master table of the database
            String query = "SELECT name FROM sqlite_master " +
                    "WHERE type = 'table'" +
                    "ORDER BY 1";
            try
            {
                System.Data.DataTable table = GetDataTable(query);
                // Return all table names in the ArrayList
                foreach (System.Data.DataRow row in table.Rows)
                {
                    list.Add(row.ItemArray[0].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }

        public static System.Data.DataTable GetDataTable(string sql)
        {
            try
            {
                System.Data.DataTable dt = new System.Data.DataTable();
  
                    
                using (SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection))
                  {
                     using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            dt.Load(rdr);
                            return dt;
                        }
                  }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }



    }
}
