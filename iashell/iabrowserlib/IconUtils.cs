using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace iabrowserlib
{
    class IconUtils
    {
        public enum CheckedType
        {
            checkedIn,
            checkedOut,
            EditedChkOut,
            EditedChkIn
        }

        public static System.Drawing.Image PadImage(System.Drawing.Image originalImage, string rating)
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

                bool horizontal = false;
                DrawCheckin(graphics, CheckedType.checkedIn);
                if (originalImage.Height > originalImage.Width)
                {
                    horizontal = true;
                }
                DrawString(graphics, horizontal, rating);
                graphics.Dispose();
            }

            return squareImage;
        }

        public static void DrawCheckin(Graphics graphics, CheckedType ct)
        {
            System.Drawing.Color colour = System.Drawing.Color.Red;
            switch (ct)
            {
                case CheckedType.checkedIn:
                    colour = System.Drawing.Color.White;
                    break;
                case CheckedType.checkedOut:
                    colour = System.Drawing.Color.DarkGreen;
                    break;
                case CheckedType.EditedChkOut:
                    colour = System.Drawing.Color.Blue;
                    break;
                case CheckedType.EditedChkIn:
                    colour = System.Drawing.Color.Red;
                    break;

            }
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(colour);

            graphics.FillEllipse(myBrush, new Rectangle(0, 0, 20, 20));
            myBrush.Dispose();
            //graphics.Dispose();
        }

        public static void DrawString(Graphics graphics, bool hozontal, string rating)
        {
            int stars = int.Parse(rating);

            string starsStr = "";
            for (int i = 0; i < stars; i++)
            {
                starsStr += "*";
            }
            //System.Drawing.Graphics formGraphics = graphics;

            if (hozontal)
            {


                string drawString = starsStr;
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                float x = 0.0F;
                float y = 25.0F;
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                drawFont.Dispose();
                drawBrush.Dispose();
                //graphics.Dispose();
            }
            else
            {
                string drawString = starsStr;
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                float x = 0.0F;
                float y = 25.0F;
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
                drawFont.Dispose();
                drawBrush.Dispose();
                //graphics.Dispose();
            }
            
        }


        /*
        static public async void makeThumbnails(string workingPath, string inputImagePath, string imageName)
        {
            await new Task(() => makeThumbnailsThreadFunc(workingPath, inputImagePath, imageName));
        }
        */
        static public void makeThumbnails(string workingPath, string inputImagePath, string imageName)
        {
            makeThumbnailsThreadFunc(workingPath, inputImagePath, imageName);
        }

        static public void makeThumbnailsThreadFunc(string workingPath, string inputImagePath, string imageName)
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


            Bitmap bitmap = WindowsThumbnailProvider.GetThumbnail(inputImagePath, 380, 380, ThumbnailOptions.ThumbnailOnly);
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
