using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDK.Gui
{
    public partial class BackupsForm : Form
    {
        public BackupsForm()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {

        }

        private void BackupsForm_Load(object sender, EventArgs e)
        {
            groupBoxBackups.Text = "test";
            textBoxBackup1.Text = "Test1";
            textBoxBackup2.Text = "Test2";
        }
    }
}
