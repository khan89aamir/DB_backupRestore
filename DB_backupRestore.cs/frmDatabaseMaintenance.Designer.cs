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
            this.cmbBackup = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblbackupDataBase = new System.Windows.Forms.Label();
            this.btnRestore = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDabasePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRestoreDatabase = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlTitle = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.picDBImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAutoBackup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kgrpbackupDB = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox1 = new gGlowBox.gGlowGroupBox();
            this.kgrpRestoreDB = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox2 = new gGlowBox.gGlowGroupBox();
            this.groupBox3 = new gGlowBox.gGlowGroupBox();
            this.btnAutoBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtBacupPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dateTimePicker2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kgrpAutobackup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.lblBackup = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB.Panel)).BeginInit();
            this.kgrpbackupDB.Panel.SuspendLayout();
            this.kgrpbackupDB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpRestoreDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpRestoreDB.Panel)).BeginInit();
            this.kgrpRestoreDB.Panel.SuspendLayout();
            this.kgrpRestoreDB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpAutobackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpAutobackup.Panel)).BeginInit();
            this.kgrpAutobackup.Panel.SuspendLayout();
            this.kgrpAutobackup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.btnBackup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBackup.StateCommon.Border.Rounding = 12;
            this.btnBackup.Values.Text = resources.GetString("btnBackup.Values.Text");
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // cmbBackup
            // 
            this.cmbBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackup.DropDownWidth = 204;
            resources.ApplyResources(this.cmbBackup, "cmbBackup");
            this.cmbBackup.FormattingEnabled = true;
            this.cmbBackup.Name = "cmbBackup";
            this.cmbBackup.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbBackup.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbBackup.SelectionChangeCommitted += new System.EventHandler(this.cmbBackup_SelectionChangeCommitted);
            // 
            // lblbackupDataBase
            // 
            resources.ApplyResources(this.lblbackupDataBase, "lblbackupDataBase");
            this.lblbackupDataBase.BackColor = System.Drawing.Color.Transparent;
            this.lblbackupDataBase.Name = "lblbackupDataBase";
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
            this.btnRestore.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRestore.StateCommon.Border.Rounding = 12;
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
            this.btnRBrowse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRBrowse.StateCommon.Border.Rounding = 12;
            this.btnRBrowse.Values.Text = resources.GetString("btnRBrowse.Values.Text");
            this.btnRBrowse.Click += new System.EventHandler(this.btnRBrowse_Click);
            // 
            // txtDabasePath
            // 
            this.txtDabasePath.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtDabasePath, "txtDabasePath");
            this.txtDabasePath.Name = "txtDabasePath";
            this.txtDabasePath.ReadOnly = true;
            this.txtDabasePath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDabasePath.StateCommon.Border.Rounding = 10;
            // 
            // lblRestoreDatabase
            // 
            resources.ApplyResources(this.lblRestoreDatabase, "lblRestoreDatabase");
            this.lblRestoreDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lblRestoreDatabase.Name = "lblRestoreDatabase";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = global::DB_backupRestore.Properties.Resources.titlebg_green;
            resources.ApplyResources(this.pnlTitle, "pnlTitle");
            this.pnlTitle.Controls.Add(this.picDBImage);
            this.pnlTitle.Controls.Add(this.label7);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.StateCommon.Image = global::DB_backupRestore.Properties.Resources.titlebg_green;
            // 
            // picDBImage
            // 
            this.picDBImage.BackColor = System.Drawing.Color.Transparent;
            this.picDBImage.Image = global::DB_backupRestore.Properties.Resources.backupwhite;
            resources.ApplyResources(this.picDBImage, "picDBImage");
            this.picDBImage.Name = "picDBImage";
            this.picDBImage.TabStop = false;
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
            this.btnAutoBackup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAutoBackup.StateCommon.Border.Rounding = 12;
            this.btnAutoBackup.Values.Text = resources.GetString("btnAutoBackup.Values.Text");
            this.btnAutoBackup.Click += new System.EventHandler(this.btnAutoBackup_Click);
            // 
            // kgrpbackupDB
            // 
            this.kgrpbackupDB.HeaderVisibleSecondary = false;
            resources.ApplyResources(this.kgrpbackupDB, "kgrpbackupDB");
            this.kgrpbackupDB.Name = "kgrpbackupDB";
            // 
            // kgrpbackupDB.Panel
            // 
            this.kgrpbackupDB.Panel.Controls.Add(this.groupBox1);
            this.kgrpbackupDB.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpbackupDB.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kgrpbackupDB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpbackupDB.StateCommon.Border.Rounding = 10;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Back.Image = global::DB_backupRestore.Properties.Resources.titlebg_green;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpbackupDB.ValuesPrimary.Heading = resources.GetString("kgrpbackupDB.ValuesPrimary.Heading");
            this.kgrpbackupDB.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kgrpbackupDB.ValuesPrimary.Image")));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.lblbackupDataBase);
            this.groupBox1.Controls.Add(this.cmbBackup);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.GlowAmount = 22;
            this.groupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.groupBox1.GlowFeather = 60;
            this.groupBox1.GlowOn = true;
            this.groupBox1.Name = "groupBox1";
            // 
            // kgrpRestoreDB
            // 
            this.kgrpRestoreDB.HeaderVisibleSecondary = false;
            resources.ApplyResources(this.kgrpRestoreDB, "kgrpRestoreDB");
            this.kgrpRestoreDB.Name = "kgrpRestoreDB";
            // 
            // kgrpRestoreDB.Panel
            // 
            this.kgrpRestoreDB.Panel.Controls.Add(this.groupBox2);
            this.kgrpRestoreDB.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpRestoreDB.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kgrpRestoreDB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpRestoreDB.StateCommon.Border.Rounding = 10;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Image = ((System.Drawing.Image)(resources.GetObject("kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Image")));
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Border.Color1 = System.Drawing.Color.White;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpRestoreDB.ValuesPrimary.Heading = resources.GetString("kgrpRestoreDB.ValuesPrimary.Heading");
            this.kgrpRestoreDB.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kgrpRestoreDB.ValuesPrimary.Image")));
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.lblRestoreDatabase);
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
            this.groupBox3.Controls.Add(this.lblPath);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.lblTime);
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
            this.btnAutoBrowse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAutoBrowse.StateCommon.Border.Rounding = 12;
            this.btnAutoBrowse.Values.Text = resources.GetString("btnAutoBrowse.Values.Text");
            this.btnAutoBrowse.Click += new System.EventHandler(this.btnAutoBrowse_Click);
            // 
            // lblPath
            // 
            resources.ApplyResources(this.lblPath, "lblPath");
            this.lblPath.BackColor = System.Drawing.Color.Transparent;
            this.lblPath.Name = "lblPath";
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
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 12;
            this.btnSave.Values.Text = resources.GetString("btnSave.Values.Text");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Name = "lblDate";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Name = "lblTime";
            // 
            // txtBacupPath
            // 
            this.txtBacupPath.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtBacupPath, "txtBacupPath");
            this.txtBacupPath.Name = "txtBacupPath";
            this.txtBacupPath.ReadOnly = true;
            this.txtBacupPath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBacupPath.StateCommon.Border.Rounding = 10;
            // 
            // dateTimePicker1
            // 
            this.groupBox3.SetEffectType(this.dateTimePicker1, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.groupBox3.SetsGlowColor(this.dateTimePicker1, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dateTimePicker1.sGlowColor"))));
            this.dateTimePicker1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateTimePicker1.StateCommon.Border.Rounding = 10;
            // 
            // dateTimePicker2
            // 
            this.groupBox3.SetEffectType(this.dateTimePicker2, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.groupBox3.SetsGlowColor(this.dateTimePicker2, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dateTimePicker2.sGlowColor"))));
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateTimePicker2.StateCommon.Border.Rounding = 10;
            // 
            // kgrpAutobackup
            // 
            this.kgrpAutobackup.HeaderVisibleSecondary = false;
            resources.ApplyResources(this.kgrpAutobackup, "kgrpAutobackup");
            this.kgrpAutobackup.Name = "kgrpAutobackup";
            // 
            // kgrpAutobackup.Panel
            // 
            this.kgrpAutobackup.Panel.Controls.Add(this.groupBox3);
            this.kgrpAutobackup.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpAutobackup.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kgrpAutobackup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpAutobackup.StateCommon.Border.Rounding = 10;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Back.Image = ((System.Drawing.Image)(resources.GetObject("kgrpAutobackup.StateCommon.HeaderPrimary.Back.Image")));
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Border.Color1 = System.Drawing.Color.White;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpAutobackup.ValuesPrimary.Heading = resources.GetString("kgrpAutobackup.ValuesPrimary.Heading");
            this.kgrpAutobackup.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kgrpAutobackup.ValuesPrimary.Image")));
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
            // frmDatabaseMaintenance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_backupRestore.Properties.Resources.back_green;
            this.Controls.Add(this.kgrpRestoreDB);
            this.Controls.Add(this.kgrpbackupDB);
            this.Controls.Add(this.kgrpAutobackup);
            this.Controls.Add(this.btnAutoBackup);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabaseMaintenance";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.ShowIcon = false;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 5;
            this.Load += new System.EventHandler(this.Database_Maintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB.Panel)).EndInit();
            this.kgrpbackupDB.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB)).EndInit();
            this.kgrpbackupDB.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpRestoreDB.Panel)).EndInit();
            this.kgrpRestoreDB.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgrpRestoreDB)).EndInit();
            this.kgrpRestoreDB.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpAutobackup.Panel)).EndInit();
            this.kgrpAutobackup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgrpAutobackup)).EndInit();
            this.kgrpAutobackup.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblbackupDataBase;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbBackup;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDabasePath;
        private System.Windows.Forms.Label lblRestoreDatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlTitle;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBackup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRestore;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRBrowse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAutoBackup;
        private gGlowBox.gGlowGroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kgrpbackupDB;
        private gGlowBox.gGlowGroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kgrpRestoreDB;
        private System.Windows.Forms.PictureBox picDBImage;
        private gGlowBox.gGlowGroupBox groupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAutoBrowse;
        private System.Windows.Forms.Label lblPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBacupPath;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kgrpAutobackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}