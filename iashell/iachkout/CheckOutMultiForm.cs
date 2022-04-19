using System;
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
        //public static ProgressDialog.ProgressDialog progressDialog = null;
       //bool progressDialogOpen = false;
        String exePath;
        String workingPath;
        String fullPath;
        string file;
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
                    if (fileItem.Exists == false)
                    {
                        continue;
                    }
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
           
            //var data = await progressForm.ProgressData();

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

