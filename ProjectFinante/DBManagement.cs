using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinante
{
    public partial class DBManagement : Form
    {
        public DBManagement()
        {
            InitializeComponent();
            //Update the dropdown to have all table names
            ArrayList tablelist = Database.GetTables();

            foreach (var table_name in tablelist)
            {
                tableDropdown.Items.Add(table_name);
            }

            
   
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {


            String table_name = (string)tableDropdown.Text;
  
            String sql_query = "Select * from " + table_name;

           
            List<Dictionary<string, string>> list = Database.read_table(table_name);

            listView_tables.Items.Clear();
            listView_tables.Columns.Clear();
            bool first = true;
            listView_tables.View = View.Details;
            foreach (var item in list)
            {
                ListViewItem row = new ListViewItem();
                if (first)
                {
                    first = false;
                    listView_tables.Columns.Add("index", 30);
                    foreach (var key in list[0].Keys)
                    {
                        listView_tables.Columns.Add(key, listView_tables.Width / 6);
                    }
                }
                foreach (var key in item.Keys) 
                   {
                    
                    row.SubItems.Add(item[key]);
                   }
                
                    listView_tables.Items.Add(row);
            }

                           
        }
        private void fetchRecurente()
        {

            var table_name = "venituri";
            float media = 0;
            int count = 0;

            List<Dictionary<string, string>> list = Database.read_table(table_name);

            listView_tables.Items.Clear();
            listView_tables.Columns.Clear();
           
            listView_tables.View = View.Details;

            listView_tables.Columns.Add("index", 30);
            foreach (var key in list[0].Keys)
            {
                listView_tables.Columns.Add(key, listView_tables.Width / 6);
            }

            foreach (var item in list)
            {
                ListViewItem row = new ListViewItem();

                if (item["tip"] != "fix")
                {
                    media += Int32.Parse(item["valoare"]);
                    count += 1;
                    foreach (var key in item.Keys)
                    {
                        row.SubItems.Add(item[key]);
                    }
                    listView_tables.Items.Add(row);
                }

            }

            ListViewItem row2 = new ListViewItem();
            row2.SubItems.Add("media");
            row2.SubItems.Add((media/count).ToString());
            
            listView_tables.Items.Add(row2);


        }

        private void testButton_Click(object sender, EventArgs e)
        {
           
            fetchRecurente();
        }
    }
}
