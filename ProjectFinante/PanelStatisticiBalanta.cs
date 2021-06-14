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
    public partial class PanelStatisticiBalanta : UserControl
    {
        public PanelStatisticiBalanta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;

            DateTime date2 = dateTimePicker2.Value;
            int recurenta = comboBox1.SelectedIndex;
            Dictionary<string, float> returndict;
            switch (recurenta)
            { 
                case 0:
                    MessageBox.Show((Money.calculate_total("Fixe", date1, date2, "venituri")["value"] - Money.calculate_total("Fixe", date1, date2, "cheltuieli")["value"]).ToString());
                    break;
                case 1:
                    MessageBox.Show((Money.calculate_total("Recurente", date1, date2, "venituri")["value"] - Money.calculate_total("Recurente", date1, date2, "cheltuieli")["value"]).ToString());
                    break;
                case 2:
                    MessageBox.Show((Money.calculate_total("Cookies", date1, date2, "venituri")["value"] - Money.calculate_total("asdasdas", date1, date2, "cheltuieli")["value"]).ToString());
                    break;
                default:
                    MessageBox.Show((Money.calculate_total("Tasty", date1, date2, "venituri")["value"] - Money.calculate_total("adfgagsa", date1, date2, "cheltuieli")["value"]).ToString());
                    break;
            }
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;

            DateTime date2 = dateTimePicker2.Value;
            int recurenta = comboBox1.SelectedIndex;
            Dictionary<string, float> returndict;
            switch (recurenta)
            {
                case 0:
                    {
                        Dictionary<string, float> venituri=Money.calculate_total("Fixe", date1, date2, "venituri");
                        Dictionary<string, float> cheltuieli = Money.calculate_total("Fixe", date1, date2, "cheltuieli");
                        MessageBox.Show(((venituri["value"]-cheltuieli["value"])/(venituri["count"]+cheltuieli["count"])).ToString());
                        break;
                    }
                case 1:
                    {
                        Dictionary<string, float> venituri = Money.calculate_total("Recurente", date1, date2, "venituri");
                        Dictionary<string, float> cheltuieli = Money.calculate_total("Recurente", date1, date2, "cheltuieli");
                        MessageBox.Show(((venituri["value"] - cheltuieli["value"]) / (venituri["count"] + cheltuieli["count"])).ToString());
                        break;
                    }
                case 2:
                    {
                        Dictionary<string, float> venituri = Money.calculate_total("123", date1, date2, "venituri");
                        Dictionary<string, float> cheltuieli = Money.calculate_total("Recadsdaurente", date1, date2, "cheltuieli");
                        MessageBox.Show(((venituri["value"] - cheltuieli["value"]) / (venituri["count"] + cheltuieli["count"])).ToString());
                        break;
                    }
                    break;
                default:
                    {
                        Dictionary<string, float> venituri = Money.calculate_total("123", date1, date2, "venituri");
                        Dictionary<string, float> cheltuieli = Money.calculate_total("Recadsdaurente", date1, date2, "cheltuieli");
                        MessageBox.Show(((venituri["value"] - cheltuieli["value"]) / (venituri["count"] + cheltuieli["count"])).ToString());
                        break;
                    }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.ShowDialog();  // cheltuieli in loc de venituri copy+pasta   - save file dialog

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.

                StringBuilder sb = new StringBuilder();
                DateTime date1 = dateTimePicker1.Value;

                DateTime date2 = dateTimePicker2.Value;
                string recurenta = comboBox1.Text;
                List<Dictionary<string, string>> lst;
                List<Dictionary<string, string>> lst2;

                string current_line = "";
                switch (recurenta)
                {
                    case "Recurent":
                        {

                            lst = Database.read_table("cheltuieli", "recurent", date1, date2);
                            lst2 = Database.read_table("venituri", "recurent", date1, date2);
                            break;
                        }
                    case "Fix":
                        {

                            lst = Database.read_table("cheltuieli", "fix", date1, date2);
                            lst2 = Database.read_table("venituri", "fix", date1, date2);
                            break;
                        }
                    default:
                        lst = Database.read_table("cheltuieli", "asdasd", date1, date2);
                        lst2 = Database.read_table("venituri", "asdasd", date1, date2);
                        break;
                }
                if (lst.Count() > 0)
                {
                    String csv = String.Join(",", lst[0].Select(d => d.Key));
                    sb.Append(csv + Environment.NewLine);
                }


                foreach (var item in lst)
                {
                    current_line = "";
                    foreach (var key in item.Keys)
                    {
                        current_line += item[key] + ",";
                    }
                    current_line = current_line.Remove(current_line.Length - 1);
                    sb.Append(current_line + Environment.NewLine);
                }

                foreach (var item in lst2)
                {
                    current_line = "";
                    foreach (var key in item.Keys)
                    {
                        current_line += item[key] + ",";
                    }
                    current_line = current_line.Remove(current_line.Length - 1);
                    sb.Append(current_line + Environment.NewLine);
                }

                System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());

            }
        }
    }
}
