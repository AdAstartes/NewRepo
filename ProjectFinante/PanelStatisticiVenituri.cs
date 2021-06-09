using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinante
{
    public partial class PanelStatisticiVenituri : UserControl
    {
        public PanelStatisticiVenituri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelStatisticiVenituri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;

            DateTime date2 = dateTimePicker2.Value;
            string recurenta = recurenta_box.Text;
            Dictionary<string, float> returndict = Money.calculate_total(recurenta, date1, date2, "cheltuieli");
            MessageBox.Show((returndict["value"] / returndict["count"]).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;

            DateTime date2 = dateTimePicker2.Value;
            string recurenta = recurenta_box.Text;

            MessageBox.Show(Money.calculate_total(recurenta, date1, date2, "venituri")["value"].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();  // cheltuieli in loc de venituri copy+pasta   - save file dialog

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
 
                StringBuilder sb = new StringBuilder();
                DateTime date1 = dateTimePicker1.Value;

                DateTime date2 = dateTimePicker2.Value;
                string recurenta = recurenta_box.Text;
                List<Dictionary<string, string>> lst;

                string current_line = "";
                switch (recurenta)
                {
                    case "Recurent":
                        {

                            lst = Database.read_table("venituri", "recurent", date1, date2);
                            break;
                        }
                    case "Fix":
                        {

                            lst = Database.read_table("venituri", "fix", date1, date2);
                            break;
                        }
                    default:
                        lst = Database.read_table("venituri", "asdasd", date1, date2);
                        break;
                }
                if (lst.Count() > 0)
                {
                    String csv = String.Join(",",
                             lst[0].Select(d => d.Key));
                    sb.Append(csv + Environment.NewLine);

                }


                foreach (var item in lst)
                {
                    current_line = "";
                    foreach (var key in item.Keys)
                    {
                        current_line += item[key] + ",";
                    }
                    current_line=current_line.Remove(current_line.Length - 1);
                    sb.Append(current_line + Environment.NewLine);
                }

                System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());

            }






            

            






        }

    }
}
