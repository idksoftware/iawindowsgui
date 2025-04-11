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
    public partial class AttachedDrivesForm : Form
    {
        private DriveInfo[] allDrives = null;
        public AttachedDrivesForm()
        {
            InitializeComponent();
            AddDriveItems();
        }

        public void AddDriveItems()
        {
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

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listViewImportFiles.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {
                string address;
                string file = item.SubItems[0].Text;
                //string path = item.SubItems[4].Text;
                DriveInfo driveInfo = allDrives[item.Index];
                (new DrivePropertiesForm(driveInfo)).Show();
                //GetAddress(path, out address);
                //(new LogForm(address, file, exePath, workPath)).Show();
                //frm.S

            }
            
        }

        private void listViewImportFiles_Click(object sender, EventArgs e)
        {

        }

        private void listViewImportFiles_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listViewImportFiles.SelectedItems;
            Trace.WriteLine("buttonMasterBackup2_Click");
            foreach (ListViewItem item in selectedList)
            {
                DriveInfo driveInfo = allDrives[item.Index];

                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Personal;
                //folderBrowserDialog.RootFolder
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    /*
                    if (pathLocation != null)
                    {
                        folderBrowserDialog.SelectedPath = pathLocation;
                    }
                    string temp = textBoxMasterBackup2.Text;
                    textBoxMasterBackup2.Text = folderBrowser.SelectedPath;
                    if (string.Compare(temp, textBoxMasterBackup2.Text) != 0)
                    {
                        //changesList.MasterBackup2PathChanged = true;
                    }
                    */
                }
            }
        }


    }
}

