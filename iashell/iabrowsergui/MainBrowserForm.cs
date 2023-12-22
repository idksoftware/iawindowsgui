using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Drawing;
using System.Security.Policy;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using iaforms;

namespace iabrowsergui
{
    public partial class MainBrowserForm : Form
    {
        String workPath;
        String exePath;
        public MainBrowserForm()
        {
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;

            InitializeComponent();
        }

        private void MainBrowserForm_Load(object sender, EventArgs e)
        {


            /*
             * Tree View
             */
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\iferg\\ImgArchive\\Pictures");
            toolStripStatusCurrentPath.Text = "Current: Pictures";
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

            this.toolStripStatusCurrentPath.Text = "Current: \\2019\\2019-10-19";
        }

        private void treeViewPictures_AfterSelect(object sender, TreeViewEventArgs e)
        {

            Trace.WriteLine(treeViewPictures.SelectedNode.Name);
            Trace.WriteLine(treeViewPictures.SelectedNode.Text);
            DirectoryInfo folder = (DirectoryInfo)treeViewPictures.SelectedNode.Tag;
            if (folder != null)
            {
                Trace.WriteLine(folder.FullName);
                toolStripStatusCurrentPath.Text = "Current: " + folder.FullName;
            }
            else
            {
                toolStripStatusCurrentPath.Text = "Current: " + treeViewPictures.SelectedNode.Text;
            }

            //Trace.WriteLine(treeViewPictures.SelectedNode.Parent.Text.ToString());


            /*
             * List View
             */
            if (folder != null)
            {
                listViewPictures.Items.Clear();
                imageListPictures.Images.Clear();
                System.Drawing.Image rawImage = System.Drawing.Image.FromFile("C:\\Users\\iferg\\ImgArchive\\Pictures\\.imga\\rawimage.jpg");

                DirectoryInfo di = new DirectoryInfo(folder.FullName);
                FileInfo[] images = di.GetFiles();
                int size = images.Length;
                int count = 0;
                foreach (FileInfo image in images)
                {
                    ListViewItem lvi = new ListViewItem(image.Name);

                    DateTime dt = image.CreationTime;
                    string timeStr = dt.Hour.ToString() + ":" + dt.Minute.ToString();
                    lvi.SubItems.Add(timeStr);
                    lvi.SubItems.Add(image.Extension);
                    lvi.SubItems.Add(image.Length.ToString());
                    string key = "pic" + (count + 1).ToString();
                    if (image.Extension == ".JPG")
                    {
                        imageListPictures.Images.Add(key, System.Drawing.Image.FromFile(image.FullName));
                    }
                    else
                    {
                        runDcrawThumbnails(image.DirectoryName, image.FullName, image.Name);
                        string fileName = Path.GetFileNameWithoutExtension(image.FullName);
                        fileName = fileName + ".thumb.jpg";
                        string thumbPath = Path.Combine(image.DirectoryName + "\\.imga\\", fileName);
                        FileInfo fileInfo = new FileInfo(thumbPath);
                        if (fileInfo.Exists)
                        {
                            imageListPictures.Images.Add(key, System.Drawing.Image.FromFile(fileInfo.FullName));
                        }
                        else
                        {
                            imageListPictures.Images.Add(key, rawImage);
                        }

                    }
                    lvi.ImageKey = key;
                    lvi.ImageIndex = count;
                    count++;


                    listViewPictures.LargeImageList = imageListPictures;
                    listViewPictures.Items.Add(lvi);
                }
            }



        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPictures.View = View.LargeIcon;

        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPictures.View = View.SmallIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPictures.View = View.Details;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPictures.View = View.List;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPictures.View = View.Tile;
        }

        private async void runDcrawThumbnails(string workingPath, string inputImagePath, string imageName)
        {
            string fileName = Path.GetFileNameWithoutExtension(inputImagePath);
            fileName = fileName + ".thumb.jpg";
            string thumbPath = Path.Combine(workingPath, fileName);
            FileInfo fileInfo = new FileInfo(thumbPath);
            thumbPath = Path.Combine(workingPath + "\\.imga", fileName);
            FileInfo fileInfoImga = new FileInfo(thumbPath);
            if (fileInfoImga.Exists)
            {
                return;
            }

            string dcrawPath = "C:\\Program Files\\IDK-Software\\imgarchive\\dcraw.exe";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = workingPath;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = dcrawPath;

            string commandArg1 = string.Format("\"{0}\"", inputImagePath);


            startInfo.Arguments += " -e ";
            startInfo.Arguments += commandArg1;
            bool ok = false;
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
                string stdout = exeProcess.StandardOutput.ReadToEnd();
                string stderr = exeProcess.StandardError.ReadToEnd();
                Console.WriteLine("Exit code : {0}", exeProcess.ExitCode);
                if (exeProcess.ExitCode == 0)
                {
                    ok = true;
                }

                if (ok)
                {
                    fileName = Path.GetFileNameWithoutExtension(inputImagePath);
                    fileName = fileName + ".thumb.jpg";
                    thumbPath = Path.Combine(workingPath, fileName);
                    fileInfo = new FileInfo(thumbPath);
                    thumbPath = Path.Combine(workingPath + "\\.imga", fileName);
                    fileInfoImga = new FileInfo(thumbPath);
                    if (!fileInfoImga.Exists)
                    {
                        fileInfo.MoveTo(thumbPath);
                    }
                }
            }



        }
        private async void runDcraw(string inputImagePath, string outputImagePath)
        {
            string dcrawPath = "C:\\Program Files\\IDK-Software\\imgarchive\\dcraw.exe";
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = dcrawPath;
            string commandArg1 = string.Format("\"{0}\"", outputImagePath);
            string commandArg2 = string.Format("\"{0}\"", inputImagePath);
            startInfo.Arguments = "-u ";
            startInfo.Arguments += commandArg1;
            startInfo.Arguments += " -e ";
            startInfo.Arguments += commandArg2;
            startInfo.Arguments += " -T";
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
                string stdout = exeProcess.StandardOutput.ReadToEnd();
                string stderr = exeProcess.StandardError.ReadToEnd();
                Console.WriteLine("Exit code : {0}", exeProcess.ExitCode);
            }
        }

        private void listViewPictures_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listViewPictures.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStripPictures.Show(Cursor.Position);
                }
            }
        }



        private void contextMenuStripPictures_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            string name = item.Name;
            DirectoryInfo folder = (DirectoryInfo)treeViewPictures.SelectedNode.Tag;
            var focusedItem = listViewPictures.FocusedItem;
            string itemText = focusedItem.Text;

            if (name == "toolStripMenuItemExplorer")
            {


                if (folder != null)
                {
                    Trace.WriteLine(folder.FullName);
                    try
                    {
                        //string args = "/n /e,/root " + folder.FullName + " /select," + itemText;
                        string args = "/root c:\\Users\\iferg\\ImgArchive\\Pictures\\2004\\2004-09-09 /select DSC_0009.jpg";
                        Process.Start(@"explorer", args);
                    }
                    catch (Win32Exception win32Exception)
                    {
                        //The system cannot find the file specified...
                        Trace.WriteLine(win32Exception.Message);
                    }

                    //explorer /n /e,/root c:\Users\iferg\ImgArchive\Pictures\2004\2004-09-09 /select,DSC_0009.jpg
                }


            }
            if (name == "ToolStripMenuItemProperties")
            {
                string fullXMLPath = Path.Combine(folder.FullName, focusedItem.Text);
                (new PropertiesForm(fullXMLPath)).Show();
            }
            if (name == "toolStripMenuItemPreview")
            {
                string fullPath = Path.Combine(folder.FullName, focusedItem.Text);
                (new ImagePreview(fullPath)).Show();
            }
        }
    }
}