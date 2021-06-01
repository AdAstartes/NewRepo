
namespace ProjectFinante
{
    partial class PanelAplicatie
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Descriere_App = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_Descriere_App
            // 
            this.label_Descriere_App.AutoSize = true;
            this.label_Descriere_App.Location = new System.Drawing.Point(0, 0);
            this.label_Descriere_App.Name = "label_Descriere_App";
            this.label_Descriere_App.Size = new System.Drawing.Size(99, 20);
            this.label_Descriere_App.TabIndex = 0;
            this.label_Descriere_App.Text = "DescriereApp";
            this.label_Descriere_App.Click += new System.EventHandler(this.label_Descriere_App_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Beige;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(53, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(535, 255);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "\nintroduce text aici";
            // 
            // PanelAplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_Descriere_App);
            this.Name = "PanelAplicatie";
            this.Size = new System.Drawing.Size(650, 494);
            this.Load += new System.EventHandler(this.PanelAplicatie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Descriere_App;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
