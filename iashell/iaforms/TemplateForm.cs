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
            string tmp = line.Substring(pos+1, line.Length - (pos + 1));
            var value = tmp.Trim('"', ' '); 

            if (string.Equals(name, "Label")) {
                textBoxLabel.Text = value;
            }
            if (string.Equals(name, "Title")) {
                textBoxTitle.Text = value;
            }
            if (string.Equals(name, "Subject")) {
                textBoxSubject.Text = value;
            }
            if (string.Equals(name, "Description")) {
                textBoxDescription.Text = value;
            }
           if (string.Equals(name, "Rating")) {
                textBoxRating.Text = value;
            }
           if (string.Equals(name, "RatingPercent")) {
                textBoxRatingPercent.Text = value;
            }
           if (string.Equals(name, "Keywords")) {
                //textBoxKeywords.Text = value;
            }
            if (string.Equals(name, "Tags")) {
                //textBoxTags.Text = value;
            }
            if (string.Equals(name, "Comment")) {
                textBoxComment.Text = value;
            }
           if (string.Equals(name, "Author")) {
                textBoxAuthor.Text = value;
            }
           if (string.Equals(name, "Copyright")) {
                textBoxCopyright.Text = value;
            }
           if (string.Equals(name, "Maker")) {
                textBoxMake.Text = value;
            }
           if (string.Equals(name, "Model")) {
                textBoxModel.Text = value;
            }
           if (string.Equals(name, "Latitude")) {
                textBoxLatitude.Text = value;
            }
           if (string.Equals(name, "Longitude")) {
                textBoxLongitude.Text = value;
            }
           if (string.Equals(name, "Location")) {
                textBoxLocation.Text = value;
            }
           if (string.Equals(name, "Scene")) {
                textBoxScene.Text = value;
            }
            if (string.Equals(name, "SourceUrl")) {
                textBoxSourceUrl.Text = value;
            }
           if (string.Equals(name, "UsageRights")) {
                textBoxUsageRights.Text = value;
            }
           if (string.Equals(name, "CopyrightUrl")) {
                textBoxCopyrightUrl.Text = value;
            }
           if (string.Equals(name, "Headline")) {
                textBoxHeadline.Text = value;
            }
           if (string.Equals(name, "Category")) {
                textBoxCategory.Text = value;
            }
           if (string.Equals(name, "Source")) {
                textBoxSource.Text = value;
            }
           if (string.Equals(name, "Instructions")) {
                textBoxInstructions.Text = value;
            }
           if (string.Equals(name, "Creator")) {
                textBoxCreator.Text = value;
            }       
           if (string.Equals(name, "JobTitle")) {
                textBoxJobTitle.Text = value;
            }       
           if (string.Equals(name, "Address")) {
                textBoxAddress.Text = value;
            }
           if (string.Equals(name, "City")) {
                textBoxCity.Text = value;
            }          
           if (string.Equals(name, "State")) {
                textBoxState.Text = value;
            }      
           if (string.Equals(name, "PostalCode")) {
                textBoxPostalCode.Text = value;
            }         
           if (string.Equals(name, "Country")) {
                textBoxCountry.Text = value;
            }          
           if (string.Equals(name, "Phone")) {
                textBoxPhone.Text = value;
            }           
           if (string.Equals(name, "Email")) {
                textBoxEmail.Text = value;
            }         
           if (string.Equals(name, "Website")) {
                textBoxWebsite.Text = value;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("Label = \"" + textBoxLabel.Text + '\"');
            list.Add("Title = \"" + textBoxTitle.Text + '\"');
            list.Add("Subject = \"" + textBoxSubject.Text + '\"');
            list.Add("Description = \"" + textBoxDescription.Text + '\"');
            list.Add("Rating = \"" + textBoxRating.Text + '\"');
            list.Add("RatingPercent = \"" + textBoxRatingPercent.Text + '\"');
            //textBoxKeywords.Text = value;
            //textBoxTags.Text = value;
            list.Add("Comment = \"" + textBoxComment.Text + '\"');
            list.Add("Author = \"" + textBoxAuthor.Text + '\"');
            list.Add("Copyright = \"" + textBoxCopyright.Text + '\"');
            list.Add("Maker = \"" + textBoxMake.Text + '\"');
            list.Add("Model = \"" + textBoxModel.Text + '\"');
            list.Add("Latitude = \"" + textBoxLatitude.Text + '\"');
            list.Add("Longitude = \"" + textBoxLongitude.Text + '\"');
            list.Add("Location = \"" + textBoxLocation.Text + '\"');
            list.Add("Scene = \"" + textBoxScene.Text + '\"');
            list.Add("SourceUrl = \"" + textBoxSourceUrl.Text + '\"');
            list.Add("UsageRights = \"" + textBoxUsageRights.Text + '\"');
            list.Add("CopyrightUrl = \"" + textBoxCopyrightUrl.Text + '\"');
            list.Add("Headline = \"" + textBoxHeadline.Text + '\"');
            list.Add("Category = \"" + textBoxCategory.Text + '\"');
            list.Add("Source = \"" + textBoxSource.Text + '\"');
            list.Add("Instructions = \"" + textBoxInstructions.Text + '\"');
            list.Add("Creator = \"" + textBoxCreator.Text + '\"');
            list.Add("JobTitle = \"" + textBoxJobTitle.Text + '\"');
            list.Add("Address = \"" + textBoxAddress.Text + '\"');
            list.Add("City = \"" + textBoxCity.Text + '\"');
            list.Add("State = \"" + textBoxState.Text + '\"');
            list.Add("PostalCode = \"" + textBoxPostalCode.Text + '\"');
            list.Add("Country = \"" + textBoxCountry.Text + '\"');
            list.Add("Phone = \"" + textBoxPhone.Text + '\"');
            list.Add("Email = \"" + textBoxEmail.Text + '\"');
            list.Add("Website = \"" + textBoxWebsite.Text + '\"');
            string[] lines = list.ToArray();
            System.IO.File.WriteAllLines(@"C:\\ProgramData\\IDK-Software\\ImgArchive\\templates\\master_base.txt", lines);
        }
    }

   
}
