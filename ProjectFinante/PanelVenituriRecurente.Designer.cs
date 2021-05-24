
namespace ProjectFinante
{
    partial class PanelVenituriRecurente
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
            this.btn_salveaza = new System.Windows.Forms.Button();
            this.comboBox_recurenta = new System.Windows.Forms.ComboBox();
            this.label_recurenta = new System.Windows.Forms.Label();
            this.textBox_valoare = new System.Windows.Forms.TextBox();
            this.label_valoare = new System.Windows.Forms.Label();
            this.label_descriere = new System.Windows.Forms.Label();
            this.textBox_descriere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_salveaza
            // 
            this.btn_salveaza.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_salveaza.Location = new System.Drawing.Point(21, 252);
            this.btn_salveaza.Name = "btn_salveaza";
            this.btn_salveaza.Size = new System.Drawing.Size(95, 30);
            this.btn_salveaza.TabIndex = 27;
            this.btn_salveaza.Text = "Salveaza";
            this.btn_salveaza.UseVisualStyleBackColor = false;
            this.btn_salveaza.Click += new System.EventHandler(this.btn_salveaza_Click);
            // 
            // comboBox_recurenta
            // 
            this.comboBox_recurenta.FormattingEnabled = true;
            this.comboBox_recurenta.Items.AddRange(new object[] {
            "Zi",
            "Saptamana",
            "Luna",
            "Trimestru",
            "An"});
            this.comboBox_recurenta.Location = new System.Drawing.Point(19, 198);
            this.comboBox_recurenta.Name = "comboBox_recurenta";
            this.comboBox_recurenta.Size = new System.Drawing.Size(186, 28);
            this.comboBox_recurenta.TabIndex = 26;
            // 
            // label_recurenta
            // 
            this.label_recurenta.AutoSize = true;
            this.label_recurenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_recurenta.Location = new System.Drawing.Point(19, 171);
            this.label_recurenta.Name = "label_recurenta";
            this.label_recurenta.Size = new System.Drawing.Size(80, 20);
            this.label_recurenta.TabIndex = 25;
            this.label_recurenta.Text = "Recurenta";
            // 
            // textBox_valoare
            // 
            this.textBox_valoare.Location = new System.Drawing.Point(21, 118);
            this.textBox_valoare.Name = "textBox_valoare";
            this.textBox_valoare.Size = new System.Drawing.Size(186, 27);
            this.textBox_valoare.TabIndex = 24;
            this.textBox_valoare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // label_valoare
            // 
            this.label_valoare.AutoSize = true;
            this.label_valoare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_valoare.Location = new System.Drawing.Point(19, 92);
            this.label_valoare.Name = "label_valoare";
            this.label_valoare.Size = new System.Drawing.Size(61, 20);
            this.label_valoare.TabIndex = 23;
            this.label_valoare.Text = "Valoare";
            // 
            // label_descriere
            // 
            this.label_descriere.AutoSize = true;
            this.label_descriere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_descriere.Location = new System.Drawing.Point(19, 20);
            this.label_descriere.Name = "label_descriere";
            this.label_descriere.Size = new System.Drawing.Size(74, 20);
            this.label_descriere.TabIndex = 22;
            this.label_descriere.Text = "Descriere";
            // 
            // textBox_descriere
            // 
            this.textBox_descriere.Location = new System.Drawing.Point(21, 43);
            this.textBox_descriere.MaxLength = 500;
            this.textBox_descriere.Name = "textBox_descriere";
            this.textBox_descriere.Size = new System.Drawing.Size(400, 27);
            this.textBox_descriere.TabIndex = 21;
            // 
            // PanelVenituriRecurente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btn_salveaza);
            this.Controls.Add(this.comboBox_recurenta);
            this.Controls.Add(this.label_recurenta);
            this.Controls.Add(this.textBox_valoare);
            this.Controls.Add(this.label_valoare);
            this.Controls.Add(this.label_descriere);
            this.Controls.Add(this.textBox_descriere);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "PanelVenituriRecurente";
            this.Size = new System.Drawing.Size(496, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salveaza;
        private System.Windows.Forms.ComboBox comboBox_recurenta;
        private System.Windows.Forms.Label label_recurenta;
        private System.Windows.Forms.TextBox textBox_valoare;
        private System.Windows.Forms.Label label_valoare;
        private System.Windows.Forms.Label label_descriere;
        private System.Windows.Forms.TextBox textBox_descriere;
    }
}
