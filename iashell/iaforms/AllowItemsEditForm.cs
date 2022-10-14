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
        AllowItem.AllowItemType type;
        string mime;
        string description;
        public AllowItemsEditForm(AllowItem item)
        {
            InitializeComponent();
            textBoxExt.Text = item.ext;
            if (item.type == AllowItem.AllowItemType.Picture)
            {
                radioButtonPicture.Checked = true;
            }
            else
            {
                radioButtonRaw.Checked = true;
            }

            textBoxMime.Text = item.mime;
            textBoxDescription.Text = item.description;
        }

        public string Ext { get => ext; set => ext = value; }
        public string Mime { get => mime; set => mime = value; }
        public string Description { get => description; set => description = value; }
        public AllowItem.AllowItemType Type { get => type; set => type = value; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Ext = textBoxExt.Text;
            if (radioButtonPicture.Checked == true)
            {
                Type = AllowItem.AllowItemType.Picture;
            }
            else
            {
                Type = AllowItem.AllowItemType.Raw;
            }

            Mime = textBoxMime.Text;
            Description = textBoxDescription.Text;
        }
    }
}
