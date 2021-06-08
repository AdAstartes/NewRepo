
namespace ProjectFinante
{
    partial class DBManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableDropdown = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.listView_tables = new System.Windows.Forms.ListView();
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableDropdown
            // 
            this.tableDropdown.FormattingEnabled = true;
            this.tableDropdown.Location = new System.Drawing.Point(37, 24);
            this.tableDropdown.Name = "tableDropdown";
            this.tableDropdown.Size = new System.Drawing.Size(121, 23);
            this.tableDropdown.TabIndex = 0;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(227, 24);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(142, 23);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Show me the shit";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // listView_tables
            // 
            this.listView_tables.HideSelection = false;
            this.listView_tables.Location = new System.Drawing.Point(37, 129);
            this.listView_tables.Name = "listView_tables";
            this.listView_tables.Size = new System.Drawing.Size(639, 270);
            this.listView_tables.TabIndex = 2;
            this.listView_tables.UseCompatibleStateImageBehavior = false;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(538, 23);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(171, 37);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "button1";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // DBManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.listView_tables);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.tableDropdown);
            this.Name = "DBManagement";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tableDropdown;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ListView listView_tables;
        private System.Windows.Forms.Button testButton;
    }
}