using IWshRuntimeLibrary;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using File = System.IO.File;

namespace iaforms
{
    public partial class ImagePreview : Form
    {
        Point MouseMovement;
        System.Drawing.Image img;
        public ImagePreview(string file, string rawImage)
        {
            InitializeComponent();

            ImageView.MouseMove += new MouseEventHandler(ImagePreview_MouseMove);
            this.MouseWheel += new MouseEventHandler(ImagePreview_MouseMove);

            //string rawImage = "C:\\Users\\iferg\\ImgArchive\\Pictures\\.imga\\rawimage.jpg";



            FileInfo fi = new FileInfo(file);
            toolStripStatusLabel.Text = file;
            if (file.Length == 0)
            {
                return;
            }
           
            string ext = fi.Extension;
            ext = ext.ToLower();
            if (ext == ".jpg" || ext == ".bmp" || ext == ".gif" || ext == ".png" || ext == ".tiff" || ext == ".tif")
            { 
                LoadImage(fi.FullName);
            }
            else
            {
                string fileName = Path.GetFileNameWithoutExtension(fi.FullName);
                fileName = fileName + ".thumb.jpg";
                string thumbPath = Path.Combine(fi.DirectoryName + "\\.imga\\", fileName);
                FileInfo fileInfo = new FileInfo(thumbPath);
                if (fileInfo.Exists)
                {
                    LoadImage(fileInfo.FullName);
                }
                else
                {
                    LoadImage(rawImage);
                }
            }
            
        }

        void LoadImage(string file)
        {
            img = System.Drawing.Image.FromFile(file);
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
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ImageView.Image = img;
            var wfactor = (double)img.Width / ImageView.ClientSize.Width;
            var hfactor = (double)img.Height / ImageView.ClientSize.Height;
            var resizeFactor = Math.Max(wfactor, hfactor);
            var imageSize = (int)(img.Width / resizeFactor);
            if (ImageView.Image.Width < ImageView.Image.Height)
                Width = imageSize;
            else
                Width = img.Height;
        }
        private void ImagePreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
                Trace.WriteLine(e.Delta);
        }

        private void ImagePreview_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
                Trace.WriteLine(e.Delta);
            
        }

        private Point startingPoint = Point.Empty;
        private Point movingPoint = Point.Empty;
        private bool panning = false;

        private void ImageView_MouseDown(object sender, MouseEventArgs e)
        {
            panning = true;
            startingPoint = new Point(e.Location.X - movingPoint.X,
                e.Location.Y - movingPoint.Y);
            Trace.WriteLine("H:" + img.Height.ToString());
            Trace.WriteLine("W:" + img.Width.ToString());
        }

        private void ImageView_MouseUp(object sender, MouseEventArgs e)
        {
            panning = false;
            Trace.WriteLine("H:" + img.Height.ToString());
            Trace.WriteLine("W:" + img.Width.ToString());
        }

        private void ImageView_MouseMove(object sender, MouseEventArgs e)
        {
            if (panning)
            {
                movingPoint = new Point(e.Location.X - startingPoint.X,
                    e.Location.Y - startingPoint.Y);
                ImageView.Invalidate();
            }
        }

        private void ImageView_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.White);
            //e.Graphics.DrawImage(img, movingPoint);
            Trace.WriteLine("H:" + img.Height.ToString());
            Trace.WriteLine("W:" + img.Width.ToString());
        }
        /*
private Point startingPoint = Point.Empty;
private Point movingPoint = Point.Empty;
private bool panning = false;

void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
panning = true;
startingPoint = new Point(e.Location.X - movingPoint.X,
   e.Location.Y - movingPoint.Y);
}

void pictureBox1_MouseUp(object sender, MouseEventArgs e) {
panning = false;
}

void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
if (panning) {
movingPoint = new Point(e.Location.X - startingPoint.X, 
   e.Location.Y - startingPoint.Y);
pictureBox1.Invalidate();
}
}

void pictureBox1_Paint(object sender, PaintEventArgs e) {
e.Graphics.Clear(Color.White);
e.Graphics.DrawImage(Image, movingPoint);
}
*/
    }
    
}
