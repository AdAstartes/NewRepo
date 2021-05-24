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
    public partial class PanelVenituriFixe : UserControl
    {
        public PanelVenituriFixe()
        {
            InitializeComponent();
        }

        private void textBox_valoare_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.onlyNumbers(sender, e);
        }
    }
}
