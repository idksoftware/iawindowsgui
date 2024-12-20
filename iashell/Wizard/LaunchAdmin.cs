﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace IDK.Gui
{
    public class LaunchAdmin
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

        static readonly LaunchAdmin instance = new LaunchAdmin();

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
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static LaunchAdmin()
        {
        }

        LaunchAdmin()
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
        public static LaunchAdmin Instance
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


        public ExitCode ProcessExitCode
        {
            get
            {
                return exitCode;
            }
        }

        public string Output { get => output; set => output = value; }

        /*
        private void SetProcessExitCode(string output)
        {
            char[] delims = new[] { '\r', '\n' };
            string[] strings = output.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            string exitCodeString = strings[strings.Length - 1];

            int pos = exitCodeString.IndexOf(':');
            if (pos == -1)
            {
                exitCode = ExitCode.Fatal;
                return;
            }
            String exitCodeName = exitCodeString.Substring(0, pos - 1);
            if (output.Contains("Success"))
            {
                exitCode = ExitCode.Success;
                return;
            }
            else if (output.Contains("Warning"))
            {
                exitCode = ExitCode.Warnings;
                return;
            }
            else if (output.Contains("Error"))
            {
                exitCode = ExitCode.Errors;
                return;
            }
            else
            {
                exitCode = ExitCode.Fatal;
                return;
            }


        }
        */
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
                    String command = this.ExePath + "\\iaadmin.exe";
                    startInfo.FileName = command;
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    //startInfo.Arguments = "add --source-path=\"Z:\\Pictures/Photos/LightRoom backup/temp/DCIM/100D3200\" --events";
                    startInfo.Arguments = arguments;

                    System.Diagnostics.Debug.WriteLine("Arguments: " + arguments);

                    startInfo.RedirectStandardOutput = true;
                    Process process = Process.Start(startInfo);
                    process.EnableRaisingEvents = true;
                    process.Exited += new EventHandler(OnProcessExited);
                    output = process.StandardOutput.ReadToEnd();
                    //var result = Regex.Split(output, "\r\n|\r|\n");
                    int pos = output.IndexOf("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                    
                    // If not quiet output console loging i.e. debug loggin on then look for xml header.
                    if (pos != 0)
                    {
                        output = output.Substring(pos, output.Length - pos);
                    }
                    string isXML = output.Substring(0, 38);
                    if (!isXML.Equals("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"))
                    {
                        exitCode = ExitCode.Fatal;
                        return;
                    }
                    process.StartInfo.RedirectStandardError = true;

                    int ec = process.ExitCode;
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
                    System.Diagnostics.Debug.WriteLine("Output: " + output);
                    SetProcessExitCode(ec);
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

        private void SetProcessExitCode(int ec)
        {
            exitCode = (ExitCode)ec;
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
