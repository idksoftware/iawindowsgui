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
        string title;
        string backup1;
        string backup2;
        public BackupsForm(string name, string b1, string b2)
        {
            title = name;
            backup1 = b1;
            backup2 = b2;
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackupsForm_Load(object sender, EventArgs e)
        {
            groupBoxBackups.Text = title;
            textBoxBackup1.Text = backup1;
            textBoxBackup2.Text = backup2;
        }
    }
}
