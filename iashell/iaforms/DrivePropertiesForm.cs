using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace iaforms
{
    public partial class DrivePropertiesForm : Form
    {
        private DriveInfo m_driveInfo;
        public DrivePropertiesForm(DriveInfo driveInfo)
        {
            InitializeComponent();
            m_driveInfo = driveInfo;
            Titlelabel.Text = driveInfo.VolumeLabel;
            LabelType.Text = driveInfo.DriveType.ToString();
            labelDriveName.Text = "Drive: " + driveInfo.Name;
            labelFileSystem.Text = driveInfo.DriveFormat;

            labelFreeSpaceSize.Text = driveInfo.AvailableFreeSpace.ToString("N0");
            labelFreeSpaceHumanReadable.Text = GetBytesReadable(driveInfo.AvailableFreeSpace);
            long usedSpace = driveInfo.TotalSize - driveInfo.AvailableFreeSpace;
            labelUserSpaceSize.Text = usedSpace.ToString("N0");
            labelUserSpaceHumanReadable.Text = GetBytesReadable(usedSpace);

            labelCapacitySize.Text = driveInfo.TotalSize.ToString("N0");
            labelCapacityHumanReadable.Text = GetBytesReadable(driveInfo.TotalSize);

            //HardDriveSerial();
            //GetAllDiskDrives();
        }

        private void buttonFindImages_Click(object sender, EventArgs e)
        {
            (new DriveImagesForm(m_driveInfo)).Show();
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

        List<HardDrive> hdCollection = new List<HardDrive>();
        private void GetAllDiskDrives()
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.InterfaceType = wmi_HD["InterfaceType"].ToString();
                hd.Caption = wmi_HD["Caption"].ToString();
                hd.Name = wmi_HD["Name"].ToString();

                hd.SerialNo = wmi_HD.GetPropertyValue("SerialNumber").ToString();//get the serailNumber of diskdrive

                hdCollection.Add(hd);
                Console.WriteLine("Model\t\t: " + hd.Model);
                Console.WriteLine("Type\t\t: " + hd.InterfaceType);
                Console.WriteLine("Serial No.\t: " + hd.SerialNo);
                Console.WriteLine("System Name\t: " + hd.Name);
                Console.WriteLine();
            }

        }


        public class HardDrive
        {
            public string Model { get; set; }
            public string InterfaceType { get; set; }
            public string Caption { get; set; }
            public string SerialNo { get; set; }
            public string Name { get; set; }
    }

        class HardDriveSerialNo
        {
            private string model = null;
            private string type = null;
            private string serialNo = null;

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public string SerialNo
            {
                get { return serialNo; }
                set { serialNo = value; }
            }
        }

        static void HardDriveSerial()
        {
            ArrayList hdCollection = new ArrayList();

            ManagementObjectSearcher searcher = new
                ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDriveSerialNo hd = new HardDriveSerialNo();
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();

                hdCollection.Add(hd);
            }

            searcher = new
                ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            int i = 0;
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                // get the hard drive from collection
                // using index
                HardDriveSerialNo hd = (HardDriveSerialNo)hdCollection[i];

                // get the hardware serial no.
                if (wmi_HD["SerialNumber"] == null)
                    hd.SerialNo = "None";
                else
                    hd.SerialNo = wmi_HD["SerialNumber"].ToString();

                ++i;
            }

            // Display available hard drives
            foreach (HardDriveSerialNo hd in hdCollection)
            {
                Console.WriteLine("Model\t\t: " + hd.Model);
                Console.WriteLine("Type\t\t: " + hd.Type);
                Console.WriteLine("Serial No.\t: " + hd.SerialNo);
                Console.WriteLine();
            }

            // Pause application
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
    
}
