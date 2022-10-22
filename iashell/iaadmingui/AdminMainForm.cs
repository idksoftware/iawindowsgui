using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using iaforms;

namespace iaadmingui
{
    public partial class AdminMainForm : Form
    {
        string exePath;
        string workingPath;
        public AdminMainForm(string workingFolder, string exeFolder)
        {
            exePath = exeFolder;
            workingPath = workingFolder;
            InitializeComponent();

        }
        int itemNumber = 1;
        AllowItems allowItems = null;
        
        private void tabMainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           Debug.WriteLine("Send to debug output.");
            int idx = tabMainControl.SelectedIndex;
            switch (idx)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                 
                    LoadAlloweItems();
                    AddAlloweItems();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    LoadExifToolItems();
                    
                    break;
            }
        }
        async void LoadAlloweItems()
        {
            LaunchAdmin launchCommand = LaunchAdmin.Instance;
            launchCommand.ExePath = exePath;
            launchCommand.Path = workingPath;
            launchCommand.Arguments = "show --allowed=all --out=xml";
            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            
            if (output.Length != 0)
            {   
                AllowedXMLReader allowedXMLReader = new AllowedXMLReader(output);
                allowedXMLReader.Process();
                allowItems = allowedXMLReader.AllowItems;        
            }
            

        }

        public void AddAllowedItem(AllowItem item)
        {
            ListViewItem lvi = new ListViewItem(itemNumber.ToString());

            lvi.SubItems.Add(item.ext);
            string verStr = (item.type == AllowItem.AllowItemType.Raw) ? "Raw" : "Picture";
            lvi.SubItems.Add(verStr);
            lvi.SubItems.Add(item.mime);
            lvi.SubItems.Add(item.description);
            listAllowedView.Items.Add(lvi);

            itemNumber++;
        }

        public void AddAlloweItems()
        {
            if (allowItems == null)
            {
                return;
            }
            int count = allowItems.Count;
           
            foreach (AllowItem item in allowItems)
            {
                AddAllowedItem(item);
            }
        }

        private void listAllowedView_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listAllowedView.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {
                string ext = item.SubItems[0].Text;
                Debug.WriteLine("Send to debug output.%s", ext);
                //frm.Show();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new AllowItemsAddForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                AddAllowedItem(form.AllowItem);
                this.allowItems.Add(form.AllowItem);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listAllowedView.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {

                AllowItem allowItem = new AllowItem();
                allowItem.ext = item.SubItems[1].Text;
                allowItem.type = AllowedXMLReader.GetAllowItemType(item.SubItems[2].Text);
                allowItem.mime = item.SubItems[3].Text;
                allowItem.description = item.SubItems[4].Text;


                AllowItemsEditForm form = new AllowItemsEditForm(allowItem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    item.SubItems[1].Text = form.Ext;
                    if (form.Type == AllowItem.AllowItemType.Picture)
                    {
                        item.SubItems[2].Text = "Picture";
                    }
                    else
                    {
                        item.SubItems[2].Text = "RAW";
                    }

                    item.SubItems[3].Text = form.Mime;
                    item.SubItems[4].Text = form.Description;
                    int idx = Int16.Parse(item.SubItems[0].Text);
                    idx--;
                    AllowItem obj = allowItems.ElementAt(idx);
                    obj.ext = form.Ext;
                    obj.type = form.Type;
                    obj.mime = form.Mime;
                    obj.description = form.Description;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listAllowedView.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {
                item.Remove();
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            int idx = tabMainControl.SelectedIndex;
            switch (idx)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    AllowedXMLWriter.write(allowItems);
                    break;
            }
        }

        // ExifTool

        private async void LoadExifToolItems()
        {
            LaunchAdmin launchCommand = LaunchAdmin.Instance;
            launchCommand.ExePath = exePath;
            launchCommand.Path = workingPath;
            launchCommand.Arguments = "show --setting=exiftool --out=xml";
            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            XMLExifTool xmlExifTool = new XMLExifTool(output);
            xmlExifTool.Process();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            
        }

        


        // Debug.WriteLine("Send to debug output.");
    }
}
