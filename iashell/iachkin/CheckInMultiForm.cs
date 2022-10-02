using System;

using System.Collections.Generic;
using System.Windows.Forms;
using iaforms;
using System.IO;
using System.Threading.Tasks;


namespace iachkin
{
    public partial class CheckInMultiForm : Form
    {
       
        String exePath;
        String workingPath;
        String fullPath;
        String chkinFilePath;
        IDictionary<string, DateTime> chkinTimes = new Dictionary<string, DateTime>();
        string file;
        public CheckInMultiForm(string file, string ep, string wp)
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
                    String timeStr = ln.Substring(pos + 1, ln.Length - (pos+1));
                    int t = Int32.Parse(timeStr);
                    System.DateTime dt = new System.DateTime(1970, 1, 1).AddSeconds(t);
                    chkinTimes.Add(filename, dt);
                }
            }
            return true;
        }

        private async void buttonCheckIn_Click(object sender, EventArgs e)
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

            
            var progressForm = new CheckinProgressForm(files, exePath, workingPath);

            var progressFormTask = progressForm.ShowDialogAsync();
   
            await progressFormTask;

            //MessageBox.Show(data.ToString());

            
        }

        private void ButtonDone(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {

        }
    }
    internal static class DialogExt
    {
        public static async Task<DialogResult> ShowDialogAsync(this CheckinProgressForm @this)
        {
            await Task.Yield();
            if (@this.IsDisposed)
                return DialogResult.OK;
            return @this.ShowDialog();
        }
    }
}
