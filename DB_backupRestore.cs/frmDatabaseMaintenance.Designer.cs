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
            this.btnApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbBackup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBackup);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cmbBackup
            // 
            this.cmbBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackup.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBackup, "cmbBackup");
            this.cmbBackup.Name = "cmbBackup";
            this.cmbBackup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // btnBackup
            // 
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Name = "btnBackup";
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
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnRBrowse
            // 
            resources.ApplyResources(this.btnRBrowse, "btnRBrowse");
            this.btnRBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRBrowse.Name = "btnRBrowse";
            this.btnRBrowse.UseVisualStyleBackColor = true;
            this.btnRBrowse.Click += new System.EventHandler(this.button3_Click);
            this.btnRBrowse.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnRBrowse.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // btnRestore
            // 
            resources.ApplyResources(this.btnRestore, "btnRestore");
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.button2_Click);
            this.btnRestore.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnRestore.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // txtDabasePath
            // 
            this.txtDabasePath.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtDabasePath, "txtDabasePath");
            this.txtDabasePath.Name = "txtDabasePath";
            this.txtDabasePath.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // btnAutoBackup
            // 
            this.btnAutoBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoBackup.BackgroundImage = global::DB_backupRestore.Properties.Resources.B_click;
            resources.ApplyResources(this.btnAutoBackup, "btnAutoBackup");
            this.btnAutoBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoBackup.Name = "btnAutoBackup";
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
            this.groupBox3.Controls.Add(this.btnApply);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnAutoBrowse
            // 
            resources.ApplyResources(this.btnAutoBrowse, "btnAutoBrowse");
            this.btnAutoBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoBrowse.Name = "btnAutoBrowse";
            this.btnAutoBrowse.UseVisualStyleBackColor = true;
            this.btnAutoBrowse.Click += new System.EventHandler(this.button6_Click);
            this.btnAutoBrowse.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnAutoBrowse.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // txtBacupPath
            // 
            this.txtBacupPath.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtBacupPath, "txtBacupPath");
            this.txtBacupPath.Name = "txtBacupPath";
            this.txtBacupPath.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.button5_Click);
            this.btnApply.MouseEnter += new System.EventHandler(this.ButtonMouserEnter);
            this.btnApply.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // lblBackup
            // 
            resources.ApplyResources(this.lblBackup, "lblBackup");
            this.lblBackup.BackColor = System.Drawing.Color.Transparent;
            this.lblBackup.Name = "lblBackup";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblBackup);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = global::DB_backupRestore.Properties.Resources.titlebg;
            resources.ApplyResources(this.pnlTitle, "pnlTitle");
            this.pnlTitle.Controls.Add(this.label7);
            this.pnlTitle.Name = "pnlTitle";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // frmDatabaseMaintenance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_backupRestore.Properties.Resources.back;
            this.Controls.Add(this.pnlTitle);
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
            this.Load += new System.EventHandler(this.Database_Maintenance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
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
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label7;
    }
}