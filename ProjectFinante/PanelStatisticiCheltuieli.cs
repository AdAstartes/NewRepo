using System;
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
    public partial class PanelStatisticiCheltuieli : UserControl
    {
        public PanelStatisticiCheltuieli()
        {
            InitializeComponent(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            //dateTimePicker1
            DateTime date2 = dateTimePicker2.Value;
            string recurenta = recurenta_box.Text;

            

            MessageBox.Show(Money.calculate_total(recurenta,date1,date2,"cheltuieli")["value"].ToString());
        }

       

        private void btn_val_medie_Click(object sender, EventArgs e)
        {

            DateTime date1 = dateTimePicker1.Value;
            //dateTimePicker1
            DateTime date2 = dateTimePicker2.Value;
            string recurenta = recurenta_box.Text;

            Dictionary<string, float> returndict = Money.calculate_total(recurenta, date1, date2, "cheltuieli");
            MessageBox.Show((returndict["value"]/returndict["count"]).ToString());
        }
    }
}
