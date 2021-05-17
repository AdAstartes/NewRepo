
namespace ProjectFinante
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_statistici = new System.Windows.Forms.Panel();
            this.btn_statistici_venituri = new System.Windows.Forms.Button();
            this.btn_statistici_cheltuieli = new System.Windows.Forms.Button();
            this.btn_tab_statistici = new System.Windows.Forms.Button();
            this.panel_cheltuieli = new System.Windows.Forms.Panel();
            this.btn_cheltuieli_fixe = new System.Windows.Forms.Button();
            this.btn_cheltuieli_recurente = new System.Windows.Forms.Button();
            this.btn_tab_cheltuieli = new System.Windows.Forms.Button();
            this.panel_venituri = new System.Windows.Forms.Panel();
            this.btn_venituri_fixe = new System.Windows.Forms.Button();
            this.btn_venituri_recurente = new System.Windows.Forms.Button();
            this.btn_tab_venituri = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_statistici.SuspendLayout();
            this.panel_cheltuieli.SuspendLayout();
            this.panel_venituri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.AutoScroll = true;
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.panel_menu.Controls.Add(this.panel_statistici);
            this.panel_menu.Controls.Add(this.btn_tab_statistici);
            this.panel_menu.Controls.Add(this.panel_cheltuieli);
            this.panel_menu.Controls.Add(this.btn_tab_cheltuieli);
            this.panel_menu.Controls.Add(this.panel_venituri);
            this.panel_menu.Controls.Add(this.btn_tab_venituri);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(250, 459);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_statistici
            // 
            this.panel_statistici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_statistici.Controls.Add(this.btn_statistici_venituri);
            this.panel_statistici.Controls.Add(this.btn_statistici_cheltuieli);
            this.panel_statistici.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_statistici.Location = new System.Drawing.Point(0, 299);
            this.panel_statistici.Name = "panel_statistici";
            this.panel_statistici.Size = new System.Drawing.Size(250, 82);
            this.panel_statistici.TabIndex = 8;
            this.panel_statistici.Visible = false;
            // 
            // btn_statistici_venituri
            // 
            this.btn_statistici_venituri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_statistici_venituri.FlatAppearance.BorderSize = 0;
            this.btn_statistici_venituri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistici_venituri.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_statistici_venituri.Location = new System.Drawing.Point(0, 40);
            this.btn_statistici_venituri.Name = "btn_statistici_venituri";
            this.btn_statistici_venituri.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_statistici_venituri.Size = new System.Drawing.Size(250, 40);
            this.btn_statistici_venituri.TabIndex = 1;
            this.btn_statistici_venituri.Tag = "statistici";
            this.btn_statistici_venituri.Text = "Venituri";
            this.btn_statistici_venituri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistici_venituri.UseVisualStyleBackColor = true;
            // 
            // btn_statistici_cheltuieli
            // 
            this.btn_statistici_cheltuieli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_statistici_cheltuieli.FlatAppearance.BorderSize = 0;
            this.btn_statistici_cheltuieli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statistici_cheltuieli.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_statistici_cheltuieli.Location = new System.Drawing.Point(0, 0);
            this.btn_statistici_cheltuieli.Name = "btn_statistici_cheltuieli";
            this.btn_statistici_cheltuieli.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_statistici_cheltuieli.Size = new System.Drawing.Size(250, 40);
            this.btn_statistici_cheltuieli.TabIndex = 0;
            this.btn_statistici_cheltuieli.Tag = "statistici";
            this.btn_statistici_cheltuieli.Text = "Cheltuieli";
            this.btn_statistici_cheltuieli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistici_cheltuieli.UseVisualStyleBackColor = true;
            // 
            // btn_tab_statistici
            // 
            this.btn_tab_statistici.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tab_statistici.Location = new System.Drawing.Point(0, 254);
            this.btn_tab_statistici.Name = "btn_tab_statistici";
            this.btn_tab_statistici.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tab_statistici.Size = new System.Drawing.Size(250, 45);
            this.btn_tab_statistici.TabIndex = 7;
            this.btn_tab_statistici.Text = "Statistici";
            this.btn_tab_statistici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_statistici.UseVisualStyleBackColor = true;
            this.btn_tab_statistici.Click += new System.EventHandler(this.toggleTab);
            // 
            // panel_cheltuieli
            // 
            this.panel_cheltuieli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_cheltuieli.Controls.Add(this.btn_cheltuieli_fixe);
            this.panel_cheltuieli.Controls.Add(this.btn_cheltuieli_recurente);
            this.panel_cheltuieli.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cheltuieli.Location = new System.Drawing.Point(0, 172);
            this.panel_cheltuieli.Name = "panel_cheltuieli";
            this.panel_cheltuieli.Size = new System.Drawing.Size(250, 82);
            this.panel_cheltuieli.TabIndex = 5;
            this.panel_cheltuieli.Visible = false;
            // 
            // btn_cheltuieli_fixe
            // 
            this.btn_cheltuieli_fixe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cheltuieli_fixe.FlatAppearance.BorderSize = 0;
            this.btn_cheltuieli_fixe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cheltuieli_fixe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cheltuieli_fixe.Location = new System.Drawing.Point(0, 40);
            this.btn_cheltuieli_fixe.Name = "btn_cheltuieli_fixe";
            this.btn_cheltuieli_fixe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_cheltuieli_fixe.Size = new System.Drawing.Size(250, 40);
            this.btn_cheltuieli_fixe.TabIndex = 1;
            this.btn_cheltuieli_fixe.Tag = "cheltuieli";
            this.btn_cheltuieli_fixe.Text = "Fixe";
            this.btn_cheltuieli_fixe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cheltuieli_fixe.UseVisualStyleBackColor = true;
            this.btn_cheltuieli_fixe.Click += new System.EventHandler(this.switchInterface);
            // 
            // btn_cheltuieli_recurente
            // 
            this.btn_cheltuieli_recurente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cheltuieli_recurente.FlatAppearance.BorderSize = 0;
            this.btn_cheltuieli_recurente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cheltuieli_recurente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cheltuieli_recurente.Location = new System.Drawing.Point(0, 0);
            this.btn_cheltuieli_recurente.Name = "btn_cheltuieli_recurente";
            this.btn_cheltuieli_recurente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_cheltuieli_recurente.Size = new System.Drawing.Size(250, 40);
            this.btn_cheltuieli_recurente.TabIndex = 0;
            this.btn_cheltuieli_recurente.Tag = "cheltuieli";
            this.btn_cheltuieli_recurente.Text = "Recurente";
            this.btn_cheltuieli_recurente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cheltuieli_recurente.UseVisualStyleBackColor = true;
            this.btn_cheltuieli_recurente.Click += new System.EventHandler(this.switchInterface);
            // 
            // btn_tab_cheltuieli
            // 
            this.btn_tab_cheltuieli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tab_cheltuieli.Location = new System.Drawing.Point(0, 127);
            this.btn_tab_cheltuieli.Name = "btn_tab_cheltuieli";
            this.btn_tab_cheltuieli.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tab_cheltuieli.Size = new System.Drawing.Size(250, 45);
            this.btn_tab_cheltuieli.TabIndex = 4;
            this.btn_tab_cheltuieli.Text = "Cheltuieli";
            this.btn_tab_cheltuieli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_cheltuieli.UseVisualStyleBackColor = true;
            this.btn_tab_cheltuieli.Click += new System.EventHandler(this.toggleTab);
            // 
            // panel_venituri
            // 
            this.panel_venituri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel_venituri.Controls.Add(this.btn_venituri_fixe);
            this.panel_venituri.Controls.Add(this.btn_venituri_recurente);
            this.panel_venituri.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_venituri.Location = new System.Drawing.Point(0, 45);
            this.panel_venituri.Name = "panel_venituri";
            this.panel_venituri.Size = new System.Drawing.Size(250, 82);
            this.panel_venituri.TabIndex = 2;
            this.panel_venituri.Visible = false;
            // 
            // btn_venituri_fixe
            // 
            this.btn_venituri_fixe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_venituri_fixe.FlatAppearance.BorderSize = 0;
            this.btn_venituri_fixe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venituri_fixe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_venituri_fixe.Location = new System.Drawing.Point(0, 40);
            this.btn_venituri_fixe.Name = "btn_venituri_fixe";
            this.btn_venituri_fixe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_venituri_fixe.Size = new System.Drawing.Size(250, 40);
            this.btn_venituri_fixe.TabIndex = 1;
            this.btn_venituri_fixe.Tag = "venituri";
            this.btn_venituri_fixe.Text = "Fixe";
            this.btn_venituri_fixe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_venituri_fixe.UseVisualStyleBackColor = true;
            this.btn_venituri_fixe.Click += new System.EventHandler(this.switchInterface);
            // 
            // btn_venituri_recurente
            // 
            this.btn_venituri_recurente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_venituri_recurente.FlatAppearance.BorderSize = 0;
            this.btn_venituri_recurente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venituri_recurente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_venituri_recurente.Location = new System.Drawing.Point(0, 0);
            this.btn_venituri_recurente.Name = "btn_venituri_recurente";
            this.btn_venituri_recurente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_venituri_recurente.Size = new System.Drawing.Size(250, 40);
            this.btn_venituri_recurente.TabIndex = 0;
            this.btn_venituri_recurente.Tag = "venituri";
            this.btn_venituri_recurente.Text = "Recurente";
            this.btn_venituri_recurente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_venituri_recurente.UseVisualStyleBackColor = true;
            this.btn_venituri_recurente.Click += new System.EventHandler(this.switchInterface);
            // 
            // btn_tab_venituri
            // 
            this.btn_tab_venituri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tab_venituri.Location = new System.Drawing.Point(0, 0);
            this.btn_tab_venituri.Name = "btn_tab_venituri";
            this.btn_tab_venituri.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tab_venituri.Size = new System.Drawing.Size(250, 45);
            this.btn_tab_venituri.TabIndex = 1;
            this.btn_tab_venituri.Text = "Venituri";
            this.btn_tab_venituri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tab_venituri.UseVisualStyleBackColor = true;
            this.btn_tab_venituri.Click += new System.EventHandler(this.toggleTab);
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(257, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(642, 459);
            this.panel_main.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(899, 459);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menu);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "EVIDENTA FINANCIARA";
            this.panel_menu.ResumeLayout(false);
            this.panel_statistici.ResumeLayout(false);
            this.panel_cheltuieli.ResumeLayout(false);
            this.panel_venituri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_cheltuieli;
        private System.Windows.Forms.Button btn_cheltuieli_fixe;
        private System.Windows.Forms.Button btn_cheltuieli_recurente;
        private System.Windows.Forms.Button btn_tab_cheltuieli;
        private System.Windows.Forms.Panel panel_venituri;
        private System.Windows.Forms.Button btn_venituri_fixe;
        private System.Windows.Forms.Button btn_venituri_recurente;
        private System.Windows.Forms.Button btn_tab_venituri;
        private System.Windows.Forms.Panel panel_statistici;
        private System.Windows.Forms.Button btn_statistici_venituri;
        private System.Windows.Forms.Button btn_statistici_cheltuieli;
        private System.Windows.Forms.Button btn_tab_statistici;
        private System.Windows.Forms.Panel panel_main;
    }
}

