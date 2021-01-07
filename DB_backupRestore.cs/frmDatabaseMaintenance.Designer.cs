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
            this.btnBackup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbBackup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestore = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDabasePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblBackup = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAutoBackup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox1 = new gGlowBox.gGlowGroupBox();
            this.kryptonHeaderGroup2 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox2 = new gGlowBox.gGlowGroupBox();
            this.groupBox3 = new gGlowBox.gGlowGroupBox();
            this.btnAutoBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBacupPath = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).BeginInit();
            this.kryptonHeaderGroup2.Panel.SuspendLayout();
            this.kryptonHeaderGroup2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.SetEffectType(this.btnBackup, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnBackup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.groupBox1.SetsGlowColor(this.btnBackup, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnBackup.sGlowColor"))));
            this.btnBackup.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnBackup.Values.Text = resources.GetString("btnBackup.Values.Text");
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // cmbBackup
            // 
            this.cmbBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox1.SetEffectType(this.cmbBackup, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.cmbBackup, "cmbBackup");
            this.cmbBackup.FormattingEnabled = true;
            this.cmbBackup.Name = "cmbBackup";
            this.groupBox1.SetsGlowColor(this.cmbBackup, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("cmbBackup.sGlowColor"))));
            this.cmbBackup.SelectionChangeCommitted += new System.EventHandler(this.cmbBackup_SelectionChangeCommitted);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // btnRestore
            // 
            resources.ApplyResources(this.btnRestore, "btnRestore");
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.SetEffectType(this.btnRestore, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnRestore.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.groupBox2.SetsGlowColor(this.btnRestore, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnRestore.sGlowColor"))));
            this.btnRestore.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnRestore.Values.Text = resources.GetString("btnRestore.Values.Text");
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRBrowse
            // 
            resources.ApplyResources(this.btnRBrowse, "btnRBrowse");
            this.btnRBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.SetEffectType(this.btnRBrowse, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnRBrowse.Name = "btnRBrowse";
            this.btnRBrowse.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnRBrowse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.groupBox2.SetsGlowColor(this.btnRBrowse, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnRBrowse.sGlowColor"))));
            this.btnRBrowse.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnRBrowse.Values.Text = resources.GetString("btnRBrowse.Values.Text");
            this.btnRBrowse.Click += new System.EventHandler(this.btnRBrowse_Click);
            // 
            // txtDabasePath
            // 
            this.txtDabasePath.BackColor = System.Drawing.Color.White;
            this.groupBox2.SetEffectType(this.txtDabasePath, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtDabasePath, "txtDabasePath");
            this.txtDabasePath.Name = "txtDabasePath";
            this.txtDabasePath.ReadOnly = true;
            this.groupBox2.SetsGlowColor(this.txtDabasePath, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtDabasePath.sGlowColor"))));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // lblBackup
            // 
            resources.ApplyResources(this.lblBackup, "lblBackup");
            this.lblBackup.BackColor = System.Drawing.Color.Transparent;
            this.lblBackup.Name = "lblBackup";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblBackup);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = global::DB_backupRestore.Properties.Resources.titlebg_green;
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
            // btnAutoBackup
            // 
            resources.ApplyResources(this.btnAutoBackup, "btnAutoBackup");
            this.btnAutoBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoBackup.Name = "btnAutoBackup";
            this.btnAutoBackup.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnAutoBackup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAutoBackup.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnAutoBackup.Values.Text = resources.GetString("btnAutoBackup.Values.Text");
            this.btnAutoBackup.Click += new System.EventHandler(this.btnAutoBackup_Click);
            // 
            // kryptonHeaderGroup1
            // 
            resources.ApplyResources(this.kryptonHeaderGroup1, "kryptonHeaderGroup1");
            this.kryptonHeaderGroup1.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox1);
            this.kryptonHeaderGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = resources.GetString("kryptonHeaderGroup1.ValuesPrimary.Heading");
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBackup);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.GlowAmount = 22;
            this.groupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.groupBox1.GlowFeather = 60;
            this.groupBox1.GlowOn = true;
            this.groupBox1.Name = "groupBox1";
            // 
            // kryptonHeaderGroup2
            // 
            resources.ApplyResources(this.kryptonHeaderGroup2, "kryptonHeaderGroup2");
            this.kryptonHeaderGroup2.HeaderVisibleSecondary = false;
            this.kryptonHeaderGroup2.Name = "kryptonHeaderGroup2";
            // 
            // kryptonHeaderGroup2.Panel
            // 
            this.kryptonHeaderGroup2.Panel.Controls.Add(this.groupBox2);
            this.kryptonHeaderGroup2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup2.ValuesPrimary.Heading = resources.GetString("kryptonHeaderGroup2.ValuesPrimary.Heading");
            this.kryptonHeaderGroup2.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup2.ValuesPrimary.Image")));
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRBrowse);
            this.groupBox2.Controls.Add(this.txtDabasePath);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.GlowAmount = 22;
            this.groupBox2.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.groupBox2.GlowFeather = 60;
            this.groupBox2.GlowOn = true;
            this.groupBox2.Name = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnAutoBrowse);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBacupPath);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.GlowAmount = 22;
            this.groupBox3.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.groupBox3.GlowFeather = 60;
            this.groupBox3.GlowOn = true;
            this.groupBox3.Name = "groupBox3";
            // 
            // btnAutoBrowse
            // 
            resources.ApplyResources(this.btnAutoBrowse, "btnAutoBrowse");
            this.btnAutoBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.SetEffectType(this.btnAutoBrowse, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnAutoBrowse.Name = "btnAutoBrowse";
            this.btnAutoBrowse.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnAutoBrowse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.groupBox3.SetsGlowColor(this.btnAutoBrowse, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnAutoBrowse.sGlowColor"))));
            this.btnAutoBrowse.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnAutoBrowse.Values.Text = resources.GetString("btnAutoBrowse.Values.Text");
            this.btnAutoBrowse.Click += new System.EventHandler(this.btnAutoBrowse_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.SetEffectType(this.btnSave, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.groupBox3.SetsGlowColor(this.btnSave, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnSave.sGlowColor"))));
            this.btnSave.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnSave.Values.Image = global::DB_backupRestore.Properties.Resources.btnSave_Values_Image;
            this.btnSave.Values.Text = resources.GetString("btnSave.Values.Text");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // txtBacupPath
            // 
            this.txtBacupPath.BackColor = System.Drawing.Color.White;
            this.groupBox3.SetEffectType(this.txtBacupPath, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.txtBacupPath, "txtBacupPath");
            this.txtBacupPath.Name = "txtBacupPath";
            this.txtBacupPath.ReadOnly = true;
            this.groupBox3.SetsGlowColor(this.txtBacupPath, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("txtBacupPath.sGlowColor"))));
            // 
            // dateTimePicker1
            // 
            this.groupBox3.SetEffectType(this.dateTimePicker1, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.groupBox3.SetsGlowColor(this.dateTimePicker1, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dateTimePicker1.sGlowColor"))));
            // 
            // dateTimePicker2
            // 
            this.groupBox3.SetEffectType(this.dateTimePicker2, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.groupBox3.SetsGlowColor(this.dateTimePicker2, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dateTimePicker2.sGlowColor"))));
            this.dateTimePicker2.ShowUpDown = true;
            // 
            // grpKrytonHeader
            // 
            resources.ApplyResources(this.grpKrytonHeader, "grpKrytonHeader");
            this.grpKrytonHeader.HeaderVisibleSecondary = false;
            this.grpKrytonHeader.Name = "grpKrytonHeader";
            // 
            // grpKrytonHeader.Panel
            // 
            this.grpKrytonHeader.Panel.Controls.Add(this.groupBox3);
            this.grpKrytonHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.ValuesPrimary.Heading = resources.GetString("grpKrytonHeader.ValuesPrimary.Heading");
            this.grpKrytonHeader.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("grpKrytonHeader.ValuesPrimary.Image")));
            // 
            // frmDatabaseMaintenance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_backupRestore.Properties.Resources.back_green;
            this.Controls.Add(this.kryptonHeaderGroup2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Controls.Add(this.grpKrytonHeader);
            this.Controls.Add(this.btnAutoBackup);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabaseMaintenance";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Database_Maintenance_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2.Panel)).EndInit();
            this.kryptonHeaderGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup2)).EndInit();
            this.kryptonHeaderGroup2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBackup;
        private System.Windows.Forms.TextBox txtDabasePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBackup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRestore;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRBrowse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAutoBackup;
        private gGlowBox.gGlowGroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private gGlowBox.gGlowGroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private gGlowBox.gGlowGroupBox groupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAutoBrowse;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBacupPath;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
    }
}