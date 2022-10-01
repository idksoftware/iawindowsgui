﻿using System;
using iaforms;
using System.Windows.Forms;
using System.IO;

// C:\Users\H497222\ImgArchive\Workspace\2008\2008-09-16\IMG_0599.JPG
//

namespace iachkout
{
    public partial class CheckOutSingleForm : Form
    {
        string m_file;
        public CheckOutSingleForm(string file)
        {
            InitializeComponent();
            m_file = file;
            FileInfo fileItem = new FileInfo(file);
            labelType.Text = fileItem.Extension;
            DateTime lastmodified = fileItem.LastWriteTime;
            string dateString = lastmodified.ToString("HH:mm MM/dd/yyyy");
            labelDateModified.Text = dateString;
            labelFolder.Text = fileItem.DirectoryName;
            labelImage.Text = fileItem.Name;
            labelSize.Text = fileItem.Length.ToString();
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            (new PropertiesForm(m_file)).Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
