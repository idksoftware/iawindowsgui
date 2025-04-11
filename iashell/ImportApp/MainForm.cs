using iaforms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using static ImportApp.MainForm;
using iaforms;

namespace ImportApp
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLocal_Click(object sender, EventArgs e)
        {
            (new AttachedDrivesForm()).Show();
        }

        private void buttonNetwork_Click(object sender, EventArgs e)
        {
            (new NetworkComputersForm()).Show();

        }
     


        private void buttonDownloads_Click(object sender, EventArgs e)
        {
            ImagePathList ipl = new ImagePathList("g:\\");
            ipl.Process();
        }

       
    }
}