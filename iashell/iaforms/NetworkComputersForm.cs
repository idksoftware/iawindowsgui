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
using System.DirectoryServices;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;


namespace iaforms
{
    public partial class NetworkComputersForm : Form
    {
        private DriveInfo[] allDrives = null;
        public NetworkComputersForm()
        {
            InitializeComponent();
            getComputerName();
            List<string> nc =  NetworkHosts;
            List<string> nc1 = GetNetworkComputerNames();
        }

        public List<string> getComputerName()
        {

            DirectoryEntry root = new DirectoryEntry("WinNT:");

            foreach (DirectoryEntry computers in root.Children)
            {
                foreach (DirectoryEntry computer in computers.Children)
                {
                    if (computer.Name != "Schema")
                    {
                        //textBox1.Text += computer.Name + "\r\n";
                    }
                }
            }
            return new List<string>();
        }
        /*
        public List<string> NetworkComputers()
        {
            return (
                from Computers
                    in (new DirectoryEntry("WinNT:")).Children
                from Computer
                    in Computers.Children
                where Computer.SchemaClassName == "Computer"
                orderby Computer.Name
                select Computer.Name).ToList;
        }
        */

        private List<string> NetworkHosts
        {
            get
            {
                var result = new List<string>();

                var root = new DirectoryEntry("//");
                foreach (DirectoryEntry computers in root.Children)
                {
                    result.AddRange(from DirectoryEntry computer in computers.Children where computer.Name != "Schema" select computer.Name);
                }
                return result;
            }
        }
        

        public void AddDriveItems()
        {
            allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {

                Debug.Print("Drive {0}", d.Name);
                Debug.Print("  File type: {0}", d.DriveType);
                ListViewItem lvi = new ListViewItem(d.Name);

                lvi.ImageIndex = 0;
                lvi.SubItems.Add(d.DriveType.ToString());
                if (d.IsReady == true)
                {
                    lvi.SubItems.Add(GetBytesReadable(d.TotalSize));
                    lvi.SubItems.Add(GetBytesReadable(d.AvailableFreeSpace));
                }
                else
                {
                    lvi.SubItems.Add("Not Ready");
                }
                //lvi.SubItems.Add(item.Length.ToString());
                //lvi.SubItems.Add(item.DirectoryName);

                listViewImportFiles.Items.Add(lvi);
            }
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

        [DllImport("Netapi32", CharSet = CharSet.Auto,
        SetLastError = true),
        SuppressUnmanagedCodeSecurityAttribute]

        // The NetServerEnum API function lists all servers of the 
        // specified type that are visible in a domain.
        public static extern int NetServerEnum(
            string ServerNane, // must be null
            int dwLevel,
            ref IntPtr pBuf,
            int dwPrefMaxLen,
            out int dwEntriesRead,
            out int dwTotalEntries,
            int dwServerType,
            string domain, // null for login domain
            out int dwResumeHandle
            );

        //declare the Netapi32 : NetApiBufferFree method import
        [DllImport("Netapi32", SetLastError = true),
        SuppressUnmanagedCodeSecurityAttribute]

        // Netapi32.dll : The NetApiBufferFree function frees 
        // the memory that the NetApiBufferAllocate function allocates.         
        public static extern int NetApiBufferFree(
            IntPtr pBuf);

        //create a _SERVER_INFO_100 STRUCTURE
        [StructLayout(LayoutKind.Sequential)]
        public struct _SERVER_INFO_100
        {
            internal int sv100_platform_id;
            [MarshalAs(UnmanagedType.LPWStr)]
            internal string sv100_name;
        }

        /*
        static void Main(string[] args)
        {
            List<string> networkComputers = GetNetworkComputerNames();
            if (networkComputers.Count > 0)
            {
                foreach (string computerName in networkComputers)
                {
                    Console.WriteLine(computerName);
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("No computers found");
                Console.WriteLine("##########");
                Console.WriteLine("Ensure the 'Computer Browser' Windows Service is available and running.");
                Console.WriteLine("##########");
                Console.WriteLine("In Win10 v1709 and later versions, the SMBv1 server components (which include the Computer Browser service) are not installed by default, and the SMBv1 'Client' components will be automatically removed after 15 days if the OS detects they are not being used.");
                Console.WriteLine("##########");
                Console.WriteLine("To enable the Computer Browser service, open the Control Panel -> Programs ->  Turn Windows Features On or Off -> scroll down and select SMB 1.0/CIFS File Sharing Support and click OK. Finally, restart the machine and check the service.");
                Console.WriteLine("##########");
                Console.WriteLine("https://docs.microsoft.com/en-US/windows-server/storage/file-server/troubleshoot/smbv1-not-installed-by-default-in-windows");
                Console.WriteLine("##########");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.ReadLine();
        }
        */

        private static List<string> GetNetworkComputerNames()
        {
            List<string> networkComputerNames = new List<string>();
            const int MAX_PREFERRED_LENGTH = -1;
            int SV_TYPE_WORKSTATION = 1;
            int SV_TYPE_SERVER = 2;
            IntPtr buffer = IntPtr.Zero;
            IntPtr tmpBuffer = IntPtr.Zero;
            int entriesRead = 0;
            int totalEntries = 0;
            int resHandle = 0;
            int sizeofINFO = Marshal.SizeOf(typeof(_SERVER_INFO_100));

            try
            {
                int ret = NetServerEnum(null, 100, ref buffer,
                    MAX_PREFERRED_LENGTH,
                    out entriesRead,
                    out totalEntries, SV_TYPE_WORKSTATION |
                    SV_TYPE_SERVER, null, out
                    resHandle);
                //if the returned with a NERR_Success 
                //(C++ term), =0 for C#
                if (ret == 0)
                {
                    //loop through all SV_TYPE_WORKSTATION and SV_TYPE_SERVER PC's
                    for (int i = 0; i < totalEntries; i++)
                    {
                        tmpBuffer = new IntPtr((int)buffer +
                                   (i * sizeofINFO));

                        //Have now got a pointer to the list of SV_TYPE_WORKSTATION and SV_TYPE_SERVER PC's
                        _SERVER_INFO_100 svrInfo = (_SERVER_INFO_100)
                            Marshal.PtrToStructure(tmpBuffer,
                                    typeof(_SERVER_INFO_100));

                        //add the Computer name to the List
                        networkComputerNames.Add(svrInfo.sv100_name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //The NetApiBufferFree function frees the allocated memory
                NetApiBufferFree(buffer);
            }
            return networkComputerNames;
        }
    }
}

