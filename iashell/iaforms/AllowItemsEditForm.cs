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
    public partial class AllowItemsEditForm : Form
    {
        string ext;
        AllowItemType type;
        string mime;
        string description;
        public AllowItemsEditForm(AllowedItem item)
        {
            InitializeComponent();
            textBoxExt.Text = item.Extention;
            if (item.ImageType == AllowItemType.Picture)
            {
                radioButtonPicture.Checked = true;
            }
            else
            {
                radioButtonRaw.Checked = true;
            }

            textBoxMime.Text = item.Mime;
            textBoxDescription.Text = item.Description;
        }

        public string Ext { get => ext; set => ext = value; }
        public string Mime { get => mime; set => mime = value; }
        public string Description { get => description; set => description = value; }
        public AllowItemType Type { get => type; set => type = value; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Ext = textBoxExt.Text;
            if (radioButtonPicture.Checked == true)
            {
                Type = AllowItemType.Picture;
            }
            else
            {
                Type = AllowItemType.Raw;
            }

            Mime = textBoxMime.Text;
            Description = textBoxDescription.Text;
        }
    }
}
