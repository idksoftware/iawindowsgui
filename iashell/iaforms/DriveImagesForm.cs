using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaforms
{
    public partial class DriveImagesForm : Form
    {
        public DriveImagesForm(DriveInfo driveInfo)
        {
            InitializeComponent();

            // New Volume (D:) - 1.81 TB
            if (driveInfo.VolumeLabel.Length == 0)
            {
                labelTitle.Text = driveInfo.DriveType + " (" + driveInfo.Name + ") - " + GetBytesReadable(driveInfo.TotalSize);
            }
            else
            {
                labelTitle.Text = driveInfo.VolumeLabel + " (" + driveInfo.Name + ") - " +
                                  GetBytesReadable(driveInfo.TotalSize);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public string GetBytesReadable(long i)
        {
            // Get absolute value
            long absolute_i = (i < 0 ? -i : i);
            // Determine the suffix and readable value
            string suffix;
            double readable;
            if (absolute_i >= 0x1000000000000000) // Exabyte
            {
                suffix = "EB";
                readable = (i >> 50);
            }
            else if (absolute_i >= 0x4000000000000) // Petabyte
            {
                suffix = "PB";
                readable = (i >> 40);
            }
            else if (absolute_i >= 0x10000000000) // Terabyte
            {
                suffix = "TB";
                readable = (i >> 30);
            }
            else if (absolute_i >= 0x40000000) // Gigabyte
            {
                suffix = "GB";
                readable = (i >> 20);
            }
            else if (absolute_i >= 0x100000) // Megabyte
            {
                suffix = "MB";
                readable = (i >> 10);
            }
            else if (absolute_i >= 0x400) // Kilobyte
            {
                suffix = "KB";
                readable = i;
            }
            else
            {
                return i.ToString("0 B"); // Byte
            }
            // Divide by 1024 to get fractional value
            readable = (readable / 1024);
            // Return formatted number with suffix
            return readable.ToString("0.### ") + suffix;
        }
    }
}
