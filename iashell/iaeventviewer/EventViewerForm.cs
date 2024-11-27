using iaforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using static iaforms.ArchiveObject;
using ProgressDialog;

namespace iaeventviewer
{
   
    public partial class EventViewerForm : Form
    {
        //XMLGeneral m_xmlGeneral = null;
        //GeneralObject m_GeneralObject = null;
        NetworkObject m_networkObject = null;
        XMLNetwork m_xmlNetwork = null;
        string exePath;
        string workingPath;
        public EventViewerForm()
        {
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            workingPath = regSetting.TempPath;
            exePath = regSetting.IaexePath;

            //projFiles += "\\IDK-Software\\imgarchive";
            string test = exePath + "\\iaadmin.exe";
            if (File.Exists(test) == false)
            {
                MessageBox.Show(
                    "Fatal - Cannot find ImgArchive tools: " + test,
                    "ImgArchive", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }


            

            InitializeComponent();
        }

        private async void GetGeneralProperties()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = exePath;
            launchCommand.Path = workingPath;
            launchCommand.Arguments = "show --setting=network --format-type=xml --silent";
            //launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                //System.Windows.Forms.Application.Exit();
            }


            m_xmlNetwork = new XMLNetwork(output);
            m_xmlNetwork.Process();
            m_networkObject = m_xmlNetwork.Network;

            //ResetGeneral();
        }

        void udpclent()
        {
            UdpClient udpClient = new UdpClient(11000);
            try
            {
                udpClient.Connect("localhost", 561);

                // Sends a message to the host to which you have connected.
                Byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there?");

                udpClient.Send(sendBytes, sendBytes.Length);

                // Sends a message to a different host using optional hostname and port parameters.
                UdpClient udpClientB = new UdpClient();
                //udpClientB.Send(sendBytes, sendBytes.Length, "AlternateHostMachineName", 11000);

                //IPEndPoint object will allow us to read datagrams sent from any source.
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                // Blocks until a message returns on this socket from a remote host.
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                // Uses the IPEndPoint object to determine which of these two hosts responded.
                Console.WriteLine("This is the message you received " +
                                  returnData.ToString());
                Console.WriteLine("This message was sent from " +
                                  RemoteIpEndPoint.Address.ToString() +
                                  " on their port number " +
                                  RemoteIpEndPoint.Port.ToString());

                udpClient.Close();
                udpClientB.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        private void EventViewerForm_Load(object sender, EventArgs e)
        {
            GetGeneralProperties();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            (new ProgressDialogForm(exePath, workingPath, "")).Show();
        }
    }
}
