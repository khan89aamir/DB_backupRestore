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
            this.btnRBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDabasePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblRestoreDatabase = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlTitle = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.picDBImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAutoBackup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kgrpbackupDB = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kgrpbackupDBGlow = new gGlowBox.gGlowGroupBox();
            this.kgrpRestoreDB = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.kgrpRestoreDBGlow = new gGlowBox.gGlowGroupBox();
            this.kgrpAutobackupGlow = new gGlowBox.gGlowGroupBox();
            this.btnAutoBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtBackupPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dateTimePicker2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kgrpAutobackup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.lblBackup = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRestore = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtBacupPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB.Panel)).BeginInit();
            this.kgrpbackupDB.Panel.SuspendLayout();
            this.kgrpbackupDB.SuspendLayout();
            this.kgrpbackupDBGlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpRestoreDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpRestoreDB.Panel)).BeginInit();
            this.kgrpRestoreDB.Panel.SuspendLayout();
            this.kgrpRestoreDB.SuspendLayout();
            this.kgrpRestoreDBGlow.SuspendLayout();
            this.kgrpAutobackupGlow.SuspendLayout();
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
            this.kgrpbackupDBGlow.SetEffectType(this.btnBackup, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnBackup.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnBackup.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnBackup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kgrpbackupDBGlow.SetsGlowColor(this.btnBackup, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnBackup.sGlowColor"))));
            this.btnBackup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBackup.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.cmbBackup.StateCommon.ComboBox.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.cmbBackup.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbBackup.SelectionChangeCommitted += new System.EventHandler(this.cmbBackup_SelectionChangeCommitted);
            // 
            // lblbackupDataBase
            // 
            resources.ApplyResources(this.lblbackupDataBase, "lblbackupDataBase");
            this.lblbackupDataBase.BackColor = System.Drawing.Color.Transparent;
            this.lblbackupDataBase.Name = "lblbackupDataBase";
            // 
            // btnRBrowse
            // 
            resources.ApplyResources(this.btnRBrowse, "btnRBrowse");
            this.btnRBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kgrpRestoreDBGlow.SetEffectType(this.btnRBrowse, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnRBrowse.Name = "btnRBrowse";
            this.btnRBrowse.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnRBrowse.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnRBrowse.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnRBrowse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kgrpRestoreDBGlow.SetsGlowColor(this.btnRBrowse, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnRBrowse.sGlowColor"))));
            this.btnRBrowse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRBrowse.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.txtDabasePath.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.btnAutoBackup.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAutoBackup.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnAutoBackup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnAutoBackup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAutoBackup.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.kgrpbackupDB.Panel.Controls.Add(this.kgrpbackupDBGlow);
            this.kgrpbackupDB.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpbackupDB.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpbackupDB.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kgrpbackupDB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpbackupDB.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpbackupDB.StateCommon.Border.Rounding = 10;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kgrpbackupDB.ValuesPrimary.Heading = resources.GetString("kgrpbackupDB.ValuesPrimary.Heading");
            this.kgrpbackupDB.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kgrpbackupDB.ValuesPrimary.Image")));
            // 
            // kgrpbackupDBGlow
            // 
            this.kgrpbackupDBGlow.BackColor = System.Drawing.Color.Transparent;
            this.kgrpbackupDBGlow.Controls.Add(this.btnBackup);
            this.kgrpbackupDBGlow.Controls.Add(this.lblbackupDataBase);
            this.kgrpbackupDBGlow.Controls.Add(this.cmbBackup);
            resources.ApplyResources(this.kgrpbackupDBGlow, "kgrpbackupDBGlow");
            this.kgrpbackupDBGlow.GlowAmount = 22;
            this.kgrpbackupDBGlow.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.kgrpbackupDBGlow.GlowFeather = 60;
            this.kgrpbackupDBGlow.GlowOn = true;
            this.kgrpbackupDBGlow.Name = "kgrpbackupDBGlow";
            // 
            // kgrpRestoreDB
            // 
            this.kgrpRestoreDB.HeaderVisibleSecondary = false;
            resources.ApplyResources(this.kgrpRestoreDB, "kgrpRestoreDB");
            this.kgrpRestoreDB.Name = "kgrpRestoreDB";
            // 
            // kgrpRestoreDB.Panel
            // 
            this.kgrpRestoreDB.Panel.Controls.Add(this.kgrpRestoreDBGlow);
            this.kgrpRestoreDB.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpRestoreDB.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpRestoreDB.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kgrpRestoreDB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpRestoreDB.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpRestoreDB.StateCommon.Border.Rounding = 10;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Border.Color1 = System.Drawing.Color.White;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpRestoreDB.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kgrpRestoreDB.ValuesPrimary.Heading = resources.GetString("kgrpRestoreDB.ValuesPrimary.Heading");
            this.kgrpRestoreDB.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kgrpRestoreDB.ValuesPrimary.Image")));
            // 
            // kgrpRestoreDBGlow
            // 
            this.kgrpRestoreDBGlow.BackColor = System.Drawing.Color.Transparent;
            this.kgrpRestoreDBGlow.Controls.Add(this.btnRestore);
            this.kgrpRestoreDBGlow.Controls.Add(this.lblRestoreDatabase);
            this.kgrpRestoreDBGlow.Controls.Add(this.btnRBrowse);
            this.kgrpRestoreDBGlow.Controls.Add(this.txtDabasePath);
            resources.ApplyResources(this.kgrpRestoreDBGlow, "kgrpRestoreDBGlow");
            this.kgrpRestoreDBGlow.GlowAmount = 22;
            this.kgrpRestoreDBGlow.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.kgrpRestoreDBGlow.GlowFeather = 60;
            this.kgrpRestoreDBGlow.GlowOn = true;
            this.kgrpRestoreDBGlow.Name = "kgrpRestoreDBGlow";
            // 
            // kgrpAutobackupGlow
            // 
            this.kgrpAutobackupGlow.BackColor = System.Drawing.Color.Transparent;
            this.kgrpAutobackupGlow.Controls.Add(this.btnAutoBrowse);
            this.kgrpAutobackupGlow.Controls.Add(this.lblPath);
            this.kgrpAutobackupGlow.Controls.Add(this.btnSave);
            this.kgrpAutobackupGlow.Controls.Add(this.lblDate);
            this.kgrpAutobackupGlow.Controls.Add(this.lblTime);
            this.kgrpAutobackupGlow.Controls.Add(this.txtBackupPath);
            this.kgrpAutobackupGlow.Controls.Add(this.dateTimePicker1);
            this.kgrpAutobackupGlow.Controls.Add(this.dateTimePicker2);
            resources.ApplyResources(this.kgrpAutobackupGlow, "kgrpAutobackupGlow");
            this.kgrpAutobackupGlow.GlowAmount = 22;
            this.kgrpAutobackupGlow.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.kgrpAutobackupGlow.GlowFeather = 60;
            this.kgrpAutobackupGlow.GlowOn = true;
            this.kgrpAutobackupGlow.Name = "kgrpAutobackupGlow";
            // 
            // btnAutoBrowse
            // 
            resources.ApplyResources(this.btnAutoBrowse, "btnAutoBrowse");
            this.btnAutoBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kgrpAutobackupGlow.SetEffectType(this.btnAutoBrowse, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnAutoBrowse.Name = "btnAutoBrowse";
            this.btnAutoBrowse.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnAutoBrowse.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAutoBrowse.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnAutoBrowse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kgrpAutobackupGlow.SetsGlowColor(this.btnAutoBrowse, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnAutoBrowse.sGlowColor"))));
            this.btnAutoBrowse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAutoBrowse.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.kgrpAutobackupGlow.SetEffectType(this.btnSave, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnSave.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnSave.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kgrpAutobackupGlow.SetsGlowColor(this.btnSave, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnSave.sGlowColor"))));
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            // txtBackupPath
            // 
            this.txtBackupPath.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtBackupPath, "txtBackupPath");
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBackupPath.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtBackupPath.StateCommon.Border.Rounding = 10;
            // 
            // dateTimePicker1
            // 
            this.kgrpAutobackupGlow.SetEffectType(this.dateTimePicker1, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kgrpAutobackupGlow.SetsGlowColor(this.dateTimePicker1, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dateTimePicker1.sGlowColor"))));
            this.dateTimePicker1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateTimePicker1.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dateTimePicker1.StateCommon.Border.Rounding = 10;
            // 
            // dateTimePicker2
            // 
            this.kgrpAutobackupGlow.SetEffectType(this.dateTimePicker2, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kgrpAutobackupGlow.SetsGlowColor(this.dateTimePicker2, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("dateTimePicker2.sGlowColor"))));
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dateTimePicker2.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.kgrpAutobackup.Panel.Controls.Add(this.kgrpAutobackupGlow);
            this.kgrpAutobackup.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpAutobackup.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpAutobackup.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kgrpAutobackup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpAutobackup.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpAutobackup.StateCommon.Border.Rounding = 10;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Border.Color1 = System.Drawing.Color.White;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kgrpAutobackup.StateCommon.HeaderPrimary.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
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
            // btnRestore
            // 
            resources.ApplyResources(this.btnRestore, "btnRestore");
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kgrpRestoreDBGlow.SetEffectType(this.btnRestore, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnRestore.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnRestore.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnRestore.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kgrpRestoreDBGlow.SetsGlowColor(this.btnRestore, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnRestore.sGlowColor"))));
            this.btnRestore.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRestore.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnRestore.StateCommon.Border.Rounding = 12;
            this.btnRestore.Values.Text = resources.GetString("kryptonButton1.Values.Text");
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
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
            this.txtBacupPath.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtBacupPath.StateCommon.Border.Rounding = 10;
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
            this.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.kgrpbackupDBGlow.ResumeLayout(false);
            this.kgrpbackupDBGlow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpRestoreDB.Panel)).EndInit();
            this.kgrpRestoreDB.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgrpRestoreDB)).EndInit();
            this.kgrpRestoreDB.ResumeLayout(false);
            this.kgrpRestoreDBGlow.ResumeLayout(false);
            this.kgrpRestoreDBGlow.PerformLayout();
            this.kgrpAutobackupGlow.ResumeLayout(false);
            this.kgrpAutobackupGlow.PerformLayout();
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRBrowse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAutoBackup;
        private gGlowBox.gGlowGroupBox kgrpbackupDBGlow;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kgrpbackupDB;
        private gGlowBox.gGlowGroupBox kgrpRestoreDBGlow;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kgrpRestoreDB;
        private System.Windows.Forms.PictureBox picDBImage;
        private gGlowBox.gGlowGroupBox kgrpAutobackupGlow;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAutoBrowse;
        private System.Windows.Forms.Label lblPath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBackupPath;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateTimePicker2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kgrpAutobackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRestore;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBacupPath;
    }
}