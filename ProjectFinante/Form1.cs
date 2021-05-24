using System;
using System.Windows.Forms;

namespace ProjectFinante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toggleTab(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "Venituri":
                    panel_venituri.Visible = !panel_venituri.Visible;
                    break;
                case "Cheltuieli":
                    panel_cheltuieli.Visible = !panel_cheltuieli.Visible;
                    break;
                case "Statistici":
                    panel_statistici.Visible = !panel_statistici.Visible;
                    break;
                default: break;
            }
        }

        private void switchInterface(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            String btnName = btn.Tag + "_" + btn.Text;
            panel_main.Controls.Clear();

            switch (btnName)
            {
                case "venituri_Recurente":
                     panel_main.Controls.Add(new PanelVenituriRecurente());
                    break;
                case "venituri_Fixe":
                    panel_main.Controls.Add(new PanelVenituriFixe());
                    break;
                case "cheltuieli_Recurente":
                    panel_main.Controls.Add(new PanelCheltuieliRecurente());
                    break;
                case "cheltuieli_Fixe":
                    panel_main.Controls.Add(new PanelCheltuieliFixe());
                    break;
                case "statistici_Cheltuieli":
                    panel_main.Controls.Add(new PanelStatisticiCheltuieli());
                    break;
                case "statistici_Venituri":
                    panel_main.Controls.Add(new PanelStatisticiVenituri());
                    break;
                case "statistici_Balanta":
                    panel_main.Controls.Add(new PanelStatisticiBalanta());
                    break;
                case "altele_Despre Aplicatie":
                    panel_main.Controls.Add(new PanelAplicatie());
                    break;
                case "altele_Contact":
                    panel_main.Controls.Add(new PanelContact());
                    break;

                default: break;
            }
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
