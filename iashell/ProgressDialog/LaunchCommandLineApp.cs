using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProgressDialog
{
    // add --source-path="Z:\Pictures/Photos/LightRoom backup/temp/DCIM/100D3200" --events
    // C:\development\sia\SimpleArchive\Release
    public class LaunchCommandLine
    {
        public enum Status
        {
            Running,
            Completed,
            Error
        };
        private static int elapsedTime;
        //static bool eventHandled = false;

        Thread _runThread;
        
        static readonly LaunchCommandLine instance = new LaunchCommandLine();

        public delegate void StatusEventHandler(Status param);
        public static StatusEventHandler StatusChanged;

        private Process ImgaProcess;
        private TaskCompletionSource<bool> eventHandled;

        string path;
        string exePath;
        string filePath;
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static LaunchCommandLine()
        {
        }

        LaunchCommandLine()
        {
            _runThread = null;
            
        }
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }
        public string ExePath
        {
            get
            {
                return exePath;
            }
            set
            {
                exePath = value;
            }
        }

        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }
        public static LaunchCommandLine Instance
        {
            get
            {
                return instance;
            }
        }

        public int ElapsedTime
        {
            get
            {
                return elapsedTime;
            }
        }
        public void Run()
        {
            
            StartRunning();
        }
        private void StartRunning()
        {

            /*
            _runThread = new Thread(LaunchCommand);
            _runThread.Start();
            if (StatusChanged != null)
            {
                StatusChanged(Status.Running);
            }
            */
            LaunchCommand();

        }
         /// <summary>
    /// Launch the legacy application with some options set.
    /// </summary>
        public async Task LaunchCommand()
        {
            Process ImgaProcess;
            eventHandled = new TaskCompletionSource<bool>();

            using (ImgaProcess = new Process())
            {
                try
                {


                    // Use ProcessStartInfo class.
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    //startInfo.RedirectStandardOutput = true;
                    //startInfo.CreateNoWindow = true;
                    startInfo.CreateNoWindow = false;
                    startInfo.UseShellExecute = false;
                    startInfo.WorkingDirectory = path;
                    String command = this.ExePath + "C:\\Program Files\\IDK-Software\\imgarchive\\iaarc.exe";
                    startInfo.FileName = command;
                    //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    //startInfo.Arguments = "add --source-path=\"Z:\\Pictures/Photos/LightRoom backup/temp/DCIM/100D3200\" --events";
                    startInfo.Arguments = "checkout --scope=\"" + filePath + "\"";


                    Process process = Process.Start(startInfo);
                    process.EnableRaisingEvents = true;
                    process.Exited += new EventHandler(OnProcessExited);

                 

                }
                catch (Exception ex)
                {
                    if (StatusChanged != null)
                    {
                        StatusChanged(Status.Error);
                    }
                    return;
                }
                // Wait for Exited event, but not more than 10 seconds.
                await Task.WhenAny(eventHandled.Task, Task.Delay(10000));
            }
        }

/*
	        try
	        {
	            // Start the process with the info we specified.
	            // Call WaitForExit and then the using-statement will close.
                Process.EnableRaisingEvents = true;
                startInfo.Exited += new EventHandler(myProcess_Exited);
	            using (Process exeProcess = Process.Start(startInfo))
	            {
		            exeProcess.WaitForExit();
                    if (StatusChanged != null)
                    {
                        StatusChanged(Status.Completed);
                    }
	            }
	        }
	        catch
	        {
                // Log error.
                if (StatusChanged != null)
                {
                    StatusChanged(Status.Error);
                }

            }
 */
        
        // Handle Exited event and display process information.
        private void OnProcessExited(object sender, System.EventArgs e)
        {
            if (StatusChanged != null)
            {
                StatusChanged(Status.Completed);
            }
            //eventHandled = true;
            //Console.WriteLine("Exit time:    {0}\r\n" +
            //    "Exit code:    {1}\r\nElapsed time: {2}", myProcess.ExitTime, myProcess.ExitCode, elapsedTime);
        }


    }
}
