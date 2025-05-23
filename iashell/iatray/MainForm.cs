using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IADetectDrive;
using System.Threading;
using System.IO;
using System.Diagnostics;
//using iabrowserlib;
using iaforms;

namespace iatray
{
   
    public partial class MainForm : Form
    {
        DriveDetector driveDetector = new DriveDetector();
        static DriveBackup driveBackup = null;
        private BackupManager backupManager;
        private static List<Form> processList = new List<Form>();
        //public static ProgressDialog.ProgressDialog progressDialog = null;
        //bool progressDialogOpen = false;

        

        enum EDriveOperation
        {
            eDeviceArrived,
            eDriveRemoved,
            eQueryRemove,
            eNone
        }

        enum Operation
        {
            eAccessingDrive,
            eInitSearch,
            eSearchFiles,
            eSearchingFiles,
            eFileFindComplete,
            eNone
        }

        private static bool hasBackupStarted = false;
        
        private static bool IsCancel = false;
        private static bool toggle = false;
        private static String path = "";
        private static int filesDone = 0;
        private static int filesCurr = 0;
        private static int noFilesFound = 0;
        private static bool hasFlashDriveInstalled = false;
        
        Thread thread = null;
        
        private static String curSearchPath = null;

        private static Operation operation = Operation.eNone;
        private EDriveOperation driveOperation = EDriveOperation.eNone;

        public static List<Form> ProcessList { get { return processList; } }

        
        public static ImportQueueForm importQueueForm = null;
        public static AttachedDrivesForm attachedDrivesForm = null;
        
        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Visible = true;

            

   //         Jounal Jounal = new Jounal("F:\\", "C:\\test.xml", "TestID", "Full", "Test discription");
            //JounalContentsForm form = new JounalContentsForm("C:\\Temp\\FMM\\Nikon80-4\\full-2010-3-29-12-44");
            //form.ShowDialog();
            if (BackupManager.Init() == false)
            {
                if (RegSetting.IsInstalled == false)
                {
                    MessageBox.Show(
                        "ImgArchive Importer 1.0 application not installed correctly? Please re-install. If this do'es not fix the problem, please contact IDK Software Ltd",
                        "ImgArchive Importer 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(-1);
                }
                if (RegSetting.IsSetup == false)
                {
                    Setup();
                }
            }

            Drives();
            if (BackupManager.HasDrives2Scan())
            {
                ScanDrives();
                timer.Start();
            }
           
            if (HasFlashDrives() == false)
            {
                //flashDriveToolStripMenuItem.Enabled = false;
                
            }
            else
            {
                hasFlashDriveInstalled = true;
            }

            driveDetector.DeviceArrived += new DriveDetectorEventHandler(OnDriveArrived);
            driveDetector.DeviceRemoved += new DriveDetectorEventHandler(OnDriveRemoved);
            driveDetector.QueryRemove += new DriveDetectorEventHandler(OnQueryRemove);

            ImportQueue importQueue = ImportQueue.Instance;
            importQueue.StatusChanged += OnStatusChanged;
            importQueue.Start();
        }

        // Called by DriveDetector when removable device in inserted 
        private void OnDriveArrived(object sender, DriveDetectorEventArgs e)
        {
            String msg = "New volume " + e.Drive + "Click on button to search the drive.";
            driveOperation = EDriveOperation.eDeviceArrived;
            notifyIcon.ShowBalloonTip(1000, "ImgArchive Importer", msg, ToolTipIcon.Info);
            path = e.Drive;

            //flashDriveToolStripMenuItem.Enabled = true;
            
            Drives();
            if (BackupManager.HasDrives2Scan())
            {
                ScanDrives();
            }
        }
        

        // Called by DriveDetector after removable device has been unpluged 
        private void OnDriveRemoved(object sender, DriveDetectorEventArgs e)
        {
            String msg = "Drive removed " + e.Drive;
            driveOperation = EDriveOperation.eDriveRemoved;
            notifyIcon.ShowBalloonTip(500, "ImgArchive Importer", msg, ToolTipIcon.Info);
            path = e.Drive;
            if (HasFlashDrives() == false)
            {
                //flashDriveToolStripMenuItem.Enabled = false;
                
            }
            else
            {
                hasFlashDriveInstalled = true;
            }
            RemoveDrive(e.Drive);
        }

        private void OnQueryRemove(object sender, DriveDetectorEventArgs e)
        {
            String msg = "Query Remove " + e.Drive;
            driveOperation = EDriveOperation.eQueryRemove;
            notifyIcon.ShowBalloonTip(500, "ImgArchive Importer", msg, ToolTipIcon.Info);
            path = e.Drive;
            notifyIcon.Icon = new Icon("redicon.ico");


        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            if (driveOperation == EDriveOperation.eDeviceArrived)
            {
                
                labelImagesFound.Text = "0";
                //driveBackup.TargetPath = path;

                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                FileInfo[] files = directoryInfo.GetFiles();
                int noOfFiles = files.Length;
                this.Text = "ImgArchive Importer - New volume " + path;
                this.WindowState = FormWindowState.Normal;
                this.Visible = true;
                this.TopMost = true;
                timer.Start();
               // Init cotrols
                this.labelPath.Text = "";
                progressBar.Value = 0;
                progressBar.Visible = true;
                timer.Start();
                labelPath.Visible = true;
                labelSearchingFolder.Visible = true;
                buttonBackup.Visible = false;
                BackupManager.DoDrives2Scan();
                hasBackupStarted = true;
                backupTimer.Start();
                //filesFound.RemoveAll();
                noFilesFound = 0;
                IsCancel = false;
                 
            }
            notifyIcon.Icon =  iatray.Properties.Resources.iagreen;

        }

        /**
         *
         */
        private void ScanDrives()
        {
            BackupManager.DoDrives2Scan();
            hasBackupStarted = true;
            backupTimer.Start();
        }

        static void ReadingFiles(string sDir)
        {

            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        filesDone++;
                    }
                    ReadingFiles(d);
                }
            }
            catch (System.Exception excpt)
            {
                //MessageBox.Show(excpt.Message);
            }
        }

        
        

        private void timer_Tick(object sender, EventArgs e)
        {
            /*
            if (toggle == false)
            {
                toggle = true;
                notifyIcon.Icon = SIATray.Properties.Resources.sia;
            }
            else
            {
                toggle = false;
                notifyIcon.Icon = SIATray.Properties.Resources.siagreen;
            }
            */
            /*
            if (operation == Operation.eAccessingDrive)
            {
                this.labelCurrentFile.Text = "Accessing Drive";
            }
            if (operation == Operation.eInitSearch)
            {
                progressBar.Maximum = filesDone;
                progressBar.Minimum = 0;
                this.labelCurrentFile.Text = "Searching file(s)";
                operation = Operation.eSearchFiles;
            }
            if (operation == Operation.eSearchingFiles)
            {
               
                int step = filesDone - filesCurr;
                filesCurr = filesDone;
                this.labelPath.Text = curSearchPath;
                progressBar.Increment(step);
                labelImagesFound.Text = noFilesFound.ToString();
            }
            if (operation == Operation.eFileFindComplete)
            {
                this.labelPath.Text = "";
                progressBar.Visible = false;
                timer.Stop();
                labelPath.Visible = false;
                buttonBackup.Visible = true;
                labelSearchingFolder.Visible = false;
                this.labelCurrentFile.Text = "Searching complete";
            }
             */
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            timer.Stop();
            //this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.TopMost = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //e.Cancel = true;
            timer.Stop();
            //this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            this.TopMost = false;
            IsCancel = true;
        }

        private void buttonViewImages_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            
            
           
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //ExplorerLike form = new ExplorerLike();
            //form.FileListView.ShowFiles("D:\\Users\\501726576\\My Documents\\pics");
            //form.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm();
            propertiesForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void importImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ExplorerLike form = new ExplorerLike();
            //form.FileListView.ShowFiles("D:\\Users\\501726576\\My Documents\\pics");
            //form.ShowDialog();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            //BackupForm form = new BackupForm(driveBackup);
            //form.ShowDialog();

            /*
            if (driveBackup.IsDriveIdentified())
            {

            }
            if (driveBackup.DoesNeedBackup() == true)
            {
                if (driveBackup.IsDriveIdentified())
                {
                    form.DriveLabel = driveBackup.DriveID;
                    form.DriveLabelReadOnly = true;
                }
                else
                {

                }
                form.ShowDialog();
                //driveBackup.FullBackup();
            }

            */


        }

        private void quickBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupTimer_Tick(object sender, EventArgs e)
        {

            if (hasBackupStarted == true)
            {
                if (DriveBackup.TaskPending <= 0)
                {
                    long found = BackupManager.GetImagesFound();
                    String msg = "Scan completed";
                    if (found > 0)
                    {
                        msg = String.Format("Scan completed found {0} images", found);
                    }
                    notifyIcon.ShowBalloonTip(500, "ImgArchive Importer", msg, ToolTipIcon.Info);
                    backupTimer.Stop();
                    hasBackupStarted = false;
                    notifyIcon.Icon = iatray.Properties.Resources.ImgArchive;

                }
            }
            else
            {
                if (DriveBackup.TaskPending > 0)
                {
                    hasBackupStarted = true;
                }
            }
            if (toggle == false)
            {
                toggle = true;
                notifyIcon.Icon = iatray.Properties.Resources.ImgArchive;
            }
            else
            {
                toggle = false;
                notifyIcon.Icon = iatray.Properties.Resources.iagreen;
            }
        }

        private void quickRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RestoreForm form = new RestoreForm();
            //form.ShowDialog();
        }

        private bool HasFlashDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Debug.Print("Drive {0}", d.Name);
                Debug.Print("  File type: {0}", d.DriveType);
                if (d.DriveType == DriveType.Removable)
                {
                    if (d.IsReady == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        

        public void Drives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
           
            foreach (DriveInfo d in allDrives)
            {

                Debug.Print("Drive {0}", d.Name);
                Debug.Print("  File type: {0}", d.DriveType);
                if (d.DriveType == DriveType.Removable)
                {
                    if (d.IsReady == true)
                    {
                        if (BackupManager.DriveList.IsDup(d.Name)) {
                            continue;
                        }
                        DriveBackup db = new DriveBackup(d.Name);
                        BackupManager.DriveList.Push(db);
                        BackupManager.CurrentDB = db;
                        db.Init();

                        db.VolumeLabel = d.VolumeLabel;
                        db.TotalSize = d.TotalSize;
                        db.TotalFreeSpace = d.TotalFreeSpace;
                        db.AvailableFreeSpace = d.AvailableFreeSpace;

                        Debug.Print("  Volume label: {0}", d.VolumeLabel);
                        Debug.Print("  File system: {0}", d.DriveFormat);
                        Debug.Print(
                            "  Available space to current user:{0, 15} bytes",
                            d.AvailableFreeSpace);

                        Debug.Print(
                            "  Total available space:          {0, 15} bytes",
                            d.TotalFreeSpace);

                        Debug.Print(
                            "  Total size of drive:            {0, 15} bytes ",
                            d.TotalSize);

                        Debug.Print(
                           "  Drive letter:            {0, 15} ",
                           db.DriveLetter);

                        Debug.Print(
                           "  Volume label:            {0, 15} ",
                           db.VolumeLabel);

                        Debug.Print(
                           "       Drive ID:            {0, 15} ",
                           db.DriveID);
                    }

                }
            }
           
        }

        public void RemoveDrive(String DriveLetter)
        {
            BackupManager.DriveList.Pop(DriveLetter);
        }

        private void Completed(object sender)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (BackupManager.HasDrives2Scan())
                {
                    ScanDrives();
                }
                else
                {
                    if (BackupManager.HasDrives2Backup())
                    {
                        String msg = "One or more drives to backup";
                        notifyIcon.ShowBalloonTip(500, "ImgArchive Importer", msg, ToolTipIcon.Info);
                    }
                    else
                    {
                        String msg = "Scan completed";
                        notifyIcon.ShowBalloonTip(500, "ImgArchive Importer", msg, ToolTipIcon.Info);
                    }
                    timer.Stop();
                    notifyIcon.Icon = iatray.Properties.Resources.ImgArchive;
                }
            });
        }
        private void OpenProgressDialog()
        {
            /*
            if (progressDialogOpen == false)
            {
                if (progressDialog != null)
                {
                    progressDialog = null;
                }
            }
            if (progressDialog == null)
            {
                progressDialog = new ProgressDialog.ProgressDialog();
                progressDialog.StatusChanged += OnProgressDialogStatusChanged;
            }
            progressDialog.Show();
            progressDialogOpen = true;
            */
        }

        /*
        void OnProgressDialogStatusChanged(ProgressDialog.ProgressDialog.Action action)
        {
            if (action == ProgressDialog.ProgressDialog.Action.Complete)
            {
                progressDialogOpen = false;
            }   
        }
        */
        void OnStatusChanged(ImportStatus param)
        {
            if (param == ImportStatus.InProgress)
            {
                ImportQueue importQueue = ImportQueue.Instance;
                ImportJob job = importQueue.CurrentJob;
                if (this.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        // close the form on the forms thread
                        OpenProgressDialog();
                    });
                }

                
                return;
            }
            
        }
        
        #region Setup

        void Setup()
        {
            while (true)
            {
                if (SettupWizard() == true)
                {
                    break;
                }
                else
                {
                    if ((MessageBox.Show("ImgArchive Import settup Wizard did not complete setting up ImgArchive Import 1.0.\r Do you wish to re-start the setup Wizard?",
                                        "ImgArchive Import 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)) == DialogResult.Yes)
                    {
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("ImgArchive Import connot continue, exiting ImgArchive 1.0\rRe-starting ImgArchive Import will also re-start the setup Wizard, thus enabling you to complete ImgArchive Import setup at another time",
                                        "ImgArchive Import 1.0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Environment.Exit(-1);
                    }
                }
            }
        }

        private bool SettupWizard()
        {
            
            return false;
        }

        #endregion

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FolderImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FolderImportForm form = new FolderImportForm();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                return;
            }
            
        }

        private void flashImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            DriveForm form = new DriveForm();
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                return;
            }
            */
        }

        private void importQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importQueueForm = new ImportQueueForm();
            importQueueForm.Show();
            importQueueForm.WindowState = FormWindowState.Normal;
        }

        private void workspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            
            string workspacePath = regSetting.WorkspacePath;
            Process notePad = new Process();
            notePad.StartInfo.FileName = "explorer.exe";
            notePad.StartInfo.Arguments = workspacePath; // "C:\\Users\\H497222\\ImgArchive\\Workspace";
            notePad.Start();
            */
            
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            String installPath = regSetting.InstallPath;
            //(new MainBrowserForm(workPath, exePath, installPath).Show();
        }

        private void toolStripMenuItemAttachedDrives_Click(object sender, EventArgs e)
        {
            attachedDrivesForm = new AttachedDrivesForm();
            attachedDrivesForm.Show();
            attachedDrivesForm.WindowState = FormWindowState.Normal;
            
        }

        public string GetBytesReadable(long i)
        {
            // Get absolute value
            long absolute_i = (i < 0 ? -i : i);
            // Determine the suffix and readable value
            string suffix;
            double readable;
            if (absolute_i >= 0x1000000000000000) // Exabyte
            {
                suffix = "EB";
                readable = (i >> 50);
            }
            else if (absolute_i >= 0x4000000000000) // Petabyte
            {
                suffix = "PB";
                readable = (i >> 40);
            }
            else if (absolute_i >= 0x10000000000) // Terabyte
            {
                suffix = "TB";
                readable = (i >> 30);
            }
            else if (absolute_i >= 0x40000000) // Gigabyte
            {
                suffix = "GB";
                readable = (i >> 20);
            }
            else if (absolute_i >= 0x100000) // Megabyte
            {
                suffix = "MB";
                readable = (i >> 10);
            }
            else if (absolute_i >= 0x400) // Kilobyte
            {
                suffix = "KB";
                readable = i;
            }
            else
            {
                return i.ToString("0 B"); // Byte
            }
            // Divide by 1024 to get fractional value
            readable = (readable / 1024);
            // Return formatted number with suffix
            return readable.ToString("0.### ") + suffix;
        }

       
    }


}