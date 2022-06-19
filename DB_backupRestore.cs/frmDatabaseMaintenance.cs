using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.IO;
using System.Diagnostics;
using CoreApp;
using ComponentFactory.Krypton.Toolkit;

namespace DB_backupRestore.cs
{
    public partial class frmDatabaseMaintenance : KryptonForm
    {
        public frmDatabaseMaintenance()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(User_Lang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(User_Lang);

            InitializeComponent();
        }

        clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
        clsUtility ObjUtil = new clsUtility();
        clsThreadTask ObjThread = new clsThreadTask();

        string strBackUpPath = string.Empty;
        string DatabaseName = string.Empty;
        string DBName = string.Empty;
        string strRDatabseName;
        string strRestorePath;

        public static string User_Lang = "en-US";
        public bool IsNew = false;

        public delegate void dAddComboItem(string item);

        private void WriteBackupLog(string dbName, string status)
        {
            ObjUtil.WriteToFile("Log Date : " + DateTime.Now.ToString(), "backup.log", true);
            ObjUtil.WriteToFile("Database Name : " + dbName, "backup.log", true);
            ObjUtil.WriteToFile("Status : " + status, "backup.log", true);
            ObjUtil.WriteToFile("______________________________________", "backup.log", true);
        }

        private void LoadTheme()
        {
            //this.BackgroundImage = TAILORING.Properties.Resources.Background;

            btnAutoBackup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnAutoBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnBackup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnRBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            btnRestore.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            if (clsUtility.MessageType.SparklePurple == clsUtility._UserMessageType)
            {
                Lable_Color(Color.White);

                this.BackgroundImage = null;
                this.PaletteMode = PaletteMode.SparklePurple;
                this.BackColor = Color.FromArgb(82, 91, 114);

                pnlTitle.StateCommon.Image = null;
                pnlTitle.PaletteMode = PaletteMode.SparklePurple;

                kgrpbackupDB.StateCommon.HeaderPrimary.Back.Image = null;
                kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Image = null;
                kgrpAutobackup.StateCommon.HeaderPrimary.Back.Image = null;

                kgrpbackupDB.PaletteMode = PaletteMode.SparklePurple;
                kgrpRestoreDB.PaletteMode = PaletteMode.SparklePurple;
                kgrpAutobackup.PaletteMode = PaletteMode.SparklePurple;

                btnAutoBackup.PaletteMode = PaletteMode.SparklePurple;
                btnAutoBrowse.PaletteMode = PaletteMode.SparklePurple;
                btnBackup.PaletteMode = PaletteMode.SparklePurple;
                btnRBrowse.PaletteMode = PaletteMode.SparklePurple;
                btnRestore.PaletteMode = PaletteMode.SparklePurple;
                btnSave.PaletteMode = PaletteMode.SparklePurple;
                cmbBackup.PaletteMode = PaletteMode.SparklePurple;

                //btnSave.Values.Image = Properties.Resources.btnSave_Values_Image;
            }
            else if (clsUtility.MessageType.BlueTheme == clsUtility._UserMessageType)
            {
                Lable_Color(Color.Black);

                //this.BackgroundImage = Properties.Resources.back_green;
                //pnlTitle.StateCommon.Image = Properties.Resources.titlebg_green;
                pnlTitle.StateCommon.Color1 = Color.FromArgb(99, 157, 207);
                pnlTitle.StateCommon.Color2 = Color.FromArgb(99, 157, 207);

                //kgrpbackupDB.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                //kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                //kgrpAutobackup.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;

                kgrpbackupDB.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                kgrpbackupDB.StateCommon.HeaderPrimary.Back.Color2 = Color.FromArgb(99, 157, 207);
                kgrpbackupDB.StateCommon.Border.Color1 = Color.FromArgb(99, 157, 207);
                kgrpbackupDB.StateNormal.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.Color1 = Color.White;
                kgrpbackupDBGlow.BackColor = Color.White;

                kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Color2 = Color.FromArgb(99, 157, 207);
                kgrpRestoreDB.StateCommon.Border.Color1 = Color.FromArgb(99, 157, 207);
                kgrpRestoreDB.StateNormal.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                kgrpRestoreDB.StateCommon.HeaderPrimary.Content.ShortText.Color1 = Color.White;
                kgrpRestoreDBGlow.BackColor = Color.White;

                kgrpAutobackup.StateCommon.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                kgrpAutobackup.StateCommon.HeaderPrimary.Back.Color2 = Color.FromArgb(99, 157, 207);
                kgrpAutobackup.StateCommon.Border.Color1 = Color.FromArgb(99, 157, 207);
                kgrpAutobackup.StateNormal.HeaderPrimary.Back.Color1 = Color.FromArgb(99, 157, 207);
                kgrpAutobackup.StateCommon.HeaderPrimary.Content.ShortText.Color1 = Color.White;
                kgrpAutobackupGlow.BackColor = Color.White;

                kgrpbackupDB.PaletteMode = PaletteMode.Office2007Blue;
                kgrpRestoreDB.PaletteMode = PaletteMode.Office2007Blue;
                kgrpAutobackup.PaletteMode = PaletteMode.Office2007Blue;


                //btnSave.Values.Image = Properties.Resources.btnSave_Values_Image;

                btnAutoBackup.PaletteMode = PaletteMode.Office2007Blue;
                btnAutoBrowse.PaletteMode = PaletteMode.Office2007Blue;
                btnBackup.PaletteMode = PaletteMode.Office2007Blue;
                btnRBrowse.PaletteMode = PaletteMode.Office2007Blue;
                btnRestore.PaletteMode = PaletteMode.Office2007Blue;
                btnSave.PaletteMode = PaletteMode.Office2007Blue;
                cmbBackup.PaletteMode = PaletteMode.Office2007Blue;
            }
            else if (clsUtility.MessageType.Office2007Blue == clsUtility._UserMessageType)
            {
                Lable_Color(Color.Black);

                this.BackgroundImage = Properties.Resources.back_green;
                pnlTitle.StateCommon.Image = Properties.Resources.titlebg_green;

                kgrpbackupDB.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                kgrpAutobackup.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;

                kgrpbackupDB.PaletteMode = PaletteMode.Office2007Blue;
                kgrpRestoreDB.PaletteMode = PaletteMode.Office2007Blue;
                kgrpAutobackup.PaletteMode = PaletteMode.Office2007Blue;

                this.PaletteMode = PaletteMode.Office2007Blue;
                this.BackColor = Color.White;

                kgrpAutobackup.PaletteMode = PaletteMode.Office2007Blue;
                cmbBackup.PaletteMode = PaletteMode.Office2007Blue;

                //btnSave.Values.Image = Properties.Resources.btnSave_Values_Image;

                btnAutoBackup.PaletteMode = PaletteMode.Office2007Blue;
                btnAutoBrowse.PaletteMode = PaletteMode.Office2007Blue;
                btnBackup.PaletteMode = PaletteMode.Office2007Blue;
                btnRBrowse.PaletteMode = PaletteMode.Office2007Blue;
                btnRestore.PaletteMode = PaletteMode.Office2007Blue;
                btnSave.PaletteMode = PaletteMode.Office2007Blue;
                cmbBackup.PaletteMode = PaletteMode.Office2007Blue;
            }
            else if (clsUtility.MessageType.Office2010Blue == clsUtility._UserMessageType)
            {
                Lable_Color(Color.Black);

                this.BackgroundImage = Properties.Resources.back_green;
                pnlTitle.StateCommon.Image = Properties.Resources.titlebg_green;

                kgrpbackupDB.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                kgrpRestoreDB.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;
                kgrpAutobackup.StateCommon.HeaderPrimary.Back.Image = Properties.Resources.titlebg_green;

                kgrpbackupDB.PaletteMode = PaletteMode.Office2010Blue;
                kgrpRestoreDB.PaletteMode = PaletteMode.Office2010Blue;
                kgrpAutobackup.PaletteMode = PaletteMode.Office2010Blue;

                this.PaletteMode = PaletteMode.Office2010Blue;
                this.BackColor = Color.White;

                kgrpAutobackup.PaletteMode = PaletteMode.Office2010Blue;
                cmbBackup.PaletteMode = PaletteMode.Office2010Blue;

                //btnSave.Values.Image = Properties.Resources.btnSave_Values_Image;

                btnAutoBackup.PaletteMode = PaletteMode.Office2010Blue;
                btnAutoBrowse.PaletteMode = PaletteMode.Office2010Blue;
                btnBackup.PaletteMode = PaletteMode.Office2010Blue;
                btnRBrowse.PaletteMode = PaletteMode.Office2010Blue;
                btnRestore.PaletteMode = PaletteMode.Office2010Blue;
                btnSave.PaletteMode = PaletteMode.Office2010Blue;
                cmbBackup.PaletteMode = PaletteMode.Office2010Blue;
            }
        }

        private void Lable_Color(Color clr)
        {
            lblBackup.ForeColor = clr;
            lblbackupDataBase.ForeColor = clr;
            lblDate.ForeColor = clr;
            lblPath.ForeColor = clr;
            lblRestoreDatabase.ForeColor = clr;
            lblTime.ForeColor = clr;
        }

        private void BackUpDatabase()
        {
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    ObjThread.SetLoadingProgressPercent(i, 100);
                }
                //if (File.Exists(strBackUpPath + @"\" + DatabaseName + ".bak"))
                //{
                //    File.Delete(strBackUpPath + @"\" + DatabaseName + ".bak");
                //}

                string sqlcmd = "BACKUP database " + DatabaseName + " TO DISK='" + strBackUpPath + @"\" + DatabaseName + ".bak' WITH INIT";

                //added by aamir 26-06-2016
                //File.Delete(strBackUpPath + @"\" + DatabaseName + ".bak");
                //end

                int result = ObjDAL.ExecuteNonQuery(sqlcmd);

                if (result > 0 || result != -1)
                {
                    WriteBackupLog(DatabaseName, "Backup Created Successfully");
                    clsUtility.ShowInfoMessage("BACKUP DATABASE successfully.", clsUtility.strProjectTitle);
                    System.Diagnostics.Process.Start(strBackUpPath);
                }
                else
                {
                    WriteBackupLog(DatabaseName, "Failed to create the backup.");
                    clsUtility.ShowErrorMessage("Failed to create the backup.", clsUtility.strProjectTitle);
                }
                ObjThread.CloseLoadingDialog();
                //System.Diagnostics.Process.Start("DatabaseBackupService.exe");

            }
            catch (Exception ex)
            {
                WriteBackupLog(DatabaseName, "Backup DATABASE Faild.");
                ObjThread.CloseLoadingDialog();
                clsUtility.ShowInfoMessage("BACKUP DATABASE Faild.", clsUtility.strProjectTitle);
            }
        }
        private void KillbackupDatabase()
        {
            Process[] p = System.Diagnostics.Process.GetProcessesByName("DatabaseBackupService");
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].ProcessName == "DatabaseBackupService")
                {
                    p[i].Kill();
                }
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select your folder where database backup will be saved.";
            DialogResult d = folderBrowserDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                //KillbackupDatabase();//closing auto database backup service
                strBackUpPath = folderBrowserDialog1.SelectedPath;
                DatabaseName = cmbBackup.SelectedItem.ToString();
                //ObjLoading.label1.Text = "Operation in progress please wait.";
                ObjThread.ShowLoadingDialog(clsUtility.strProjectTitle, "Backup in progress please wait. ", this);
                Thread th = new Thread(BackUpDatabase);
                th.Start();
            }
        }

        private void AddItem(string strItem)
        {
            if (cmbBackup.InvokeRequired)
            {
                dAddComboItem d = new dAddComboItem(AddItem);
                this.Invoke(d, new object[] { strItem });
            }
            else
            {
                cmbBackup.Items.Add(strItem);
            }
        }
        void LoadConnection()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    ObjThread.SetLoadingProgressPercent(i, 100);
                }
                DataTable dt = ObjDAL.ExecuteSelectStatement("SELECT * FROM sys.databases WHERE name NOT IN('master','model','msdb','tempdb','ReportServer','ReportServerTempDB')");
                string str = string.Empty;

                if (ObjUtil.ValidateTable(dt))
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        str = dt.Rows[i][0].ToString();
                        AddItem(str.Trim());
                    }
                }
                ObjThread.CloseLoadingDialog();
            }
            catch (Exception ex)
            {
                ObjThread.CloseLoadingDialog();
                clsUtility.ShowErrorMessage(ex.ToString(), clsUtility.strProjectTitle);
            }
        }

        private void Database_Maintenance_Load(object sender, EventArgs e)
        {
            //clsUtility._UserMessageType = clsUtility.MessageType.SparklePurple;
            //clsUtility._UserMessageType = clsUtility.MessageType.Office2010Blue;
            //clsUtility._UserMessageType = clsUtility.MessageType.Office2007Blue;
            //clsUtility._UserMessageType = clsUtility.MessageType.BlueTheme;

            //DBName = ObjDAL.GetCurrentDBName(true);
            LoadTheme();

            this.Size = new Size(364, 446);

            CheckAutobackup();

            ObjThread.ShowLoadingDialog(clsUtility.strProjectTitle, "Loading Please Wait...", this);
            Thread th = new Thread(LoadConnection);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void CheckAutobackup()
        {
            try
            {
                DataTable dt = ObjDAL.GetData(clsUtility.DBName + ".dbo.BackupConfig", "ISNULL(IsAutoBackup,0)=1", "BackupID");
                if (ObjUtil.ValidateTable(dt))
                {
                    flowLayoutPanel1.Visible = true;
                    btnAutoBackup.Visible = true;
                    lblBackup.Text = "Last Backup Path " + dt.Rows[0]["Path"].ToString() + "" + " On " + Convert.ToDateTime(dt.Rows[0]["Date"]).ToString("dd/MM/yyyy hh:mm:ss tt");
                }
                else
                {
                    lblBackup.Text = string.Empty;
                    //flowLayoutPanel1.Visible = false;
                    //btnAutoBackup.Visible = false;
                }
            }
            catch (Exception ex)
            {
                clsUtility.ShowErrorMessage(ex.ToString(), clsUtility.strProjectTitle);
            }
        }

        private void RestoreDataBase()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    ObjThread.SetLoadingProgressPercent(i, 100);
                }
                string sqlcmd = "use master RESTORE DATABASE " + strRDatabseName + " FROM DISK='" + strRestorePath + "' with replace";
                int a = ObjDAL.ExecuteNonQuery(sqlcmd);
                ObjThread.CloseLoadingDialog();
                if (a > 0 || a != -1)
                {
                    clsUtility.ShowInfoMessage("RESTORE DATABASE successfully.", clsUtility.strProjectTitle);
                }
                else
                {
                    clsUtility.ShowInfoMessage("Unable to RESTORE DATABASE ", clsUtility.strProjectTitle);
                    return;
                }
            }
            catch (Exception ex)
            {
                ObjThread.CloseLoadingDialog();
                WriteBackupLog(DatabaseName, "Restoring Failed.\n Reason : " + ex.ToString());
                clsUtility.ShowInfoMessage(ex.ToString(), clsUtility.strProjectTitle);
            }
            //RESTORE DATABASE database_name FROM backup_device WITH RECOVERY
        }

        private void btnRBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Obj = new OpenFileDialog();
            Obj.Filter = "Database Backup File (*.bak)|*.bak|All files (*.*)|*.*";
            DialogResult d = Obj.ShowDialog();
            if (d == DialogResult.OK)
            {
                strRestorePath = Obj.FileName;
                FileInfo objfile = new FileInfo(strRestorePath);
                strRDatabseName = Path.GetFileNameWithoutExtension(Obj.FileName);
                btnRestore.Enabled = true;
                txtDabasePath.Text = Obj.FileName;
            }
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            ObjThread.ShowLoadingDialog(clsUtility.strProjectTitle, "Restoring Please Wait...", this);
            Thread th = new Thread(RestoreDataBase);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            btnRestore.Enabled = false;
            txtDabasePath.Clear();

        }
        int inc = 0;
        private void btnAutoBackup_Click(object sender, EventArgs e)
        {
            inc++;
            if (inc % 2 == 0)
            {
                this.Size = new Size(364, 446);
                btnAutoBackup.Text = "Configure Auto Backup >>";
            }
            else
            {
                this.Size = new Size(801, 446);
                btnAutoBackup.Text = "Configure Auto Backup <<";
                dateTimePicker2.Value = DateTime.Now;
                try
                {
                    object p = ObjDAL.ExecuteScalar("SELECT Path FROM " + clsUtility.DBName + ".dbo.BackupConfig WITH(NOLOCK) WHERE LEN(Path)>0 AND ISNULL(IsAutoBackup,0)=1 AND BackupID=1");
                    if (p != null && Directory.Exists(p.ToString()))
                    {
                        txtBackupPath.Text = p.ToString();
                        dateTimePicker2.Enabled = true;
                        btnSave.Enabled = true;
                    }
                    else
                    {
                        clsUtility.ShowInfoMessage("No Default backup folder found..");
                    }
                }
                catch (Exception ex)
                {
                    ObjUtil.WriteToFile("Exception Occured while getting auto path in button4_Click() " + ex.Message, "backup.log", true);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                KillbackupDatabase();//closing auto database backup service
                if (Directory.Exists(txtBackupPath.Text))
                {
                    if (ObjDAL.CountRecords(clsUtility.DBName + ".dbo.BackupConfig  ") > 0)
                    {
                        ObjDAL.UpdateColumnData("Path", SqlDbType.NVarChar, txtBackupPath.Text.Trim());
                        //ObjDAL.UpdateColumnData("Date", SqlDbType.Date, dateTimePicker1.Value);
                        ObjDAL.UpdateColumnData("Date", SqlDbType.Date, dateTimePicker2.Value);
                        ObjDAL.UpdateColumnData("Time", SqlDbType.DateTime, dateTimePicker2.Value);
                        int a = ObjDAL.UpdateData(clsUtility.DBName + ".dbo.BackupConfig", "BackupID=1");
                        if (a > 0)
                        {
                            clsUtility.ShowInfoMessage("Backup Configure Successfully.", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        ObjDAL.SetColumnData("Path", SqlDbType.NVarChar, txtBackupPath.Text.Trim());
                        ObjDAL.SetColumnData("Date", SqlDbType.Date, dateTimePicker1.Value);
                        ObjDAL.SetColumnData("Time", SqlDbType.DateTime, dateTimePicker2.Value);
                        ObjDAL.SetColumnData("IsAutoBackup", SqlDbType.Bit, 1);
                        int a = ObjDAL.InsertData(clsUtility.DBName + ".dbo.BackupConfig", false);
                        if (a > 0)
                        {
                            clsUtility.ShowInfoMessage("Backup Configure Successfully.", clsUtility.strProjectTitle);
                        }
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("Path is not exist", clsUtility.strProjectTitle);
                    return;
                }
                inc++;
                this.Size = new Size(364, 446);
                btnAutoBackup.Text = "Configure Auto Backup >>";
                StartBackupService();
            }
            catch (Exception ex)
            {
                clsUtility.ShowInfoMessage(ex.ToString(), clsUtility.strProjectTitle);
            }
        }
        private void StartBackupService()
        {
            if (File.Exists("DatabaseBackupService.exe"))
            {
                Process.Start("DatabaseBackupService.exe");
            }
            else
            {
                WriteBackupLog(DatabaseName, "Failed to start backup service because backup service is not found..");
            }
        }
        private void btnAutoBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Obj = new FolderBrowserDialog();
            Obj.Description = "Select your location to save your backup file.";
            DialogResult d = Obj.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtBackupPath.Text = Obj.SelectedPath;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void cmbBackup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBackup.SelectedIndex >= 0)
            {
                btnBackup.Enabled = true;
            }
        }
    }
}