using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace on_picture
{
    class UpdateThumbnails
    {
        // This is a valid file type as it referenced by ImgVault
        static public void MakeThumbnails(string file)
        {

            
            //System.Drawing.Image rawImage = System.Drawing.Image.FromFile(installPath + "\\config\\rawimage.jpg");


            FileInfo image = new FileInfo(file);
            
            int count = 0;

            Size isize = new Size(256, 256);

            DateTime dt = image.CreationTime;
            string timeStr = dt.Hour.ToString() + ":" + dt.Minute.ToString();
           
            
            string ext = image.Extension;
            ext = ext.ToLower();
            if (ext == ".jpg" || ext == ".bmp" || ext == ".gif" || ext == ".png" || ext == ".tiff" || ext == ".tif")
            {
                checkIfUpToDate(image.DirectoryName, image.FullName, image.Name);
                makeThumbnails(image.DirectoryName, image.FullName, image.Name);
                string fileName = Path.GetFileNameWithoutExtension(image.FullName);
                fileName = fileName + ".thumb.jpg";
                string thumbPath = Path.Combine(image.DirectoryName + "\\.imga\\", fileName);
                FileInfo fileInfo = new FileInfo(thumbPath);
                System.Drawing.Image img = null;
                if (!fileInfo.Exists)
                {
                    System.Drawing.Image imgTemp = System.Drawing.Image.FromFile(image.FullName);
                    Size imgSize = imgTemp.Size;
                    imgSize.Height = imgSize.Height / 2;
                    imgSize.Width = imgSize.Width / 2;
                    img = ResizeImage(imgTemp, imgSize);
                    Bitmap bitMap = new Bitmap(img);
                    bitMap.Save(thumbPath, ImageFormat.Jpeg);
                }
            }
            else
            {
                checkIfUpToDate(image.DirectoryName, image.FullName, image.Name);
                makeThumbnails(image.DirectoryName, image.FullName, image.Name);
                string fileName = Path.GetFileNameWithoutExtension(image.FullName);
                fileName = fileName + ".thumb.jpg";
                string thumbPath = Path.Combine(image.DirectoryName + "\\.imga\\", fileName);
                FileInfo fileInfo = new FileInfo(thumbPath);
            } 
           
        }

        static bool checkIfUpToDate(string dir, string fullPath, string fileNamr)
        {
            return true;
        }

        public static System.Drawing.Image PadImage(System.Drawing.Image originalImage)
        {
            int largestDimension = Math.Max(originalImage.Height, originalImage.Width);
            Size squareSize = new Size(largestDimension, largestDimension);
            Bitmap squareImage = new Bitmap(squareSize.Width, squareSize.Height);
            using (Graphics graphics = Graphics.FromImage(squareImage))
            {
                graphics.FillRectangle(Brushes.LightGray, 0, 0, squareSize.Width, squareSize.Height);
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                graphics.DrawImage(originalImage, (squareSize.Width / 2) - (originalImage.Width / 2),
                    (squareSize.Height / 2) - (originalImage.Height / 2), originalImage.Width, originalImage.Height);
            }

            return squareImage;
        }

        

        static public void makeThumbnails(string workingPath, string inputImagePath, string imageName)
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


            Bitmap bitmap = WindowsThumbnailProvider.GetThumbnail(inputImagePath, 250, 250, ThumbnailOptions.ThumbnailOnly);
            fileName = Path.GetFileNameWithoutExtension(inputImagePath);
            fileName = fileName + ".thumb.jpg";
            thumbPath = Path.Combine(workingPath, fileName);
            fileInfo = new FileInfo(thumbPath);
            thumbPath = Path.Combine(workingPath + "\\.imga", fileName);
            fileInfoImga = new FileInfo(thumbPath);
            if (!fileInfoImga.Exists)
            {
                bitmap.Save(thumbPath, ImageFormat.Jpeg);
            }
            bitmap.Dispose();
            /*
            string dcrawPath = exePath + "\\dcraw.exe";
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
            */


        }

        public static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size size)
        {
            // Get the image current width
            int sourceWidth = imgToResize.Width;
            // Get the image current height
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            // Calculate width and height with new desired size
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);
            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

       

    }
}
