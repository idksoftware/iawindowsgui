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
    
    public partial class UserSpaceUC : UserControl
    {
        public UserSpaceUC()
        {
            InitializeComponent();
        }

        private void UserSpaceUC_Leave(object sender, EventArgs e)
        {
            UnSavedChanges.m_UnSavedChanges = true;
            MessageBox.Show("Current View can not close!");
        }
    }
}
