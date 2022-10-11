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
        public AllowItemsEditForm(string ext, AllowItem.AllowItemType type, string mime, string description)
        {
            InitializeComponent();
            textBoxExt.Text = ext;


        }

        public string Ext { get => ext; set => ext = value; }
        public string Mime { get => mime; set => mime = value; }
        public string Description { get => description; set => description = value; }
        public AllowItem.AllowItemType Type { get => type; set => type = value; }
    }
}
