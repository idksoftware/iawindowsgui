using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaforms
{
    public partial class ImportQueueForm : Form
    {
      
        string exePath;
        string workPath;
        private string userPath;
        String chkinFilePath;
        IDictionary<string, DateTime> chkinTimes = new Dictionary<string, DateTime>();
        public ImportQueueForm(string file, string e, string w, string u)
        {
            exePath = e;
            workPath = w;
            userPath = u;
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
                    if (File.Exists(ln))
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
                string file = item.SubItems[0].Text;
                string path = item.SubItems[4].Text;
                //string fullPath = path + "\\.imga\\metadata\\" + file + ".xml";
                string fullPath = path + "\\" + file;
                (new PropertiesForm(fullPath)).Show();
                //frm.Show();
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void GetAddress(string path, out string address)
        {
            string firstPart;
            string addressPart;
            addressPart = path.Substring(0, path.LastIndexOf('\\'));
            firstPart = addressPart.Substring(0, addressPart.LastIndexOf('\\'));

            address = path.Substring(addressPart.Length + 1, 10);
        }
        
    }
}

