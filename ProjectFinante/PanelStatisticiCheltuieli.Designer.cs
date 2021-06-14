
namespace ProjectFinante
{
    partial class PanelStatisticiCheltuieli
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
            this.btn_export_data = new System.Windows.Forms.Button();
            this.btn_val_totala = new System.Windows.Forms.Button();
            this.btn_val_medie = new System.Windows.Forms.Button();
            this.recurenta_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Panala = new System.Windows.Forms.Label();
            this.label_Dela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_export_data
            // 
            this.btn_export_data.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_export_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_export_data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_export_data.Location = new System.Drawing.Point(95, 365);
            this.btn_export_data.Name = "btn_export_data";
            this.btn_export_data.Size = new System.Drawing.Size(315, 41);
            this.btn_export_data.TabIndex = 17;
            this.btn_export_data.Text = "Exporta datele";
            this.btn_export_data.UseVisualStyleBackColor = false;
            this.btn_export_data.Click += new System.EventHandler(this.btn_export_data_Click);
            // 
            // btn_val_totala
            // 
            this.btn_val_totala.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_val_totala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_val_totala.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_val_totala.Location = new System.Drawing.Point(95, 247);
            this.btn_val_totala.Name = "btn_val_totala";
            this.btn_val_totala.Size = new System.Drawing.Size(315, 41);
            this.btn_val_totala.TabIndex = 16;
            this.btn_val_totala.Text = "Calculeaza valoarea totala";
            this.btn_val_totala.UseVisualStyleBackColor = false;
            this.btn_val_totala.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_val_medie
            // 
            this.btn_val_medie.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_val_medie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_val_medie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_val_medie.Location = new System.Drawing.Point(95, 307);
            this.btn_val_medie.Name = "btn_val_medie";
            this.btn_val_medie.Size = new System.Drawing.Size(315, 41);
            this.btn_val_medie.TabIndex = 15;
            this.btn_val_medie.Text = "Calculeaza valoarea medie";
            this.btn_val_medie.UseVisualStyleBackColor = false;
            this.btn_val_medie.Click += new System.EventHandler(this.btn_val_medie_Click);
            // 
            // recurenta_box
            // 
            this.recurenta_box.FormattingEnabled = true;
            this.recurenta_box.Items.AddRange(new object[] {
            "Fixe",
            "Recurente",
            "Ambele"});
            this.recurenta_box.Location = new System.Drawing.Point(40, 193);
            this.recurenta_box.Name = "recurenta_box";
            this.recurenta_box.Size = new System.Drawing.Size(150, 28);
            this.recurenta_box.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tip Cheltuieli";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(307, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 27);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label_Panala
            // 
            this.label_Panala.AutoSize = true;
            this.label_Panala.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Panala.Location = new System.Drawing.Point(325, 41);
            this.label_Panala.Name = "label_Panala";
            this.label_Panala.Size = new System.Drawing.Size(115, 20);
            this.label_Panala.TabIndex = 10;
            this.label_Panala.Text = "Pana la data de";
            // 
            // label_Dela
            // 
            this.label_Dela.AutoSize = true;
            this.label_Dela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Dela.Location = new System.Drawing.Point(62, 41);
            this.label_Dela.Name = "label_Dela";
            this.label_Dela.Size = new System.Drawing.Size(100, 20);
            this.label_Dela.TabIndex = 9;
            this.label_Dela.Text = "De la data de";
            // 
            // PanelStatisticiCheltuieli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btn_export_data);
            this.Controls.Add(this.btn_val_totala);
            this.Controls.Add(this.btn_val_medie);
            this.Controls.Add(this.recurenta_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_Panala);
            this.Controls.Add(this.label_Dela);
            this.Name = "PanelStatisticiCheltuieli";
            this.Size = new System.Drawing.Size(496, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_export_data;
        private System.Windows.Forms.Button btn_val_totala;
        private System.Windows.Forms.Button btn_val_medie;
        private System.Windows.Forms.ComboBox recurenta_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Panala;
        private System.Windows.Forms.Label label_Dela;
    }
}
