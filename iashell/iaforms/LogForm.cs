using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iaforms;

namespace iaprop
{
    public partial class LogForm : Form
    {
        ImageLog ImageLog;

        public delegate void ProgressEventHandler();
        public static ProgressEventHandler ProgressChanged;

        string m_exePath;
        string m_workingPath;
        string m_output;

        String m_path;
        string m_file;
        public LogForm(String p, string f, string e, string w)
        {
            m_exePath = e;
            m_workingPath = w;
            m_path = p;
            m_file = f;
            InitializeComponent();
            this.labelDate.Text = m_path;
            this.labelImageName.Text = m_file;
            ImageLog = new ImageLog();
            ProgressData();
            LoadItems();
            AddItems();
        }

        void LoadItems()
        {
            ImageEvent event1 = new ImageEvent();
            event1.dateAdded = "21-07-04";
            event1.evt = 1;
            event1.version = 0;
            event1.comment = "Inital version";

            ImageLog.events.Add(event1);
        }

        public void AddItems()
        {
            int itemNumber = 1;
            foreach (ImageEvent item in ImageLog.events)
            {
                ListViewItem lvi = new ListViewItem(itemNumber.ToString());
                
                
                lvi.SubItems.Add(item.dateAdded);
                lvi.SubItems.Add(item.version.ToString());
                lvi.SubItems.Add(item.evt.ToString());
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
            await launchCommandLine.LaunchCommand();

            LaunchCommandLine.ExitCode exitCode = launchCommandLine.ProcessExitCode;
            m_output = launchCommandLine.Output;
            System.Diagnostics.Debug.WriteLine("Output:" + m_output);
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
