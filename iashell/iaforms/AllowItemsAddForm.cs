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
        AllowedItem allowedItem = new AllowedItem();

        public AllowedItem AllowedItem { get => allowedItem; }

        public AllowItemsAddForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            allowedItem.Extention = textBoxExt.Text;
            if (radioButtonPicture.Checked == true)
            {
                allowedItem.ImageType = AllowItemType.Picture;
            }
            else
            {
                allowedItem.ImageType = AllowItemType.Raw;
            }

            allowedItem.Mime = textBoxMime.Text;
            allowedItem.Description = textBoxDescription.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
