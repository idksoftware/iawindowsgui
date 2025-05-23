﻿using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProgressDialog
{
    public partial class ProgressDialogForm : Form
    {

        public enum LogLevel
        {
            TRACE,
            FINE,
            INFO,
            STATUS,
            SUMMARY,
            WARNING,
            ERR,
            FATAL
        };
        /*
         #define LOG_STARTING			30
           #define LOG_ANALISING			31
           #define LOG_IMPORTING			32
           #define LOG_INITALISATION		33 // Initalisation
           #define LOG_COMPLETED   		34 //
         */

        public enum Stage
        {
            Idle,
            Initalising,
            Analising,
            Importing,
            Validating,
            Completed
        }
        public enum Action {
            Duplicate = 10,
            Idle = 29,
            Started = 30,
            Initalisation = 33,
            Analising = 31,
            InitalSummary = 101, // used to find number of images tom be processed
            CurrentImage = 104,
            Importing = 32,
            Validating = 37,
            Complete = 34,
            Canceled,
            Eborted
        }
        private class Line
        {
            public string Str;
            public Color ForeColor;

            public Line(string str, Color color)
            {
                Str = str;
                ForeColor = color;
            }
        };

        ArrayList lines = new ArrayList();

        public delegate void StatusEventHandler(Action param);
        public StatusEventHandler StatusChanged;

        string filterString = "";
        bool scrolling = true;
        Color receivedColor = Color.Green;
        Color sentColor = Color.Blue;
        bool serverOpen = false;
        bool running = true;
        bool canceling = false;
        int maxItems = 0;
        int currentItem = 0;
        Action action = Action.Idle;
        Stage stage = Stage.Idle;
        String currentFilename;
        String currentAction;

        private int warnings;
        private int errors;
        private int fatal;


        public ProgressDialogForm(String exePath, String workingPath, String filePath)
        {
            InitializeComponent();

            LaunchCommandLine launchCommandLine = LaunchCommandLine.Instance;
            launchCommandLine.ExePath = exePath;
            launchCommandLine.Path = workingPath;
            launchCommandLine.FilePath = filePath;
            LaunchCommandLine.StatusChanged += OnStatusChanged;
            this.progressBar.Maximum = 100;

            outputList_Initialize();

            UDPReader reader = UDPReader.Instance;
           
            //com.StatusChanged += OnStatusChanged;
            reader.DataReceived += OnDataReceived;
            reader.Open();
            buttonCancel.Image = Properties.Resources.cancel;
            buttonPause.Image = Properties.Resources.running;
            setTextFields();
            launchCommandLine.LaunchCommand();
        }

        // shutdown the worker thread when the form closes
        protected override void OnClosed(EventArgs e)
        {
            UDPReader reader = UDPReader.Instance;
            reader.Close();
            base.OnClosed(e);
        }

        private void outputList_Initialize()
        {
            // owner draw for listbox so we can add color
            outputList.DrawMode = DrawMode.OwnerDrawFixed;
            outputList.DrawItem += new DrawItemEventHandler(outputList_DrawItem);
            outputList.ClearSelected();
            
        }

        /// <summary>
        /// draw item with color in output window
        /// </summary>
        void outputList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0 && e.Index < outputList.Items.Count)
            {
                Line line = (Line)outputList.Items[e.Index];
                Trace.WriteLine(line.Str);

                // if selected, make the text color readable
                Color color = line.ForeColor;
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    color = Color.Black;	// make it readable
                }

                e.Graphics.DrawString(line.Str, e.Font, new SolidBrush(color),
                    e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Scroll to bottom of output window
        /// </summary>
        void outputList_Scroll()
        {
            if (scrolling)
            {
                int itemsPerPage = (int)(outputList.Height / outputList.ItemHeight);
                outputList.TopIndex = outputList.Items.Count - itemsPerPage;
            }
        }

        /// <summary>
        /// Enable/Disable copy selection in output window
        /// </summary>
        private void outputList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //popUpMenu.MenuItems[0].Enabled = (outputList.SelectedItems.Count > 0);
        }

        /// <summary>
        /// copy selection in output window to clipboard
        /// </summary>
        private void outputList_Copy(object sender, EventArgs e)
        {
            int iCount = outputList.SelectedItems.Count;
            if (iCount > 0)
            {
                String[] source = new String[iCount];
                for (int i = 0; i < iCount; ++i)
                {
                    source[i] = ((Line)outputList.SelectedItems[i]).Str;
                }

                String dest = String.Join("\r\n", source);
                Clipboard.SetText(dest);
            }
        }

        /// <summary>
        /// copy all lines in output window
        /// </summary>
        private void outputList_CopyAll(object sender, EventArgs e)
        {
            int iCount = outputList.Items.Count;
            if (iCount > 0)
            {
                String[] source = new String[iCount];
                for (int i = 0; i < iCount; ++i)
                {
                    source[i] = ((Line)outputList.Items[i]).Str;
                }

                String dest = String.Join("\r\n", source);
                Clipboard.SetText(dest);
            }
        }

        /// <summary>
        /// select all lines in output window
        /// </summary>
        private void outputList_SelectAll(object sender, EventArgs e)
        {
            outputList.BeginUpdate();
            for (int i = 0; i < outputList.Items.Count; ++i)
            {
                outputList.SetSelected(i, true);
            }
            outputList.EndUpdate();
        }

        /// <summary>
        /// clear selected in output window
        /// </summary>
        private void outputList_ClearSelected(object sender, EventArgs e)
        {
            outputList.ClearSelected();
            outputList.SelectedItem = -1;
        }

        /// <summary>
        /// Partial line for AddData().
        /// </summary>
        private Line partialLine = null;

        /// <summary>
        /// Add data to the output.
        /// </summary>
        /// <param name="StringIn"></param>
        /// <returns></returns>
        private Line AddData(String StringIn)
        {
            String StringOut = PrepareData(StringIn);

            // if we have a partial line, add to it.
            if (partialLine != null)
            {
                // tack it on
                partialLine.Str = StringOut;
                outputList_Update(partialLine);
                return partialLine;
            }

            return outputList_Add(StringOut, receivedColor);
        }

        private String PrepareData(String StringIn)
        {
            return StringIn;
        }
        /// <summary>
        /// add a new line to output window
        /// </summary>
        Line outputList_Add(string str, Color color)
        {
            Line newLine = new Line(str, color);
            lines.Add(newLine);

            //if (outputList_ApplyFilter(newLine.Str))
            //{
                outputList.Items.Add(newLine);
                outputList_Scroll();
            //}

            return newLine;
        }

        /// <summary>
        /// check to see if filter matches string
        /// </summary>
        /// <param name="s">string to check</param>
        /// <returns>true if matches filter</returns>
        bool outputList_ApplyFilter(String s)
        {
            if (filterString == "")
            {
                return true;
            }
            else if (s == "")
            {
                return false;
            }
            //else if (Settings.Option.FilterUseCase)
            //{
            //    return (s.IndexOf(filterString) != -1);
            //}
            else
            {
                string upperString = s.ToUpper();
                string upperFilter = filterString.ToUpper();
                return (upperString.IndexOf(upperFilter) != -1);
            }
        }
        /// <summary>
        /// Update a line in the output window.
        /// </summary>
        /// <param name="line">line to update</param>
        void outputList_Update(Line line)
        {
            // should we add to output?
            if (outputList_ApplyFilter(line.Str))
            {
                // is the line already displayed?
                bool found = false;
                for (int i = 0; i < outputList.Items.Count; ++i)
                {
                    int index = (outputList.Items.Count - 1) - i;
                    if (line == outputList.Items[index])
                    {
                        
                        // is item visible?
                        int itemsPerPage = (int)(outputList.Height / outputList.ItemHeight);
                        if (index >= outputList.TopIndex &&
                            index < (outputList.TopIndex + itemsPerPage))
                        {
                            // is there a way to refresh just one line
                            // without redrawing the entire listbox?
                            // changing the item value has no effect
                            outputList.Refresh();
                        }
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    // not found, so add it
                    outputList.Items.Add(line);
                }
            }
        }

        // delegate used for Invoke
        internal delegate void StringDelegate(string data);

        /// <summary>
        /// Handle data received event from serial port.
        /// </summary>
        /// <param name="data">incoming data</param>
        public void OnDataReceived(string dataStrIn)
        {
            //Handle multi-threading
            if (InvokeRequired)
            {
                Invoke(new StringDelegate(OnDataReceived), new object[] { dataStrIn });
                return;
            }
            int index;

            string[] lineIn = dataStrIn.Split('@');

            if (lineIn.Length != 4)
            {
                return;
            }
            String timeStr = lineIn[1];

            String levelStr = lineIn[2];
            updateLogLevels(levelStr);
            //String codeString = dataStrIn.Substring(0, 5);
            String dataIn = lineIn[3]; //dataStrIn.Substring(5, dataStrIn.Length - 4);
            //dataStrIn = lineIn[3];
            int code;
            if (Int32.TryParse(lineIn[0], out code))
            {
                if (code == (int)Action.Duplicate)
                {
                    currentAction = dataIn;
                    setTextFields();
                }
                if (code == (int)Action.Started)
                {
                    action = Action.Initalisation;
                    stage = Stage.Initalising;
                    //AsynchronousClient.StartClient();
                    //serverOpen = true;
                    setTextFields();
                }
                if (code == (int)Action.Analising)
                {

                    action = Action.Analising;
                    stage = Stage.Analising;
                    setTextFields();
                }
                if (code == (int)Action.Importing)
                {
                    action = Action.Importing;
                    stage = Stage.Importing;
                    setTextFields();
                }
                if (code == (int)Action.Validating)
                {
                    currentFilename = dataIn;
                    currentItem++;
                    setTextFields();
                }
                if (code == (int)Action.InitalSummary)
                {
                    int files;
                    int delim = dataIn.IndexOf(":");
                    delim += 7;
                    int idx = dataIn.IndexOf(" ", delim + 1);
                    String numStr = dataIn.Substring(delim+1, idx-(delim+1));
                    if (Int32.TryParse(numStr, out files))
                    {
                        this.maxItems = files;
                        setTextFields();
                       
                    }
                }
                if (code == 103)
                {
                    int current;
                    int idx = dataIn.IndexOf(" ");
                    String numStr = dataIn.Substring(0, idx);
                    if (Int32.TryParse(numStr, out current))
                    {
                        this.currentItem = current;
                        setTextFields();

                    }
                }
                if (code == (int)Action.CurrentImage)
                {
                    currentFilename = dataIn;
                    currentItem++;
                    setTextFields();
                }
                
               
                /*
                String tmp = dataIn.Substring(4, dataIn.Length - 4); ;
                index = tmp.IndexOf(" ");
                String ItemString = tmp.Substring(0, index);
                ProcessingLabel.Text = "Processing item " + ItemString;
                 */

            }
            // pause scrolling to speed up output of multiple lines
            bool saveScrolling = scrolling;
            scrolling = false;

            // if we detect a line terminator, add line to output
           
            
            while (dataIn.Length > 0 &&
                ((index = dataIn.IndexOf("\r")) != -1 ||
                (index = dataIn.IndexOf("\n")) != -1))
            {
                String StringIn = dataIn.Substring(0, index);
                dataIn = dataIn.Remove(0, index + 1);
                AddData(StringIn);
                //logFile_writeLine(AddData(StringIn).Str);
                partialLine = null;	// terminate partial line
            }
            
            // if we have data remaining, add a partial line
            if (dataIn.Length > 0)
            {
                partialLine = AddData(dataIn);
            }

            // restore scrolling
            scrolling = saveScrolling;
            outputList_Scroll();
        }

        public void setTextFields()
        {
            switch (stage)
            {
                case Stage.Idle:
                    Console.WriteLine("Stage: Idle");
                    labelStageText.Text = "Idle";
                    break;
                case Stage.Initalising:
                    Console.WriteLine("Stage: Initalising");
                    labelStageText.Text = "Initalising";
                    break;
                case Stage.Analising:
                    Console.WriteLine("Stage: Analising");
                    labelStageText.Text = "Analising";
                    break;
                case Stage.Importing:
                    Console.WriteLine("Stage: Importing");
                    labelStageText.Text = "Importing";
                    break;
                case Stage.Validating:
                    Console.WriteLine("Stage: Validating");
                    labelStageText.Text = "Validating";
                    break;
                case Stage.Completed:
                    Console.WriteLine("Stage: Completed");
                    labelStageText.Text = "Completed";
                    break;
            }

            if (serverOpen)
            {
                this.buttonCancel.Visible = true;
                this.buttonPause.Visible = true;
            }
            else
            {
                this.buttonCancel.Visible = false;
                this.buttonPause.Visible = false;
            }

            labelItemText.Text = String.Format("{0} of {1}", currentItem, maxItems);
            if (currentItem == 0)
            {
                ActionLabel.Text = String.Format("{0} 0% complete", actionString());
            }
            else
            {
                if (maxItems != 0) {
                    double cur = currentItem;
                    double max = maxItems;
                    if (cur > max) { cur = max; };
                    double percent = cur / max * 100;
                    int intPercent = (int)percent;
                    ActionLabel.Text = String.Format("{0} {1}% complete", actionString(), intPercent);
                    this.progressBar.Value = intPercent;
                    int elapsedTime = LaunchCommandLine.Instance.ElapsedTime;
                    this.timeRemainingLabel.Text = String.Format("{0}", elapsedTime);
                }
                else
                {
                    ActionLabel.Text = String.Format("{0}", actionString());
                }
            }
            

            labelImageName.Text = currentFilename;
            labelAction.Text = currentAction;
        }

        string actionString()
        {
            switch(action) {
                case Action.Idle: return "Idle";
                case Action.Initalisation: return "Initalising";
                case Action.Analising: return "Analising";
                case Action.Importing: return "Importing";
                case Action.Complete: return "Complete";
            }
            return "Idle";
        }

        LogLevel getLogLevel(string s)
        {
            if (s.Equals("TRACE")) return LogLevel.TRACE;
            if (s.Equals("FINE")) return LogLevel.FINE;
            if (s.Equals("INFO")) return LogLevel.INFO;
            if (s.Equals("STATUS")) return LogLevel.STATUS;
            if (s.Equals("SUMMARY")) return LogLevel.SUMMARY;
            if (s.Equals("WARNING")) return LogLevel.WARNING;
            if (s.Equals("ERR")) return LogLevel.ERR;
            if (s.Equals("FATAL")) return LogLevel.FATAL;
            return LogLevel.FATAL;
        }

        bool setLogLevels(string s)
        {
            bool changed = false; 
            LogLevel level = getLogLevel(s);
            if (level == LogLevel.WARNING)
            {
                warnings++;
                changed = true;
            }
            if (level == LogLevel.ERR)
            {
                errors++;
                changed = true;
            }

            return changed;
        }

        void updateLogLevels(string s)
        {
            if (setLogLevels(s))
            {
                labelErrors.Text = errors.ToString();
                labelWarnings.Text = warnings.ToString();
            }
        }

        void OnStatusChanged(LaunchCommandLine.Status param)
        {
            switch(param) {
                case LaunchCommandLine.Status.Running:
                    break;
                case LaunchCommandLine.Status.Completed:
                    if (StatusChanged != null) {
                        StatusChanged(Action.Complete);
                    }
                    //DoClose();
                    break;
                case LaunchCommandLine.Status.Error:
                    break;
            }
        }
        private void DoClose()
        {
            //this.Close();
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            
            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    // close the form on the forms thread
                    this.Close();
                });
            }
            
        }


        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (running)
            {
                buttonPause.Image = Properties.Resources.pause;
                running = false;
                AsynchronousClient.pauseCommand();
            }
            else
            {
                buttonPause.Image = Properties.Resources.running;
                running = true;
                AsynchronousClient.runCommand();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (canceling == false)
            {
                buttonCancel.Image = Properties.Resources.canceling;
                canceling = true;
                AsynchronousClient.stopCommand();
            }
           
        }

        private void timeRemainingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
