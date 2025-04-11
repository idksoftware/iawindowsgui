using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaforms
{
    public partial class DriveImagesForm : Form
    {
        public DriveImagesForm(DriveInfo driveInfo)
        {
            InitializeComponent();

            // New Volume (D:) - 1.81 TB
            if (driveInfo.VolumeLabel.Length == 0)
            {
                labelTitle.Text = driveInfo.DriveType + " (" + driveInfo.Name + ") - " + GetBytesReadable(driveInfo.TotalSize);
            }
            else
            {
                labelTitle.Text = driveInfo.VolumeLabel + " (" + driveInfo.Name + ") - " +
                                  GetBytesReadable(driveInfo.TotalSize);
            }

            string scanfile = "C:\\Users\\iferg\\AppData\\Local\\Temp\\scan20250103_0001.csv";
            ReadScanFile(scanfile);
            ReadImagePathList(driveInfo.Name);
        }

        private void ReadImagePathList(string rootPath)
        {
            ImagePathList ipl = new ImagePathList(rootPath);
            ipl.Process();
            List<Folder> folders = ipl.AllFolders;

            foreach(var f in folders) 
            {
                
                ListViewItem lvi = new ListViewItem(f.Name);

                lvi.ImageIndex = 0;
                lvi.SubItems.Add(f.Images.ToString());
                lvi.SubItems.Add("");

                //lvi.SubItems.Add(item.DirectoryName);

                listViewImportFiles.Items.Add(lvi);

            }
        }


        Boolean ReadScanFile(String f)
        {
            
            if (!File.Exists(f))
            {
                return false;
            }

            string line;
            using (StreamReader sr = new StreamReader(f))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    FileInfo fileInfo = new FileInfo(line);
                    ListViewItem lvi = new ListViewItem(fileInfo.FullName);

                    lvi.ImageIndex = 0;
                    lvi.SubItems.Add(GetBytesReadable(fileInfo.Length));
                    lvi.SubItems.Add(fileInfo.LastWriteTime.ToShortDateString() + " " + fileInfo.LastWriteTime.ToShortTimeString()); 
                    
                    //lvi.SubItems.Add(item.DirectoryName);

                    listViewImportFiles.Items.Add(lvi);

                }
            }

            return false;
        }


        public void AddImageItems()
        {


            /*
            allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {

                Debug.Print("Drive {0}", d.Name);
                Debug.Print("  File type: {0}", d.DriveType);
                ListViewItem lvi = new ListViewItem(d.Name);

                lvi.ImageIndex = 0;
                lvi.SubItems.Add(d.DriveType.ToString());
                if (d.IsReady == true)
                {
                    lvi.SubItems.Add(GetBytesReadable(d.TotalSize));
                    lvi.SubItems.Add(GetBytesReadable(d.AvailableFreeSpace));
                }
                else
                {
                    lvi.SubItems.Add("Not Ready");
                }
                //lvi.SubItems.Add(item.Length.ToString());
                //lvi.SubItems.Add(item.DirectoryName);

                listViewImportFiles.Items.Add(lvi);
            }
            */
        }


        private void label2_Click(object sender, EventArgs e)
        {

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

        private void labelSixeOnDisk_Click(object sender, EventArgs e)
        {

        }
    }
}
