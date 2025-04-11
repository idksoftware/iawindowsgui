using System;

using System.Collections.Generic;
using System.Windows.Forms;
using iaforms;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using ProgressDialog;

namespace iaimport
{
    public partial class ImportForm : Form
    {

        String exePath;
        String workingPath;
        String fullPath;
        String chkinFilePath;
        string sourceFolder;
        List<DirectoryInfo> dirList = new List<DirectoryInfo>();
        IDictionary<string, DateTime> chkinTimes = new Dictionary<string, DateTime>();
        string file;
        public ImportForm(string file, string ep, string wp)
        {
            exePath = ep;
            workingPath = wp;
            sourceFolder = file;
            ReadImportListFile(file, dirList);
            
            InitializeComponent();
            AddImportItems(dirList);
        }

        public void AddImportItems(List<DirectoryInfo> dirList)
        {

            foreach (DirectoryInfo item in dirList)
            {
                ListViewItem lvi = new ListViewItem(item.FullName);
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
                //lvi.SubItems.Add(item.Extension);
                //lvi.SubItems.Add(item.Length.ToString());
                //lvi.SubItems.Add(item.DirectoryName);
                listViewImportFiles.Items.Add(lvi);
            }
        }
        public bool ReadImportListFile(string path, List<DirectoryInfo> dirIist)
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
                    var dirItem = new DirectoryInfo(ln);

                    dirIist.Add(dirItem);

                }
            }
            return true;
        }

        public bool ReadImportFile(string path)
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
                sourceFolder = item.SubItems[0].Text;
                //string path = item.SubItems[4].Text;
                //string fullPath = path + "\\.imga\\metadata\\" + file + ".xml";

                //string fullPath = path + "\\" + file;
                //files.Add(fullPath);
                //frm.Show();
            }


            var progressForm = new ImportProgressForm(sourceFolder, exePath, workingPath);

            var progressFormTask = progressForm.ShowDialogAsync();

            await progressFormTask;

            


        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {

        }

        private void ImportForm_Click(object sender, EventArgs e)
        {
            

        }

        // "D:\\pics\\pics\\2016\\2016-12-24\\images"
        private void buttonUDPImport_Click(object sender, EventArgs e)
        {
            var progressForm = new ImportProressDialog(exePath, workingPath, "D:\\pics\\pics\\2016");
            progressForm.Show();
            
        }
    }
    internal static class DialogExt
    {
        public static async Task<DialogResult> ShowDialogAsync(this ImportProgressForm @this)
        {
            await Task.Yield();
            if (@this.IsDisposed)
                return DialogResult.OK;
            return @this.ShowDialog();
        }
    }
}