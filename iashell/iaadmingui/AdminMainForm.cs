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
        public AdminMainForm()
        {
            InitializeComponent();
        }

        AllowItems allowItems;
        ListViewItem selectedAllowedTtem;
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
                    string path = "C:\\ia\\New folder\\iawindowsgui\\iashell\\iaforms\\allowed.xml";
                    LoadAlloweItems(path);
                    AddAlloweItems();
                    break;
            }
        }
        void LoadAlloweItems(string path)
        {
            if (File.Exists(path))
            {
                string fileContents = File.ReadAllText(path);
                AllowedXMLReader allowedXMLReader = new AllowedXMLReader(fileContents);
                allowedXMLReader.Process();
                allowItems = allowedXMLReader.AllowItems;
            }
            

        }

        public void AddAlloweItems()
        {
            int itemNumber = 1;
            int count = allowItems.Count;
           
            foreach (AllowItem item in allowItems)
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
            AllowItemsEditForm form = new AllowItemsEditForm(); 
            form.ShowDialog();
        }
        // Debug.WriteLine("Send to debug output.");
    }
}
