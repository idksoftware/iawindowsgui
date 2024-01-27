using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaforms
{
    public partial class LogViewForm : Form
    {
        private string m_date;
        private string m_ident;
        private string m_size;

        public LogViewForm(FileInfo file)
        {
            InitializeComponent();

            string name = file.Name;
            int sdate = name.IndexOf("-");
            int edate = name.IndexOf("_");
            string date = name.Substring(sdate + 1, (edate - sdate) - 1);

            m_date = formatDate(date);

            m_ident = name.Substring(edate + 1, 4);
            m_size = file.Length.ToString();
            //lvi.SubItems.Add(item.Description);
            TitleLabel.Text = "Log View - " + file.Name;
            labelDate.Text = m_date;
            labelIdent.Text = m_ident;
            labelSize.Text = m_size;

            FileStream fs = file.Open(FileMode.Open);

            var fileReader = new System.IO.StreamReader(fs, System.Text.Encoding.UTF8, true, 128);
            string lineOfText;
            while ((lineOfText = fileReader.ReadLine()) != null)
            {
                Trace.WriteLine(lineOfText);
                if (lineOfText.Length == 0)
                {
                    continue;
                }
                ListViewItem lvi = MakeItem(listViewLogView.Items.Count + 1, lineOfText);
                listViewLogView.Items.Add(lvi);
            }

        }

        public string formatDate(string d)
        {
            string fd = d.Substring(0, 4) + "/" + d.Substring(4, 2) + "/" + d.Substring(6, 2);
            d = fd;
            return d;
        }


        /*
         000104: 2023.07.06 11.51.45.70	[    STATUS ]	Processing Image 5 file: "DSC00161-03.ARW"
           010242: 2023.07.06 11.51.46.7	[    STATUS ]	Internal Exif reader: No jpeg EXIF found, possibly a RAW file: C:/pics/2017/2017-01-02/images/DSC00161-03.ARW
           
         */
        public ListViewItem MakeItem(int count, string lineOfText)
        {
            ListViewItem lvi = new ListViewItem((count).ToString());
            lvi.ImageIndex = count;

            string name = lineOfText;
            int ide = name.IndexOf(":");
            string ident = name.Substring(0, ide);
            lvi.SubItems.Add(ident);
            int edt = name.IndexOf("[");
            string datetime = name.Substring(ide + 2, edt - 3);
            int dtd = datetime.IndexOf(" ");
            string dateStr = datetime.Substring(0, dtd);
            lvi.SubItems.Add(dateStr);
            int enddt = (datetime.Length - dtd) - 7;
            string timeStr = datetime.Substring(dtd + 1, enddt);
            lvi.SubItems.Add(timeStr);
            int sdate = name.IndexOf("[");
            int edate = name.IndexOf("]");
            string level = name.Substring(sdate + 1, (edate - sdate) - 1);
            lvi.SubItems.Add(level);
            string disc = name.Substring(edate + 1, (name.Length - edate) - 1);
            lvi.SubItems.Add(disc);
            //lvi.SubItems.Add(formatDate(date));

            //lvi.SubItems.Add(name.Substring(edate + 1, 4));
            //lvi.SubItems.Add(item.Length.ToString());
            //lvi.SubItems.Add(item.Description);
            return lvi;
        }

    }
}
