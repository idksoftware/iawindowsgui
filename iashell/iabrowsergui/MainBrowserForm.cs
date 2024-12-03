using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Drawing;
using System.Security.Policy;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Security.Principal;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using iaforms;
using iachkin;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Imaging;

namespace iabrowsergui
{
    public partial class MainBrowserForm : Form
    {

        XMLArchive m_xmlArchive = null;

        bool m_picturesEnabled;
        bool m_workspaceEnabled;
        string m_picturesPath;
        string m_workspacePath;
        String installPath;
        String workPath;
        String exePath;

        string rawimage;

        

        public MainBrowserForm(string w, string e, string i)
        {

            workPath = w;
            exePath = e;
            installPath = i;


            InitializeComponent();


        }

        private void MainBrowserForm_Load(object sender, EventArgs e)
        {

            GetUserPaths();

            /*
             * Tree View
             */
            DirectoryInfo di = new DirectoryInfo(m_picturesPath);
            toolStripStatusCurrentPath.Text = "Current: Pictures";
            DirectoryInfo[] rootInfo = di.GetDirectories();
            int size = rootInfo.Length;
            TreeNode[] yearArray = new TreeNode[size];
            int count = 0;
            foreach (DirectoryInfo years in rootInfo)
            {

                Trace.WriteLine(years.Name);
                DirectoryInfo year = new DirectoryInfo(years.FullName);
                //if (year.Name.Equals(".imga"))
                //{
                //   continue;
                //}
                DirectoryInfo[] days = year.GetDirectories();
                size = days.Length;
                TreeNode[] dayArray = new TreeNode[size];
                int dayCount = 0;
                foreach (DirectoryInfo day in days)
                {

                    int fileCount = Directory.GetFiles(day.FullName).Length;
                    string lable = string.Format("{0} ({1})", day.Name, fileCount);
                    dayArray[dayCount] = new TreeNode(lable);
                    dayArray[dayCount].Tag = day;
                    DirectoryInfo test = (DirectoryInfo)dayArray[dayCount].Tag;
                    Trace.WriteLine(test.Name);
                    dayCount++;
                }

                yearArray[count] = new TreeNode(years.Name, 0, 0, dayArray);
                count++;
            }

            treeViewPictures.ImageList = this.StateImageList;

            TreeNode mainNode = new TreeNode("Pictures", 0, 0, yearArray);
            treeViewPictures.Nodes.Add(mainNode);

            this.toolStripStatusCurrentPath.Text = "Current: \\2019\\2019-10-19";
        }

        private void treeViewPictures_AfterSelect(object sender, TreeViewEventArgs e)
        {

            Trace.WriteLine(treeViewPictures.SelectedNode.Name);
            Trace.WriteLine(treeViewPictures.SelectedNode.Text);
            DirectoryInfo folder = (DirectoryInfo)treeViewPictures.SelectedNode.Tag;

            int fileCount = 0;
            if (folder != null)
            {
                Trace.WriteLine(folder.FullName);
                toolStripStatusCurrentPath.Text = "Current: " + folder.FullName;
                fileCount = Directory.GetFiles(folder.FullName).Length;
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
                imageListPicturesLarge.Images.Clear();
                System.Drawing.Image rawImage = System.Drawing.Image.FromFile(installPath + "\\config\\rawimage.jpg");

                DirectoryInfo di = new DirectoryInfo(folder.FullName);
                FileInfo[] images = di.GetFiles();
                int size = images.Length;
                int count = 0;



                //listViewPictures.OwnerDraw = true;
                count = 0;
                foreach (FileInfo image in images)
                {

                    toolStripStatusCurrentPath.Text = String.Format("Loading image: {0}, Age: {1}", count, fileCount);
                    if (!isImage(image.Extension))
                    {
                        continue;
                    }

                    ListViewItem lvi = new ListViewItem(image.Name);

                    DateTime dt = image.CreationTime;
                    //string timeStr = dt.Hour.ToString() + ":" + dt.Minute.ToString();
                    lvi.SubItems.Add(dt.ToShortDateString());
                    lvi.SubItems.Add(image.Extension);
                    lvi.SubItems.Add(image.Length.ToString());

                    string key = Path.GetFileNameWithoutExtension(image.Name); //"pic" + (count + 1).ToString();
                    string ext = image.Extension;
                    string metadataPath = image.DirectoryName + "\\.imga\\metadata\\" + image.Name;
                    ImageProperties imageProperties = GetMetadata(metadataPath);
                    string rating = imageProperties.rating;
                    lvi.ToolTipText = ToolTipText(imageProperties);

                    ext = ext.ToLower();
                    if (ext == ".jpg" || ext == ".bmp" || ext == ".gif" || ext == ".png" || ext == ".tiff" ||
                        ext == ".tif")
                    {
                        checkIfUpToDate(image.DirectoryName, image.FullName, image.Name);
                        IconUtils.makeThumbnails(image.DirectoryName, image.FullName, image.Name);
                        string fileName = Path.GetFileNameWithoutExtension(image.FullName);
                        fileName = fileName + ".thumb.jpg";
                        string thumbPath = Path.Combine(image.DirectoryName + "\\.imga\\", fileName);
                        FileInfo fileInfo = new FileInfo(thumbPath);
                        System.Drawing.Image img = null;
                        if (fileInfo.Exists)
                        {
                            img = System.Drawing.Image.FromFile(thumbPath);
                        }
                        else
                        {
                            System.Drawing.Image imgTemp = System.Drawing.Image.FromFile(image.FullName);
                            Size imgSize = imgTemp.Size;
                            imgSize.Height = imgSize.Height / 2;
                            imgSize.Width = imgSize.Width / 2;
                            img = IconUtils.ResizeImage(imgTemp, imgSize);
                            Bitmap bitMap = new Bitmap(img);
                            bitMap.Save(thumbPath, ImageFormat.Jpeg);
                        }

                        System.Drawing.Image rimg = IconUtils.PadImage(img, rating);
                        //imageListPicturesLarge.Images.Add(key, rimg);

                        imageListPicturesLarge.Images.Add(rimg);
                    }
                    else
                    {


                        checkIfUpToDate(image.DirectoryName, image.FullName, image.Name);
                        IconUtils.makeThumbnails(image.DirectoryName, image.FullName, image.Name);
                        string fileName = Path.GetFileNameWithoutExtension(image.FullName);
                        fileName = fileName + ".thumb.jpg";
                        string thumbPath = Path.Combine(image.DirectoryName + "\\.imga\\", fileName);
                        FileInfo fileInfo = new FileInfo(thumbPath);

                        if (fileInfo.Exists)
                        {

                            System.Drawing.Image img = System.Drawing.Image.FromFile(fileInfo.FullName);
                            System.Drawing.Image rimg = IconUtils.PadImage(img, rating);
                            //imageListPicturesLarge.Images.Add(key, rimg);
                            imageListPicturesLarge.Images.Add(rimg);


                        }
                        else
                        {

                            //imageListPicturesLarge.Images.Add(key, rawImage);
                            imageListPicturesLarge.Images.Add(rawImage);

                        }


                    }

                    //lvi.ImageKey = key;
                    lvi.ImageIndex = count;
                    listViewPictures.Items.Add(lvi);
                    count++;


                }

                listViewPictures.LargeImageList = imageListPicturesLarge;
            }

            if (folder != null)
            {
                Trace.WriteLine(folder.FullName);
                toolStripStatusCurrentPath.Text = "Current: " + folder.FullName;
            }
            else
            {
                toolStripStatusCurrentPath.Text = "Current: " + treeViewPictures.SelectedNode.Text;
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

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPictures.View = View.Details;
        }

        private ImageProperties GetMetadata(string metadataPath)
        {
            string path = metadataPath + ".xml";
            XMLPropertiesReader xmlPropertiesReader = new XMLPropertiesReader(path);
            xmlPropertiesReader.Process();

            return xmlPropertiesReader.ImageProperties;
        }

        string ToolTipText(ImageProperties ip)
        {
            string text;
            text = ip.filename + "\n" + ip.dateCreate + "\n" + "F" +
                   ip.aperture + " " + ip.exposureTime + "s " + ip.isoSpeedRating + "iso\n";
            return text;
        }

    bool checkIfUpToDate(string dir, string fullPath, string fileNamr)
        {
            return true;
        }
        private async void runDcraw(string inputImagePath, string outputImagePath)
        {
            string dcrawPath = exePath + "\\dcraw.exe";
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
                        string args = null;
                        if (listViewPictures.SelectedItems.Count == 0)
                        {
                            args = folder.FullName;
                        }
                        else
                        {
                            args = folder.FullName + "\\" + focusedItem.Text;
                        }

                        //   string args = folder.FullName + "\\" + focusedItem.Text;
                        //string args = "/root c:\\Users\\iferg\\ImgArchive\\Pictures\\2004\\2004-09-09 /select DSC_0009.jpg";
                        //string args = "C:\\Users\\iferg\\ImgArchive\\Pictures\\2006\\2006-09-03";
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
                (new ImagePreview(fullPath, "xxxx")).Show();
            }

            if (name == "checkInOutToolStripMenuItem")
            {
                //string fullXMLPath = Path.Combine(folder.FullName, focusedItem.Text);
                //(new CheckInMultiForm(fullXMLPath, exePath, workPath)).Show();
            }
        }

        private async void GetUserPaths()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = exePath;
            launchCommand.Path = workPath;
            launchCommand.Arguments = "show --silent --setting=archive --format-type=xml";
            //launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }


            m_xmlArchive = new XMLArchive(output);
            m_xmlArchive.Process();
            ArchiveObject archiveObject = m_xmlArchive.Archive;

            ArchiveObject.UserSpaceObject userSpace = archiveObject.UserSpace;
            Trace.WriteLine(output);

            ArchiveObject.Workspace workspace = userSpace.Workspace;
            ArchiveObject.ImageSpace pictures = userSpace.Pictures;

            m_picturesEnabled = (pictures.AutoView.CompareTo("True") == 0);
            m_workspaceEnabled = (workspace.AutoView.CompareTo("True") == 0);
            m_picturesPath = pictures.Path;
            m_workspacePath = workspace.Path;

            rawimage = m_picturesPath + "\\.imga\\rawimage.jpg";
        }

        void LoadImage(string file)
        {
            /*
            Image img = System.Drawing.Image.FromFile(file);
            ImageView.Image = img;
            if (img.Height < 600)
                Height = img.Height + 25;
            if (img.Width < 1200)
                Width = img.Width;
            if (img.Height > 600 && img.Width > 1200)
            {
                Width = 1200;
                Height = 600;
                ImageView.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
                ImageView.SizeMode = PictureBoxSizeMode.Normal;
            //Rotate.Visible = true;

            Trace.WriteLine("H:" + img.Height.ToString());
            Trace.WriteLine("W:" + img.Width.ToString());
            */
        }


        public Bitmap MakeSquarePhoto(Bitmap bmp, int size)
        {
            if (bmp.Height > bmp.Width)
            {
                size = bmp.Height;
            }
            else
            {
                size = bmp.Width;
            }
            Bitmap res = new Bitmap(size, size);
            try
            {

                Graphics g = Graphics.FromImage(res);
                g.FillRectangle(new SolidBrush(Color.White), 0, 0, size, size);
                int t = 0, l = 0;
                if (bmp.Height > bmp.Width)
                    t = (bmp.Height - bmp.Width) / 2;
                else
                    l = (bmp.Width - bmp.Height) / 2;
                bmp.Save("Test1.bmp");
                g.DrawImage(bmp, new Rectangle(0, 0, size, size), new Rectangle(l, t, bmp.Width - l * 2, bmp.Height - t * 2), GraphicsUnit.Pixel);
                bmp.Save("Test2.bmp");
            }
            catch { }
            return res;
        }


        public static Bitmap ResizeBitmapOnWhiteCanvas(Bitmap bmpOriginal, Size szTarget, bool Stretch)
        {
            Bitmap result = new Bitmap(szTarget.Width, szTarget.Height);
            using (Graphics g = Graphics.FromImage((System.Drawing.Image)result))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, szTarget.Width, szTarget.Height));
                if (Stretch)
                {
                    g.DrawImage(bmpOriginal, 0, 0, szTarget.Width, szTarget.Height); // fills the square (stretch)
                }
                else
                {
                    float OriginalAR = bmpOriginal.Width / bmpOriginal.Height;
                    float TargetAR = szTarget.Width / szTarget.Height;
                    if (OriginalAR >= TargetAR)
                    {
                        // Original is wider than target
                        float X = 0F;
                        float Y = ((float)szTarget.Height / 2F) - ((float)szTarget.Width / (float)bmpOriginal.Width * (float)bmpOriginal.Height) / 2F;
                        float Width = szTarget.Width;
                        float Height = (float)szTarget.Width / (float)bmpOriginal.Width * (float)bmpOriginal.Height;
                        g.DrawImage(bmpOriginal, X, Y, Width, Height);
                    }
                    else
                    {
                        // Original is narrower than target
                        float X = ((float)szTarget.Width / 2F) - ((float)szTarget.Height / (float)bmpOriginal.Height * (float)bmpOriginal.Width) / 2F;
                        float Y = 0F;
                        float Width = (float)szTarget.Height / (float)bmpOriginal.Height * (float)bmpOriginal.Width;
                        float Height = szTarget.Height;
                        g.DrawImage(bmpOriginal, X, Y, Width, Height);
                    }
                }
            }
            return result;
        }

        private volatile bool threadRun;

        private void UpdateTab()
        {
            // Create panel for animation
            Panel loadingPanel = new Panel();
            // Label, where the text will change
            Label loadingLabel = new Label();
            loadingLabel.Text = "Loading";

            loadingPanel.Controls.Add(loadingLabel);
            this.Controls.Add(loadingPanel);

            // thread loading animation
            threadRun = true;

            Task.Factory.StartNew(() =>
            {
                int i = 0;
                string labelText;
                while (threadRun)
                {
                    Thread.Sleep(500);
                    switch (i)
                    {
                        case 0:
                            labelText = "Loading.";
                            i = 1;
                            break;
                        case 1:
                            labelText = "Loading..";
                            i = 2;
                            break;
                        default:
                            labelText = "Loading...";
                            i = 0;
                            break;
                    }
                    loadingLabel.BeginInvoke(new Action(() => loadingLabel.Text = labelText));
                }
            });

            // thread update DataGridView   
            Thread update = new Thread(ThreadUpdateTab);
            update.Start();
        }

        private void ThreadUpdateTab()
        {
            // SQL Query...
            //listViewPictures.Invoke(new Action(() => myDataGridView1.DataSource = myDataSet1.Tables[0]));
            // ...
            //listViewPictures.Invoke(new Action(() => myDataGridView10.DataSource = myDataSet10.Tables[0]));

            threadRun = false;
        }

        private void contextMenuStripPictures_Opening(object sender, CancelEventArgs e)
        {
            Console.WriteLine("contextMenuStripPictures_Opening");

        }

        Boolean isImage(String e)
        {
            String extPath = installPath + "\\config\\ext.dat";
            if (!File.Exists(extPath))
            {
                return false;
            }
            string line;
            using (StreamReader sr = new StreamReader(extPath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    int idx = line.IndexOf(':');
                    String ext = line.Substring(0, idx);
                    ext = "." + ext;
                    if (string.Equals(e, ext, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        string makeImageAddress(string text)
        {
            string dir = text;
            string[] words = text.Split(' ');
            if (words[0].Length == 4)
            {
                return (m_picturesPath + "\\" + words[0]);
            }
            if (words[0].Length == 10)
            {
                string year = words[0].Substring(0, 4);
                return (m_picturesPath + "\\" + year + "\\" + words[0]);
            }
            return dir;
        }



        private void toolStripMenuItemExplorer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("toolStripMenuItemExplorer_Click");
        }

        private void Explorer_Click(object sender, EventArgs e)
        {
            string node = treeViewPictures.SelectedNode.Text;
            string dir = makeImageAddress(node);


            if (dir != null)
            {
                Trace.WriteLine(dir);
                try
                {
                    string args = dir.Replace('/', '\\');
                    /*
                    string args = null;
                    if (listViewPictures.SelectedItems.Count == 0)
                    {
                        args = folder.FullName;
                    }
                    else
                    {
                        args = folder.FullName + "\\" + focusedItem.Text;
                    }
                    */
                    //args = "C:\\Users\\iferg\\ImgArchive\\Pictures\\2014";

                    Process.Start(@"explorer.exe", args);
                }
                catch (Win32Exception win32Exception)
                {
                    //The system cannot find the file specified...
                    Trace.WriteLine(win32Exception.Message);
                }

                //explorer /n /e,/root c:\Users\iferg\ImgArchive\Pictures\2004\2004-09-09 /select,DSC_0009.jpg
            }
        }

        private void listViewPictures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}