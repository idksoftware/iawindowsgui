using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; 
using iaforms;

namespace iaforms
{
    public partial class LogForm : Form
    {
        ImageLogs m_imageLogs;

        public delegate void ProgressEventHandler();
        public static ProgressEventHandler ProgressChanged;

        string m_exePath;
        string m_workingPath;
        string m_output;

        String m_path;
        string m_file;

        enum Event
        {
            ERROR = 1,
		    ADDED,
		    CHECKOUT,
		    CHECKIN,
		    UNCHECKOUT,
		    EXPORT
        };

        static string EventString(Event evt)
        {
            switch(evt)
            {
                case Event.ERROR: return "Error";
                case Event.ADDED: return "Added";
                case Event.CHECKOUT: return "Checked-out";
                case Event.CHECKIN: return "Checked-in";
                case Event.UNCHECKOUT: return "Unchecked-out";
                case Event.EXPORT: return "Exportsd";
            }
            return "Error";
        }
        int Event2BMP(Event evt)
        {
            switch (evt)
            {
                case Event.ERROR: return 5;
                case Event.ADDED: return 9;
                case Event.CHECKOUT: return 1;
                case Event.CHECKIN: return 2;
                case Event.UNCHECKOUT: return 3;
                case Event.EXPORT: return 4;
            }
            return 5;
        }

        public LogForm(String p, string f, string e, string w)
        {
            m_exePath = e;
            m_workingPath = w;
            m_path = p;
            m_file = f;
            InitializeComponent();
            //his.labelDate.Text = m_path;
            this.labelImageName.Text = m_file;
            m_imageLogs = new ImageLogs();
            ProgressData();
            LoadItems();
            AddItems();
        }

        void LoadItems()
        {
            //char[] delims = new[] { '\r', '\n' };
            //string[] strings = m_output.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            XMLLogReader xmlLogReader = new XMLLogReader(m_output);
            xmlLogReader.Process();
            m_imageLogs = xmlLogReader.ImageLogs;
            
        }

        public void AddItems()
        {
            int itemNumber = 1;
            int count = m_imageLogs.Count;
            ImageLog imageLog = m_imageLogs[0];
            foreach (ImageEvent item in imageLog.events)
            {
                ListViewItem lvi = new ListViewItem(itemNumber.ToString());

                lvi.ImageIndex = Event2BMP((Event)item.evt);
                lvi.SubItems.Add(item.dateAdded);
                string verStr = (item.version == 0) ? "Initial" : item.version.ToString();
                lvi.SubItems.Add(verStr);
                lvi.SubItems.Add(EventString((Event)item.evt));
                lvi.SubItems.Add(item.comment);
                eventItems.Items.Add(lvi);
                itemNumber++;
            }
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async Task<int> ProgressData()
        {

            
            LaunchCommandLine launchCommandLine = LaunchCommandLine.Instance;
            launchCommandLine.ExePath = m_exePath;
            launchCommandLine.Path = m_workingPath;

            LaunchCommandLine.StatusChanged += OnStatusChanged;
            ProgressChanged += OnProgressChanged;

            
            TimeSpan elapsed;
            //await Task.Delay(2000);
            
            
               
            string address;
            string name;
            //GetAddress(file, out address);
            //GetFile(file, out name);
            //m_currentFile = name;

            // log --scope=2017-07-15/_8005619_00000N_000001.JPG --format-type=xml

            string fileAddress = m_path + '/' + m_file;
            //launchCommandLine.FilePath = fileAddress;
            launchCommandLine.Arguments = "log --scope=\"" + fileAddress + "\" --format-type=xml";
            Debug.WriteLine("Arguments:" + launchCommandLine.Arguments);
            await launchCommandLine.LaunchCommand();

            LaunchCommandLine.ExitCode exitCode = launchCommandLine.ProcessExitCode;
            m_output = launchCommandLine.Output;
            Debug.WriteLine("Output:" + m_output);

            
            /*
            selectedItems.BeginUpdate();
            switch (exitCode)
            {
                case LaunchCommandLine.ExitCode.Success:
                    selectedItems.Items[idx].ImageIndex = 1;
                    break;
                case LaunchCommandLine.ExitCode.Warnings:
                    selectedItems.Items[idx].ImageIndex = 2;
                    break;
                case LaunchCommandLine.ExitCode.Errors:
                    selectedItems.Items[idx].ImageIndex = 3;
                    break;
                case LaunchCommandLine.ExitCode.Fatal:
                    selectedItems.Items[idx].ImageIndex = 4;
                    break;
                default:
                    selectedItems.Items[idx].ImageIndex = 4;
                    break;
            }
            selectedItems.EndUpdate();
            */



            ProgressChanged();

           
            return 42;
        }

        // Called on process state only.
        void OnStatusChanged(LaunchCommandLine.Status param)
        {
            switch (param)
            {
                case LaunchCommandLine.Status.Running:
                    break;
                case LaunchCommandLine.Status.Completed:
                    //if (StatusChanged != null)
                    //{
                    //    StatusChanged(Action.Complete);
                    //}

                    break;
                case LaunchCommandLine.Status.Error:
                    break;
            }
        }

        void OnProgressChanged()
        {
            //ActionLabel.Text = progressBar.Value + "% complete";
            //timeRemainingLabel.Text = m_timeRemaining;
            //this.nameLabel.Text = m_currentFile;
            Refresh();
            System.Diagnostics.Debug.WriteLine("My text");
        }
    }
}
