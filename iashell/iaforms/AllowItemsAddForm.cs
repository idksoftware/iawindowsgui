using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaforms
{
    public partial class AllowItemsAddForm : Form
    {
        AllowItem allowItem = new AllowItem();

        public AllowItem AllowItem { get => allowItem; }

        public AllowItemsAddForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            allowItem.ext = textBoxExt.Text;
            if (radioButtonPicture.Checked == true)
            {
                allowItem.type = AllowItem.AllowItemType.Picture;
            }
            else
            {
                allowItem.type = AllowItem.AllowItemType.Raw;
            }

            allowItem.mime = textBoxMime.Text;
            allowItem.description = textBoxDescription.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
