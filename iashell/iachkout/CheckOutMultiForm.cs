﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iaforms;
using System.IO;
using ProgressDialog;
using System.Threading.Tasks;


namespace iachkout
{
    /*
    
    */
    public partial class CheckOutMultiForm : Form
    {
        //private static List<Form> processList = new List<Form>();
        public static ProgressDialog.ProgressDialogForm progressDialog = null;
        bool progressDialogOpen = false;
        String exePath;
        String workingPath;
        String fullPath;
        string file;
        String chkinFilePath;
        IDictionary<string, DateTime> chkinTimes = new Dictionary<string, DateTime>();
        public CheckOutMultiForm(string file, string ep, string wp)
        {
            exePath = ep;
            workingPath = wp;
            
            InitializeComponent();
            List<FileInfo> fileIist = new List<FileInfo>();
            //string box_msg = file;
            //string box_title = "Image Archive";
            //MessageBox.Show(box_msg, box_title);
            ReadImportListFile(file, fileIist);
            AddImportItems(fileIist);
        }

        public void AddImportItems(List<FileInfo> fileIist)
        {

            foreach (FileInfo item in fileIist)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                DateTime lastmodified = item.LastWriteTime;
                string dateString = lastmodified.ToString("HH:mm MM/dd/yyyy");
                lvi.ImageIndex = 0;
                DateTime dt;
                if (chkinTimes.TryGetValue(item.Name, out dt))
                {
                    if (DateTime.Compare(lastmodified, dt) > 0)
                    {
                        lvi.ImageIndex = 2;
                    }
                    else
                    {
                        lvi.ImageIndex = 1;
                    }
                }
                lvi.SubItems.Add(dateString);
                lvi.SubItems.Add(item.Extension);
                lvi.SubItems.Add(item.Length.ToString());
                lvi.SubItems.Add(item.DirectoryName);
                listViewImportFiles.Items.Add(lvi);
            }
        }
        public bool ReadImportListFile(string path, List<FileInfo> fileIist)
        {
            //string box_msg = path;
            //string box_title = "Image Archive";
            //MessageBox.Show(box_msg, box_title);
            bool first = true;
            if (File.Exists(path))
            {
                // Read all the content in one string 
                // and display the string 
                string[] lines = File.ReadAllLines(path);
                foreach (string ln in lines)
                {
                    var fileItem = new FileInfo(ln);
                    if (first)
                    {
                        chkinFilePath = fileItem.DirectoryName;
                        chkinFilePath += "\\.imga\\chkout.dat";
                        ReadChkinFile(chkinFilePath);
                        first = false;
                    }
                    
                    if (fileItem.Exists == false)
                    {
                        continue;
                    }
                    fileIist.Add(fileItem);

                }

            }
            return true;
        }

        public bool ReadChkinFile(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string ln in lines)
                {
                    int pos = ln.IndexOf(':');
                    if (pos == -1)
                    {
                        continue;
                    }
                    String filename = ln.Substring(0, pos);
                    String timeStr = ln.Substring(pos + 1, ln.Length - (pos + 1));
                    int t = Int32.Parse(timeStr);
                    System.DateTime dt = new System.DateTime(1970, 1, 1).AddSeconds(t);
                    chkinTimes.Add(filename, dt);
                }
            }
            return true;
        }


        private void buttonProperties_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listViewImportFiles.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {
                file = item.SubItems[0].Text;
                string path = item.SubItems[4].Text;
                //string fullPath = path + "\\.imga\\metadata\\" + file + ".xml";
                fullPath  = path + "\\" + file;

                (new PropertiesForm(fullPath)).Show();
                //frm.Show();
            }
        }


        
        private async void buttonImport_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listViewImportFiles.SelectedItems;

            List<string> files = new List<string>();
            if (selectedList.Count == 0)
            {
                return;
            }
            foreach (ListViewItem item in selectedList)
            {
                file = item.SubItems[0].Text;
                string path = item.SubItems[4].Text;
                //string fullPath = path + "\\.imga\\metadata\\" + file + ".xml";

                string fullPath = path + "\\" + file;
                files.Add(fullPath);
                //frm.Show();
            }

            
            var progressForm = new CheckoutProgressForm(files, exePath, workingPath);

            var progressFormTask = progressForm.ShowDialogAsync();
           
            var data = await progressForm.ProgressData();

            await progressFormTask;

            //MessageBox.Show(data.ToString());

            
        }

        

        public static void GetAddress(string path, out string address)
        {
            string firstPart;
            string addressPart;
            addressPart = path.Substring(0, path.LastIndexOf('\\'));
            firstPart = addressPart.Substring(0, addressPart.LastIndexOf('\\'));

            address = addressPart.Substring(firstPart.Length + 1, 10);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    internal static class DialogExt
    {
        public static async Task<DialogResult> ShowDialogAsync(this CheckoutProgressForm @this)
        {
            await Task.Yield();
            if (@this.IsDisposed)
                return DialogResult.OK;
            return @this.ShowDialog();
        }
    }
}

