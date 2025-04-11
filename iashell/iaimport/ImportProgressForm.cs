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

namespace iaimport
{
    public partial class ImportProgressForm : Form
    {
        public delegate void ProgressEventHandler();
        public static ProgressEventHandler ProgressChanged;
        String m_timeRemaining;
        List<string> m_files;
        string m_exePath;
        string m_workingPath;
        string m_currentFile;
        public ImportProgressForm(string folder, string exePath, string workingPath)
        {
            InitializeComponent();

            InitializeComponent();
            //m_files = folder;
            m_exePath = exePath;
            m_workingPath = workingPath;
            this.labelProcess.Text = "Check-out";
            this.Name = "Check-out Calculating...";

            
            progressBar.Maximum = 100;
            //AddItems(m_files);
            ActionLabel.Text = progressBar.Value + "% complete";
            timeRemainingLabel.Text = "Calculating...";
            timerStartProcess.Start();
            
        }

        public async Task<int> ProgressData()
        {

            //float step = 100 / m_files.Count;
            float progress;

            LaunchCommandLine launchCommandLine = LaunchCommandLine.Instance;
            launchCommandLine.ExePath = m_exePath;
            launchCommandLine.Path = m_workingPath;

            LaunchCommandLine.StatusChanged += OnStatusChanged;
            ProgressChanged += OnProgressChanged;

            this.progressBar.Maximum = 100;
            TimeSpan elapsed;
            //await Task.Delay(2000);
            int idx = 0;
            //int itemsToByProcessed = m_files.Count;
            ActionLabel.Text = progressBar.Value + "% complete";
            timeRemainingLabel.Text = "Calculating...";
            
            var timer = System.Diagnostics.Stopwatch.StartNew();
            timer.Restart();
            string address;
            string name;
            //GetAddress(file, out address);
            //GetFile(file, out name);
            //m_currentFile = name;
            string fileAddress = "D:\\pics\\pics";
            //launchCommandLine.FilePath = fileAddress;
            launchCommandLine.Arguments = "import --source-path=\"" + fileAddress + "\"";
            await launchCommandLine.LaunchCommand();

            LaunchCommandLine.ExitCode exitCode = launchCommandLine.ProcessExitCode;
            //labelComment.Text = launchCommandLine.ProcessReturnString;
            selectedItems.BeginUpdate();
            switch (exitCode)
            {
                case LaunchCommandLine.ExitCode.Success:
                    //selectedItems.Items[idx].ImageIndex = 1;
                    //labelResult.Text = "Success";
                    //labelComment.Text = "Successfully checked out: " + name;
                    break;
                case LaunchCommandLine.ExitCode.Warnings:
                    //selectedItems.Items[idx].ImageIndex = 2;
                    //labelResult.Text = "Warnings";
                    break;
                case LaunchCommandLine.ExitCode.Errors:
                    //selectedItems.Items[idx].ImageIndex = 3;
                    //labelResult.Text = "Errors";
                    break;
                case LaunchCommandLine.ExitCode.Fatal:
                    //selectedItems.Items[idx].ImageIndex = 4;
                    //labelResult.Text = "Fatal";
                    break;
                default:
                    //selectedItems.Items[idx].ImageIndex = 4;
                    //labelResult.Text = "Unknown";
                    break;
            }
            selectedItems.EndUpdate();

            /*
            progress = step * (idx + 1);
            progressBar.Value = (int)progress;
            ActionLabel.Text = progressBar.Value + "% complete";
            idx++;
            timer.Stop();
            elapsed = timer.Elapsed;
            double TimeRemaining = elapsed.TotalSeconds * (itemsToByProcessed - idx + 1);
            TimeSpan TimeSpanRemaining = TimeSpan.FromSeconds(TimeRemaining);
            //String timeStr = TimeSpanRemaining.ToReadableString();
            //m_timeRemaining = "About " + timeStr;
            */
            ProgressChanged();

            
            timeRemainingLabel.Text = "Complete";
            progressBar.Value = 100;
            ActionLabel.Text = "Complete";
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
            ActionLabel.Text = progressBar.Value + "% complete";
            timeRemainingLabel.Text = m_timeRemaining;
            //this.nameLabel.Text = m_currentFile;
            Refresh();
            System.Diagnostics.Debug.WriteLine("My text");
        }

        internal static class TimeSpanExt
        {
            public static string ToReadableString(TimeSpan span)
            {
                string formatted = string.Format("{0}{1}{2}{3}",
                    span.Duration().Days > 0 ? string.Format("{0:0} day{1}, ", span.Days, span.Days == 1 ? string.Empty : "s") : string.Empty,
                    span.Duration().Hours > 0 ? string.Format("{0:0} hour{1}, ", span.Hours, span.Hours == 1 ? string.Empty : "s") : string.Empty,
                    span.Duration().Minutes > 0 ? string.Format("{0:0} minute{1}, ", span.Minutes, span.Minutes == 1 ? string.Empty : "s") : string.Empty,
                    span.Duration().Seconds > 0 ? string.Format("{0:0} second{1}", span.Seconds, span.Seconds == 1 ? string.Empty : "s") : string.Empty);

                if (formatted.EndsWith(", ")) formatted = formatted.Substring(0, formatted.Length - 2);

                if (string.IsNullOrEmpty(formatted)) formatted = "0 seconds";

                return formatted;
            }
        }

        private async void timerStartProcess_Tick(object sender, EventArgs e)
        {
            timerStartProcess.Stop();
            await ProgressData();
           
        }
    }
}
