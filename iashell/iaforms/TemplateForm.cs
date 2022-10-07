using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iaforms
{
    public partial class TemplateForm : Form
    {
        string Label;
        string Title;
        string Subject;
        string Description;
        string Rating;
        string RatingPercent;
        string Keywords;
        string Tags;
        string Comment;
        string Author;
        string Copyright;
        string Maker;
        string Model;
        string Latitude;
        string Longitude;
        string Location;
        string Scene;
        string SourceUrl;
        string UsageRights;
        string CopyrightUrl;
        string Headline;
        string Category;
        string Source;
        string Instructions;
        string Creator;
        string JobTitle;
        string Address;
        string City;
        string State;
        string PostalCode;
        string Country;
        string Phone;
        string Email;
        string Website;

        public TemplateForm()
        {
            InitializeComponent();
            string fileName = "C:\\ProgramData\\IDK-Software\\ImgArchive\\template\\master_base.tpl";
            var lines = File.ReadLines(fileName);
            foreach (var line in lines) {
                // Process line
                matchKeywords(line);
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        bool matchKeywords(string line)
        {
            int pos = line.IndexOf('=');
            if (pos == -1)
            {
                return false;
            }
            String name = line.Substring(0, pos - 1);
            string value = line.Substring(pos+1, line.Length - (pos + 1));
            if (string.Equals(name, "Label")) {
                Label = value;
            }
            if (string.Equals(name, "Title")) {
                textBoxTitle.Text = value;
            }
            if (string.Equals(name, "Subject")) {
                Label = value;
            }
            if (string.Equals(name, "Description")) {
                Label = value;
            }
           if (string.Equals(name, "Rating")) {
                Label = value;
            }
           if (string.Equals(name, "RatingPercent")) {
                Label = value;
            }
           if (string.Equals(name, "Keywords")) {
                Label = value;
            }
           if (string.Equals(name, "Tags")) {
                Label = value;
            }
           if (string.Equals(name, "Comment")) {
                Label = value;
            }
           if (string.Equals(name, "Author")) {
                Label = value;
            }
           if (string.Equals(name, "Copyright")) {
                Label = value;
            }
           if (string.Equals(name, "Maker")) {
                Label = value;
            }
           if (string.Equals(name, "Model")) {
                Label = value;
            }
           if (string.Equals(name, "Latitude")) {
                Label = value;
            }
           if (string.Equals(name, "Longitude")) {
                Label = value;
            }
           if (string.Equals(name, "Location")) {
                Label = value;
            }
           if (string.Equals(name, "Scene")) {
                Label = value;
            }
            if (string.Equals(name, "SourceUrl")) {
                Label = value;
            }
           if (string.Equals(name, "UsageRights")) {
                Label = value;
            }
           if (string.Equals(name, "CopyrightUrl")) {
                Label = value;
            }
           if (string.Equals(name, "Headline")) {
                Label = value;
            }
           if (string.Equals(name, "Category")) {
                Label = value;
            }
           if (string.Equals(name, "Source")) {
                Label = value;
            }
           if (string.Equals(name, "Instructions")) {
                Label = value;
            }
           if (string.Equals(name, "Creator")) {
                Label = value;
            }       
           if (string.Equals(name, "JobTitle")) {
                Label = value;
            }       
           if (string.Equals(name, "Address")) {
                Label = value;
            }
           if (string.Equals(name, "City")) {
                Label = value;
            }          
           if (string.Equals(name, "State")) {
                Label = value;
            }      
           if (string.Equals(name, "PostalCode")) {
                Label = value;
            }         
           if (string.Equals(name, "Country")) {
                Label = value;
            }          
           if (string.Equals(name, "Phone")) {
                Label = value;
            }           
           if (string.Equals(name, "Email")) {
                Label = value;
            }         
           if (string.Equals(name, "Website")) {
                Label = value;
            }
            return true;
        }

    }

   
}
