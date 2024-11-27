using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace iaforms
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

        public enum ExitCode
        {
            Success = 0,
            Warnings = -1,
            Errors = -2,
            Fatal = -3
        };

        private static int elapsedTime;
        //static bool eventHandled = false;

        static readonly LaunchCommandLine instance = new LaunchCommandLine();

        public delegate void StatusEventHandler(Status param);
        public static StatusEventHandler StatusChanged;

        private Process ImgaProcess;
        private TaskCompletionSource<bool> eventHandled;
        string arguments;
        string path;
        string exePath;
        string filePath;
        string output;
       
        ExitCode exitCode = ExitCode.Fatal;
        int returnCode;
        string returnString;
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static LaunchCommandLine()
        {
        }

        LaunchCommandLine()
        {
            
        }

        public string Arguments
        {
            get
            {
                return arguments;
            }
            set
            {
                arguments = value;
            }
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

        public string Output
        {
            get
            {
                return output;
            }
        }

        public int ElapsedTime
        {
            get
            {
                return elapsedTime;
            }
        }
        

        public ExitCode ProcessExitCode
        {
            get
            {
                return exitCode;
            }
        }

        public int ProcessReturnCode
        {
            get
            {
                return returnCode;
            }
        }

        public string ProcessReturnString
        {
            get
            {
                return returnString;
            }
        }

        private void SetProcessExitCode(int ec)
        {
            exitCode = (ExitCode)ec;
        }
        
        private void processReturnCode(string output)
        {
            char[] delims = new[] { '\r', '\n' };
            string[] strings = output.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            string exitCodeString = strings[strings.Length - 1];

            int pos = exitCodeString.IndexOf(':');
            if (pos == -1)
            {
                return;
            }
            String exitCodeName = exitCodeString.Substring(pos+1, 4);
            returnCode = Int16.Parse(exitCodeName);
            pos = exitCodeString.IndexOf('-');
            returnString = exitCodeString.Substring(pos + 2, exitCodeString.Length - (pos+2));

        }
        
        /// <summary>
        /// Launch the legacy application with some options set.
        /// </summary>
        public async Task LaunchCommand()
        {

            eventHandled = new TaskCompletionSource<bool>();

            using (ImgaProcess = new Process())
            {
                
                try
                {


                    // Use ProcessStartInfo class.
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    //startInfo.RedirectStandardOutput = true;
                    startInfo.CreateNoWindow = true;
                    //startInfo.CreateNoWindow = false;
                    startInfo.UseShellExecute = false;
                    startInfo.WorkingDirectory = path;
                    String command = this.ExePath + "\\iavault.exe";
                    System.Diagnostics.Debug.WriteLine("Exe path: " + command);
                    startInfo.FileName = command;
                    //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.Arguments = arguments;

                    System.Diagnostics.Debug.WriteLine("Arguments: " + arguments);

                    startInfo.RedirectStandardOutput = true;
                    Process process = Process.Start(startInfo);
                    process.EnableRaisingEvents = true;
                    process.Exited += new EventHandler(OnProcessExited);
                    output = process.StandardOutput.ReadToEnd();
                    process.StartInfo.RedirectStandardError = true;


                    /*
                    const int SLEEP_AMOUNT = 100;
                    while (!eventHandled)
                    {
                        elapsedTime += SLEEP_AMOUNT;

                        Thread.Sleep(SLEEP_AMOUNT);

                    }

                    process.WaitForExit();
                    if (StatusChanged != null)
                    {
                        StatusChanged(Status.Completed);
                    }
                    */
                    int exitCode = process.ExitCode;
                    System.Diagnostics.Debug.WriteLine("Output: " + output);
                    SetProcessExitCode(exitCode);
                    processReturnCode(output);
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
                await Task.WhenAny(eventHandled.Task, Task.Delay(30000));


            }
        }



        // Handle Exited event and display process information.
        private void OnProcessExited(object sender, System.EventArgs e)
        {
            if (StatusChanged != null)
            {
                StatusChanged(Status.Completed);
            }
            eventHandled.TrySetResult(true);
            //eventHandled = true;
            //Console.WriteLine("Exit time:    {0}\r\n" +
            //    "Exit code:    {1}\r\nElapsed time: {2}", myProcess.ExitTime, myProcess.ExitCode, elapsedTime);
        }

        
        
    }
 }
