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
    public partial class PanelCheltuieliFixe : UserControl
    {
        public PanelCheltuieliFixe()
        {
            InitializeComponent();
        }

        private void textBox_valoare_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.onlyNumbers(sender, e);
        }

        private void btn_salveaza_Click(object sender, EventArgs e)
        {
            String descriere = textBox_descriere.Text;
            String valoare = textBox_valoare.Text;


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


                Database.insert("INSERT INTO cheltuieli (descriere, valoare) VALUES " +
                    "('" + descriere + "', '" + valoare + "', ");

                MessageBox.Show("Datele au fost salvate!");
                textBox_descriere.Text = "";
                textBox_valoare.Text = "";

            }
        }
    }
}

