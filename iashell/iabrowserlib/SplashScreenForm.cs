using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iabrowserlib
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            EventHandler closeForm;
            //closeForm += CloseForm;
            InitializeComponent();
            Thread.Sleep(5000);
            //closeForm?.Invoke(this, EventArgs.Empty);
        }

        private void CloseForm(object? sender, EventArgs e)
        {
            Close();
        }
    }


}
