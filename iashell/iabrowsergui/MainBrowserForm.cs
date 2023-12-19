using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace iabrowsergui
{
    public partial class MainBrowserForm : Form
    {
        public MainBrowserForm()
        {
            InitializeComponent();
        }

        private void MainBrowserForm_Load(object sender, EventArgs e)
        {

            DirectoryInfo di = new DirectoryInfo("C:\\Users\\iferg\\ImgArchive\\Pictures");
            DirectoryInfo[] rootInfo = di.GetDirectories();
            int size = rootInfo.Length;
            TreeNode[] yearArray = new TreeNode[size];
            int count = 0;
            foreach (DirectoryInfo years in rootInfo)
            {

                Trace.WriteLine(years.Name);
                DirectoryInfo year = new DirectoryInfo(years.FullName);
                DirectoryInfo[] days = year.GetDirectories();
                size = days.Length;
                TreeNode[] dayArray = new TreeNode[size];
                int dayCount = 0;
                foreach (DirectoryInfo day in days)
                {
                    dayArray[dayCount] = new TreeNode(day.Name);
                    dayArray[dayCount].Tag = day;
                    DirectoryInfo test = (DirectoryInfo)dayArray[dayCount].Tag;
                    Trace.WriteLine(test.Name);
                    dayCount++;
                }
                yearArray[count] = new TreeNode(years.Name, 0, 0, dayArray);
                count++;
            }

            treeViewPictures.ImageList = this.imageList;

            TreeNode mainNode = new TreeNode("Pictures", 0, 0, yearArray);
            treeViewPictures.Nodes.Add(mainNode);


            statusStrip1.Text = "OK";
        }

        private void treeViewPictures_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Trace.WriteLine(treeViewPictures.SelectedNode.Name);
            Trace.WriteLine(treeViewPictures.SelectedNode.Text);
            DirectoryInfo folder = (DirectoryInfo)treeViewPictures.SelectedNode.Tag;
            if (folder != null)
            {
                Trace.WriteLine(folder.FullName);
                
            }
            Trace.WriteLine(treeViewPictures.SelectedNode.Parent.Text.ToString());
        }
    }
}