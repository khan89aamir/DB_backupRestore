namespace DB_backupRestore.cs
{
    partial class frmDatabaseMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseMaintenance));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBackup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRBrowse = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtDabasePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAutoBackup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAutoBrowse = new System.Windows.Forms.Button();
            this.txtBacupPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblBackup = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbBackup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Database";
            // 
            // cmbBackup
            // 
            this.cmbBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackup.FormattingEnabled = true;
            this.cmbBackup.Location = new System.Drawing.Point(123, 44);
            this.cmbBackup.Name = "cmbBackup";
            this.cmbBackup.Size = new System.Drawing.Size(204, 27);
            this.cmbBackup.TabIndex = 1;
            this.cmbBackup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Database :";
            // 
            // btnBackup
            // 
            this.btnBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.BackgroundImage")));
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Enabled = false;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackup.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(243, 83);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(84, 29);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.button1_Click);
            this.btnBackup.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnBackup.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRBrowse);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.txtDabasePath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore Databsae";
            this.groupBox2.Visible = false;
            // 
            // btnRBrowse
            // 
            this.btnRBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRBrowse.BackgroundImage")));
            this.btnRBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRBrowse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBrowse.Location = new System.Drawing.Point(243, 18);
            this.btnRBrowse.Name = "btnRBrowse";
            this.btnRBrowse.Size = new System.Drawing.Size(84, 29);
            this.btnRBrowse.TabIndex = 4;
            this.btnRBrowse.Text = "Browse";
            this.btnRBrowse.UseVisualStyleBackColor = true;
            this.btnRBrowse.Click += new System.EventHandler(this.button3_Click);
            this.btnRBrowse.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnRBrowse.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // btnRestore
            // 
            this.btnRestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.BackgroundImage")));
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Enabled = false;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestore.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(240, 95);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(85, 29);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.button2_Click);
            this.btnRestore.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnRestore.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // txtDabasePath
            // 
            this.txtDabasePath.BackColor = System.Drawing.Color.White;
            this.txtDabasePath.Location = new System.Drawing.Point(6, 63);
            this.txtDabasePath.Name = "txtDabasePath";
            this.txtDabasePath.ReadOnly = true;
            this.txtDabasePath.Size = new System.Drawing.Size(319, 26);
            this.txtDabasePath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Browse Database To Restore :";
            // 
            // btnAutoBackup
            // 
            this.btnAutoBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoBackup.BackgroundImage = global::DB_backupRestore.Properties.Resources.B_click;
            this.btnAutoBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutoBackup.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoBackup.Location = new System.Drawing.Point(159, 57);
            this.btnAutoBackup.Name = "btnAutoBackup";
            this.btnAutoBackup.Size = new System.Drawing.Size(178, 29);
            this.btnAutoBackup.TabIndex = 4;
            this.btnAutoBackup.Text = "Configure Auto Backup >>";
            this.btnAutoBackup.UseVisualStyleBackColor = true;
            this.btnAutoBackup.Click += new System.EventHandler(this.button4_Click);
            this.btnAutoBackup.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnAutoBackup.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnAutoBrowse);
            this.groupBox3.Controls.Add(this.txtBacupPath);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnApply);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(350, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 256);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configure Auto Backup";
            // 
            // btnAutoBrowse
            // 
            this.btnAutoBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoBrowse.BackgroundImage")));
            this.btnAutoBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutoBrowse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoBrowse.Location = new System.Drawing.Point(325, 65);
            this.btnAutoBrowse.Name = "btnAutoBrowse";
            this.btnAutoBrowse.Size = new System.Drawing.Size(84, 29);
            this.btnAutoBrowse.TabIndex = 9;
            this.btnAutoBrowse.Text = "Browse";
            this.btnAutoBrowse.UseVisualStyleBackColor = true;
            this.btnAutoBrowse.Click += new System.EventHandler(this.button6_Click);
            this.btnAutoBrowse.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnAutoBrowse.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // txtBacupPath
            // 
            this.txtBacupPath.BackColor = System.Drawing.Color.White;
            this.txtBacupPath.Location = new System.Drawing.Point(121, 33);
            this.txtBacupPath.Name = "txtBacupPath";
            this.txtBacupPath.ReadOnly = true;
            this.txtBacupPath.Size = new System.Drawing.Size(288, 26);
            this.txtBacupPath.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(16, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Set Path :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(121, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(149, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Date :";
            this.label4.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApply.BackgroundImage")));
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Enabled = false;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(121, 156);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(84, 29);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.button5_Click);
            this.btnApply.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnApply.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.BackColor = System.Drawing.Color.Transparent;
            this.lblBackup.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.Location = new System.Drawing.Point(3, 0);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(11, 17);
            this.lblBackup.TabIndex = 6;
            this.lblBackup.Text = ":";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblBackup);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(355, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 51);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DB_backupRestore.Properties.Resources.titlebg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 37);
            this.panel1.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "Database Backup / Restore";
            // 
            // frmDatabaseMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_backupRestore.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAutoBackup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabaseMaintenance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Maintenance";
            this.Load += new System.EventHandler(this.Database_Maintenance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtDabasePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnRBrowse;
        private System.Windows.Forms.Button btnAutoBackup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAutoBrowse;
        private System.Windows.Forms.TextBox txtBacupPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}