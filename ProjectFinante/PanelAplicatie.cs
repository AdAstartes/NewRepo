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
    public partial class PanelAplicatie : UserControl
    {
        public PanelAplicatie()
        {
            InitializeComponent();
        }

        private void label_Descriere_App_Click(object sender, EventArgs e)
        {

        }
        public partial class ucLabel : Label
        {
            private ToolTip _tt = new ToolTip();

            public string TooltipText { get; set; }

            public ucLabel() : base()
            {
                _tt.AutoPopDelay = 1500;
                _tt.InitialDelay = 400;
                //            _tt.IsBalloon = true;
                _tt.UseAnimation = true;
                _tt.UseFading = true;
                _tt.Active = true;
                this.MouseEnter += new EventHandler(this.ucLabel_MouseEnter);
            }

            private void ucLabel_MouseEnter(object sender, EventArgs ea)
            {
                if (!string.IsNullOrEmpty(this.TooltipText))
                {
                    _tt.SetToolTip(this, this.TooltipText);
                    _tt.Show(this.TooltipText, this.Parent);
                }
            }
        }

        private void PanelAplicatie_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }
    }
}