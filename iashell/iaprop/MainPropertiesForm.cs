using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using iaforms;

namespace iaprop
{
    public partial class MainPropertiesForm : Form
    {
        string exePath;
        string workPath;
        public MainPropertiesForm(string file, string e, string w)
        {
            exePath = e;
            workPath = w;
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

            if (File.Exists(path))
            {
                // Read all the content in one string 
                // and display the string 
                string[] lines = File.ReadAllLines(path);
                foreach (string ln in lines)
                {
                    var fileItem = new FileInfo(ln);
                    fileIist.Add(fileItem);

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
        private void buttonLog_Click(object sender, EventArgs e)
        {
            //XMLLogReader xmlLogReader = new XMLLogReader("C:\\temp\\imga\\test.xml");

            //xmlLogReader.Process();

            ListView.SelectedListViewItemCollection selectedList = listViewImportFiles.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {
                string address;
                string file = item.SubItems[0].Text;
                string path = item.SubItems[4].Text;
                //string fullPath = path + "\\.imga\\metadata\\" + file + ".xml";
                GetAddress(path, out address);
                (new LogForm(address, file, exePath, workPath)).Show();
                //frm.S

            }
        }
    }
}
