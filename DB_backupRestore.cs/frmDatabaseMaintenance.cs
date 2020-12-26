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

namespace DB_backupRestore.cs
{
    public partial class frmDatabaseMaintenance : Form
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

        Image B_Leave = DB_backupRestore.Properties.Resources.B_click;
        Image B_Enter = DB_backupRestore.Properties.Resources.B_on;
        string strBackUpPath = string.Empty;
        string DatabaseName = string.Empty;
        string DBName = string.Empty;

        public static string User_Lang = "en-US";
        public bool IsNew = false;

        public delegate void dAddComboItem(string item);

        private void ButtonMouserEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }
        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void WriteBackupLog(string dbName, string status)
        {
            ObjUtil.WriteToFile("Log Date : " + DateTime.Now.ToString(), "backup.log", true);
            ObjUtil.WriteToFile("Database Name : " + dbName, "backup.log", true);
            ObjUtil.WriteToFile("Status : " + status, "backup.log", true);
            ObjUtil.WriteToFile("______________________________________", "backup.log", true);
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
        private void button1_Click(object sender, EventArgs e)
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

                if (dt != null)
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
            if (IsNew)
            {
                this.BackgroundImage = DB_backupRestore.Properties.Resources.back_green;
                pnlTitle.BackgroundImage = DB_backupRestore.Properties.Resources.titlebg_green;
            }
            else
            {
                this.BackgroundImage = DB_backupRestore.Properties.Resources.back;
                pnlTitle.BackgroundImage = DB_backupRestore.Properties.Resources.titlebg;
            }
            DBName = ObjDAL.GetCurrentDBName(true);
            this.Size = new Size(358, 402);
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
                DataTable dt = ObjDAL.GetData(DBName + ".dbo.BackupConfig", "IsAutoBackup=1", "BackupID");
                if (dt != null && dt.Rows.Count > 0)
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBackup.SelectedIndex >= 0)
            {
                btnBackup.Enabled = true;
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
        string strRDatabseName;
        string strRestorePath;

        private void button3_Click(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
        {
            ObjThread.ShowLoadingDialog(clsUtility.strProjectTitle, "Restoring Please Wait...", this);
            Thread th = new Thread(RestoreDataBase);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            btnRestore.Enabled = false;
            txtDabasePath.Clear();

        }
        int inc = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            inc++;
            if (inc % 2 == 0)
            {
                this.Size = new Size(358, 402);
                btnAutoBackup.Text = "Configure Auto Backup >>";
            }
            else
            {
                this.Size = new Size(787, 402);
                btnAutoBackup.Text = "Configure Auto Backup <<";
                dateTimePicker2.Value = DateTime.Now;
                try
                {
                    object p = ObjDAL.ExecuteScalar("select Path from " + DBName + ".dbo.BackupConfig with(nolock) where len(Path)>0 and isnull(IsAutoBackup,0)=1 and BackupID=1");
                    if (Directory.Exists(p.ToString()))
                    {
                        txtBacupPath.Text = p.ToString();
                        dateTimePicker2.Enabled = true;
                        btnApply.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    ObjUtil.WriteToFile("Exception Occured while getting auto path in button4_Click() " + ex.Message, "backup.log", true);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                KillbackupDatabase();//closing auto database backup service
                if (Directory.Exists(txtBacupPath.Text))
                {
                    if (ObjDAL.CountRecords(DBName + ".dbo.BackupConfig  ") > 0)
                    {
                        ObjDAL.UpdateColumnData("Path", SqlDbType.NVarChar, txtBacupPath.Text.Trim());
                        //ObjDAL.UpdateColumnData("Date", SqlDbType.Date, dateTimePicker1.Value);
                        ObjDAL.UpdateColumnData("Date", SqlDbType.Date, dateTimePicker2.Value);
                        ObjDAL.UpdateColumnData("Time", SqlDbType.DateTime, dateTimePicker2.Value);
                        int a = ObjDAL.UpdateData(DBName + ".dbo.BackupConfig", "BackupID=1");
                        if (a > 0)
                        {
                            clsUtility.ShowInfoMessage("Backup Configure Successfully.", clsUtility.strProjectTitle);
                        }
                    }
                    else
                    {
                        ObjDAL.SetColumnData("Path", SqlDbType.NVarChar, txtBacupPath.Text.Trim());
                        ObjDAL.SetColumnData("Date", SqlDbType.Date, dateTimePicker1.Value);
                        ObjDAL.SetColumnData("Time", SqlDbType.DateTime, dateTimePicker2.Value);
                        ObjDAL.SetColumnData("IsAutoBackup", SqlDbType.Bit, 1);
                        int a = ObjDAL.InsertData(DBName + ".dbo.BackupConfig", false);
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
                this.Size = new Size(364, 401);
                btnAutoBackup.Text = "Configure Auto Backup >>";
                StartBackupService();
            }
            catch (Exception ex) { clsUtility.ShowInfoMessage(ex.ToString(), clsUtility.strProjectTitle); }
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
        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Obj = new FolderBrowserDialog();
            Obj.Description = "Select your location to save your backup file.";
            DialogResult d = Obj.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtBacupPath.Text = Obj.SelectedPath;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                btnApply.Enabled = true;
            }
        }
    }
}