
namespace ProjectFinante
{
    partial class PanelCheltuieliFixe
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_salveaza = new System.Windows.Forms.Button();
            this.label_recurenta = new System.Windows.Forms.Label();
            this.textBox_valoare = new System.Windows.Forms.TextBox();
            this.label_valoare = new System.Windows.Forms.Label();
            this.label_descriere = new System.Windows.Forms.Label();
            this.textBox_descriere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(14, 187);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker.TabIndex = 35;
            // 
            // btn_salveaza
            // 
            this.btn_salveaza.Location = new System.Drawing.Point(14, 244);
            this.btn_salveaza.Name = "btn_salveaza";
            this.btn_salveaza.Size = new System.Drawing.Size(94, 29);
            this.btn_salveaza.TabIndex = 34;
            this.btn_salveaza.Text = "Salveaza";
            this.btn_salveaza.UseVisualStyleBackColor = true;
            // 
            // label_recurenta
            // 
            this.label_recurenta.AutoSize = true;
            this.label_recurenta.Location = new System.Drawing.Point(14, 163);
            this.label_recurenta.Name = "label_recurenta";
            this.label_recurenta.Size = new System.Drawing.Size(41, 20);
            this.label_recurenta.TabIndex = 33;
            this.label_recurenta.Text = "Data";
            // 
            // textBox_valoare
            // 
            this.textBox_valoare.Location = new System.Drawing.Point(14, 110);
            this.textBox_valoare.Name = "textBox_valoare";
            this.textBox_valoare.Size = new System.Drawing.Size(186, 27);
            this.textBox_valoare.TabIndex = 32;
            // 
            // label_valoare
            // 
            this.label_valoare.AutoSize = true;
            this.label_valoare.Location = new System.Drawing.Point(14, 84);
            this.label_valoare.Name = "label_valoare";
            this.label_valoare.Size = new System.Drawing.Size(59, 20);
            this.label_valoare.TabIndex = 31;
            this.label_valoare.Text = "Valoare";
            // 
            // label_descriere
            // 
            this.label_descriere.AutoSize = true;
            this.label_descriere.Location = new System.Drawing.Point(14, 12);
            this.label_descriere.Name = "label_descriere";
            this.label_descriere.Size = new System.Drawing.Size(71, 20);
            this.label_descriere.TabIndex = 30;
            this.label_descriere.Text = "Descriere";
            // 
            // textBox_descriere
            // 
            this.textBox_descriere.Location = new System.Drawing.Point(14, 35);
            this.textBox_descriere.MaxLength = 500;
            this.textBox_descriere.Name = "textBox_descriere";
            this.textBox_descriere.Size = new System.Drawing.Size(404, 27);
            this.textBox_descriere.TabIndex = 29;
            // 
            // PanelCheltuieliFixe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btn_salveaza);
            this.Controls.Add(this.label_recurenta);
            this.Controls.Add(this.textBox_valoare);
            this.Controls.Add(this.label_valoare);
            this.Controls.Add(this.label_descriere);
            this.Controls.Add(this.textBox_descriere);
            this.Name = "PanelCheltuieliFixe";
            this.Size = new System.Drawing.Size(496, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_salveaza;
        private System.Windows.Forms.Label label_recurenta;
        private System.Windows.Forms.TextBox textBox_valoare;
        private System.Windows.Forms.Label label_valoare;
        private System.Windows.Forms.Label label_descriere;
        private System.Windows.Forms.TextBox textBox_descriere;
    }
}
