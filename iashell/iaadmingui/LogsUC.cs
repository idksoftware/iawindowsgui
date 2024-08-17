using iaforms;
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

namespace iaadmingui
{
    public partial class LogsUC : UserControl, IViewPage
    {
        List<FileInfo> vaultLogs = new List<FileInfo>();
        List<FileInfo> adminLogs = new List<FileInfo>();
        public LogsUC()
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

        private void LogsUC_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\ProgramData\\IDK-Software\\ImgArchive\\logs");
            //toolStripStatusCurrentPath.Text = "Current: Pictures";
            FileInfo[] logInfo = di.GetFiles();
            int size = logInfo.Length;
            TreeNode[] yearArray = new TreeNode[size];

            
          

            foreach (FileInfo file in logInfo)
            {

                if (file.Length == 0)
                {
                    continue;
                }

                string name = file.Name;
                int pos = name.IndexOf("-");
                string logName = name.Substring(0, pos);

                if (logName == "iaadmin")
                {
                    int count = listViewAdmin.Items.Count;
                    count++;
                    listViewAdmin.Items.Add(MakeItem(count, file));
                    adminLogs.Add(file);
                }

                if (logName == "iavault")
                {
                    int count = listViewVault.Items.Count;
                    count++;
                    listViewVault.Items.Add(MakeItem(count, file));
                    vaultLogs.Add(file);
                }

                
            }

            Trace.WriteLine("Admin logs");
            foreach (FileInfo af in adminLogs)
            {
                Trace.WriteLine(af.Name);

            }

            Trace.WriteLine("Vault logs");
            foreach (FileInfo vf in vaultLogs)
            {
                Trace.WriteLine(vf.Name);
            }
        }

        public ListViewItem MakeItem(int count, FileInfo item)
        {
            ListViewItem lvi = new ListViewItem((count).ToString());
            lvi.ImageIndex = count;

            string name = item.Name;
            int sdate = name.IndexOf("-");
            int edate = name.IndexOf("_");
            string date = name.Substring(sdate+1, (edate - sdate)-1);

            lvi.SubItems.Add(formatDate(date));
            
            lvi.SubItems.Add(name.Substring(edate+1,4));
            lvi.SubItems.Add(item.Length.ToString());
            //lvi.SubItems.Add(item.Description);
            return lvi;
        }

        public string formatDate(string d)
        {
            string fd = d.Substring(0, 4) + "/" + d.Substring(4, 2) + "/" + d.Substring(6, 2);
            d = fd;
            return d;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewAdmin_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listViewAdmin.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {
                int idx = int.Parse(item.SubItems[0].Text);
                idx--;
                FileInfo file = adminLogs[idx];

                (new LogViewForm(file)).Show();
                //frm.Show();
            }
        }

        private void listViewVault_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList = listViewVault.SelectedItems;

            foreach (ListViewItem item in selectedList)
            {
                int idx = int.Parse(item.SubItems[0].Text);
                idx--;
                FileInfo file = vaultLogs[idx];

                (new LogViewForm(file)).Show();
                //frm.Show();
            }
        }
    }
}
