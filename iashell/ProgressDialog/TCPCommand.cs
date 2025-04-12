using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgressDialog
{
    class TCPCommand
    {

        Thread _clientThread;

        private const int port = 560;

        //begin Singleton pattern
        TcpClient tcpClient = null;
        static TCPCommand() {}
        TCPCommand()
        {
            _clientThread = null;
        }

        public static TCPCommand Instance { get; } = new TCPCommand();

        public delegate void EventHandler(string param);
        public EventHandler StatusChanged;
        public EventHandler DataReceived;
        public void Open()
        {
            // Init udp
            if (tcpClient == null)
            {
                StartReading();
            }

        }
        private void StartReading()
        {
            /*
            if (!_keepReading)
            {
                _keepReading = true;
                _readThread = new Thread(ReadUDP);
                _readThread.Start();
            }
            */
        }
    }
}
