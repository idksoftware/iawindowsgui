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

namespace iaadmingui
{
    public partial class ConfigForm : Form
    {
        string exePath;
        string workingPath;
        ExifToolObject m_exifTool = null;
        public ConfigForm(string workingFolder, string exeFolder)
        {
            exePath = exeFolder;
            workingPath = workingFolder;
            InitializeComponent();

        }
        int itemNumber = 1;
        //AllowItems allowItems = null;

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }
    }
}
