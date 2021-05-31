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
    public partial class PanelCheltuieliRecurente : UserControl
    {
        public PanelCheltuieliRecurente()
        {
            InitializeComponent();
        }

        public void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            Common.onlyNumbers(sender, e);
        }

        private void Btn_salveaza_Click(object sender, EventArgs e)
        {
            String descriere = textBox_descriere.Text;
            String valoare = textBox_valoare.Text;
            int tip = comboBox_recurenta.SelectedIndex;

            if (descriere.Length == 0)
            {
                MessageBox.Show("Nu ai completat descrierea!");
                return;
            }

            if (valoare.Length == 0)
            {
                MessageBox.Show("Nu ai completat valoarea!");
                return;
            }

            double valoareDouble = Convert.ToDouble(valoare);
            if (valoareDouble <= 0)
            {
                MessageBox.Show("Valoarea trebuie sa fie mai mare decat 0!");
                return;
            }

            if (tip == -1)
            {
                MessageBox.Show("Nu ai selectat recurenta!");
                return;
            }

            Database.insert("INSERT INTO cheltuieli (descriere, valoare, recurenta, tip) VALUES " +
                "('" + descriere + "', '" + valoare + "', '" + Common.tipRecurenta[tip] + "', 'recurenta')");

            MessageBox.Show("Datele au fost salvate!");
            textBox_descriere.Text = "";
            textBox_valoare.Text = "";
            comboBox_recurenta.SelectedIndex = -1;
        }
    }
}
