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

        }
    }
}
