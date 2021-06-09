using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;

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

        public static List<Dictionary<string,string>> select(String sql, List<string> fields)
        {

           List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();



           System.Data.DataTable table = GetDataTable(sql);
            foreach (System.Data.DataRow row in table.Rows)
            {

                Dictionary<string, string> dict = new Dictionary<string, string>();
                foreach (var f in fields)
                {
                    dict.Add(f,row[f].ToString());
                }
                list.Add(dict);
            }

            return list;
        }

        public static List<Dictionary<string,string>> read_table(string name, string type, DateTime date1, DateTime date2)
        {
            String query;
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            switch (type)
            {
                case "fix":
                    {
                        query = "SELECT * FROM " + name + " WHERE data_document <= '" + date2.ToString("yyyy-MM-dd") + "' and data_document >= '" + date1.ToString("yyyy-MM-dd")+"' and tip = 'fix'";
                        break;
                    }
                case "recurent":
                    {
                        //MessageBox.Show("GOT HERE");

                        query = "SELECT * FROM " + name +  " WHERE data_document <= '" + date2.ToString("yyyy-MM-dd") + "' and data_document >= '" + date1.ToString("yyyy-MM-dd") + "' and tip = 'recurenta'";
                        break;
                    }
                default:
                    {
                        query = "SELECT * FROM " + name + " WHERE data_document <= '" + date2.ToString("yyyy-MM-dd") + "' and data_document >= '" + date1.ToString("yyyy-MM-dd") + "'";
                        break;
                    }
            }
         


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
