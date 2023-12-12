using iaforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iaforms.AllowedObject;
using static System.Net.Mime.MediaTypeNames;

namespace iaadmingui
{
    
    public partial class AllowedUC : IAUserControl, IViewPage
    {
        XMLAllowed m_xmlAllowed = null;
        AllowedObject m_allowObject = null;
        bool isAppled = false;
        int itemNumber = 0;
        public AllowedUC()
        {
            InitializeComponent();
        }

        public void Reset()
        {

        }
        public void Apply()
        {

        }
        public bool isChanged()
        {
            return false;
        }

        private void AllowedUC_Load(object sender, EventArgs e)
        {
            GetProperties();
        }
        public void AddAllowedItem(AllowedItem item)
        {
            ListViewItem lvi = new ListViewItem((itemNumber + 1).ToString());
            lvi.ImageIndex = itemNumber;
            lvi.SubItems.Add(item.Extention);
            string type = (item.ImageType == AllowItemType.Raw) ? "Raw" : "Picture";
            lvi.SubItems.Add(type);
            lvi.SubItems.Add(item.Mime);
            lvi.SubItems.Add(item.Description);
            listAllowedView.Items.Add(lvi);
            itemNumber++;

            
        }
        private async void GetProperties()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = "show --silent --allowed=all --format-type=xml";
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }

            
            Trace.WriteLine(output);
            m_xmlAllowed = new XMLAllowed(output);
            Trace.WriteLine(output);
            m_xmlAllowed.Process();
            m_allowObject = m_xmlAllowed.Allowed;
            
            foreach (AllowedItem item in m_allowObject)
            {
                AddAllowedItem(item);
            }
           
            //Trace.WriteLine(output);
            Reset();
        }

        bool compare(AllowedItem a, ListViewItem b)
        {
            //b.item.SubItems[1].Text;
            if (a.Extention != b.SubItems[1].Text)
            {
                return false;
            }
            AllowItemType type = AllowedItem.GetAllowItemType(b.SubItems[2].Text);
            if (a.ImageType != type)
            {
                return false;
            }
            if (a.Mime != b.SubItems[3].Text)
            {
                return false;
            }
            if (a.Description != b.SubItems[4].Text)
            {
                return false;
            }
            return true;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new AllowItemsAddForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                AddAllowedItem(form.AllowedItem);
                //this.allowedItems.Add(form.AllowItem);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listAllowedView.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {

                AllowedItem allowedItem = new AllowedItem();
                allowedItem.Extention = item.SubItems[1].Text;
                allowedItem.ImageType = AllowedItem.GetAllowItemType(item.SubItems[2].Text);
                allowedItem.Mime = item.SubItems[3].Text;
                allowedItem.Description = item.SubItems[4].Text;


                AllowItemsEditForm form = new AllowItemsEditForm(allowedItem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    item.SubItems[1].Text = form.Ext;
                    if (form.Type == AllowItemType.Picture)
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
                    //AllowedItem obj = m_allowObject.ElementAt(idx);
                    //obj.Extention = form.Ext;
                    //obj.ImageType = form.Type;
                    //obj.Mime = form.Mime;
                    //obj.Description = form.Description;
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

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // find deleted
            foreach (AllowedItem item in m_allowObject)
            {
                ListViewItem lvi = findAllowedItem(item.Extention);
                if (lvi == null)
                {
                    DeleteItem(item.Extention);
                    // delete item
                }
                else
                {
                    if (compare(item, lvi) == false)
                    {

                        EditItem(lvi);
                        // edit item
                    }
                }
            }

            foreach (ListViewItem lvi in listAllowedView.Items)
            {
                AllowedItem item = m_allowObject.findExtention(lvi.SubItems[1].Text);
                if (item == null)
                {
                    AddItem(lvi);
                }

            }
        }

        ListViewItem findAllowedItem(string ext)
        {
            foreach (ListViewItem item in listAllowedView.Items)
            {
                if(item.SubItems[1].Text == ext)
                {
                    return item;
                }
            }
            return null;
        }

        private void CancalButton_Click(object sender, EventArgs e)
        {
            listAllowedView.Items.Clear();
            itemNumber = 0;
            GetProperties();
          
        }

        private async void AddItem(ListViewItem lvi)
        {
            string arguments = "allow --add=\"" + lvi.SubItems[1].Text + ',' + lvi.SubItems[2].Text + ',' + lvi.SubItems[3].Text + ',' + lvi.SubItems[4].Text + "\""
                                                            + " --format-type=xml";

            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = arguments;
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                //System.Windows.Forms.Application.Exit();
            }


            Trace.WriteLine(output);
        }

        private async void EditItem(ListViewItem lvi)
        {
            string arguments = "allow --edit=" + lvi.SubItems[1].Text + ',' + lvi.SubItems[2].Text + ',' + lvi.SubItems[3].Text + ',' + lvi.SubItems[4].Text
                                                            + " --format-type=xml";

            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = arguments;
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                //System.Windows.Forms.Application.Exit();
            }


            Trace.WriteLine(output);
        }

        private async void DeleteItem(string ext)
        {
            string arguments = "allow --delete=" + ext + " --format-type=xml";



            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = arguments;
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;
                string box_title = "ImgArchive Error";
                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                //System.Windows.Forms.Application.Exit();
            }


            Trace.WriteLine(output);
        }
    }
}
