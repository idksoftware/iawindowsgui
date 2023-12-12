using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace iaforms
{
    public class TemplateObject
    {
        public string TemplateName { get; set; }
        public string Description { get; set; }
        public string Label { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Rating { get; set; }
        public string RatingPercent { get; set; }
        public string Tags { get; set; }
        public string Keywords { get; set; }
        // Origin
        public string Comment { get; set; }
        public string Author { get; set; }

        // Cammara
        public string Copyright { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }

        // Location
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Location { get; set; }
        public string Scene { get; set; }

        // IPTC
        public string SourceURL { get; set; }
        public string UsageRights { get; set; }
        public string CopyrightURL { get; set; }
        public string Headline { get; set; }
        public string Category { get; set; }
        public string Source { get; set; }
        public string Instructions { get; set; }

        public string Creator { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
    public class XMLTemplate
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        TemplateObject templateObject = null;
        public XMLTemplate(string xmlString)
        {
            //reader = new XmlTextReader(fileName);
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

            MemoryStream stream = new MemoryStream(byteArray);
            document.Load(stream);
            templateObject = new TemplateObject();
        }

        public TemplateObject TemplateObject { get => templateObject; }
        public void Process()
        {
            /*
             <?xml version="1.0" encoding="UTF-8"?>
            <MasterTemplate>
                <TemplateType>Current</TemplateType>
                <Template>
                    
                    <Maker>Sony</Maker>
                    <Model/>
                    <Latitude/>
                    <Longitude/>
                    <Location/>
                    <Scene>The scene in the image</Scene>
                    <SourceUrl>Some Text</SourceUrl>
                    <UsageRights>Private</UsageRights>
                    <CopyrightUrl>IainFerguson@idk.co.uk</CopyrightUrl>
                    <Headline>Headline here</Headline>
                    <Category>The category of the image</Category>
                    <Source>Source of image</Source>
                    <Instructions>Some Instructions</Instructions>
                    <Creator>The creater</Creator>
                    <JobTitle>Your Job title</JobTitle>
                    <Address>Your addess`</Address>
                    <City>Your City</City>
                    <State>Your state</State>
                    <PostalCode>Your Post code</PostalCode>
                    <Country>Your Country</Country>
                    <Phone>Your Phone</Phone>
                    <Email>Your@Email.com</Email>
                    <Website>www.YourWebsite.com</Website>
                </Template>
            </MasterTemplate>

             */


            XmlNodeList rootList = document.GetElementsByTagName("MasterTemplate");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNode node = rootList.Item(i); // Image node
                if (node.HasChildNodes)
                {
                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "TemplateType")
                        {
                            templateObject.TemplateName = childNode.InnerText;
                        }
                        if (childNode.Name == "Template")
                        {
                            if (childNode.HasChildNodes)
                            {
                                XmlNodeList templateNodeList = childNode.ChildNodes;
                                for (int n = 0; n < templateNodeList.Count; n++)
                                {
                                    childNode = templateNodeList.Item(n);
                                    if (childNode.Name == "Description")
                                    {
                                        templateObject.Description = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Label")
                                    {
                                        templateObject.Label = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Title")
                                    {
                                        templateObject.Title = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Subject")
                                    {
                                        templateObject.Subject = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Rating")
                                    {
                                        templateObject.Rating = childNode.InnerText;
                                    }
                                    if (childNode.Name == "RatingPercent")
                                    {
                                        templateObject.RatingPercent = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Tags")
                                    {
                                        templateObject.Tags = childNode.InnerText;
                                    }

                                    if (childNode.Name == "Keywords")
                                    {
                                        templateObject.Keywords = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Comment")
                                    {
                                        templateObject.Comment = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Author")
                                    {
                                        templateObject.Author = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Copyright")
                                    {
                                        templateObject.Copyright = childNode.InnerText;
                                    }

                                    if (childNode.Name == "Maker")
                                    {
                                        templateObject.Maker = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Model")
                                    {
                                        templateObject.Model = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Latitude")
                                    {
                                        templateObject.Latitude = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Longitude")
                                    {
                                        templateObject.Longitude = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Location")
                                    {
                                        templateObject.Location = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Scene")
                                    {
                                        templateObject.Scene = childNode.InnerText;
                                    }
                                    if (childNode.Name == "SourceUrl")
                                    {
                                        templateObject.SourceURL = childNode.InnerText;
                                    }
                                    if (childNode.Name == "UsageRights")
                                    {
                                        templateObject.UsageRights = childNode.InnerText;
                                    }

                                    if (childNode.Name == "CopyrightUrl")
                                    {
                                        templateObject.CopyrightURL = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Headline")
                                    {
                                        templateObject.Headline = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Category")
                                    {
                                        templateObject.Category = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Source")
                                    {
                                        templateObject.Source = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Instructions")
                                    {
                                        templateObject.Instructions = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Creator")
                                    {
                                        templateObject.Creator = childNode.InnerText;
                                    }
                                    if (childNode.Name == "JobTitle")
                                    {
                                        templateObject.JobTitle = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Address")
                                    {
                                        templateObject.Address = childNode.InnerText;
                                    }
                                    if (childNode.Name == "City")
                                    {
                                        templateObject.City = childNode.InnerText;
                                    }

                                    if (childNode.Name == "State")
                                    {
                                        templateObject.State = childNode.InnerText;
                                    }
                                    if (childNode.Name == "PostalCode")
                                    {
                                        templateObject.PostalCode = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Country")
                                    {
                                        templateObject.Country = childNode.InnerText;
                                    }

                                    if (childNode.Name == "Phone")
                                    {
                                        templateObject.Phone = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Email")
                                    {
                                        templateObject.Email = childNode.InnerText;
                                    }
                                    if (childNode.Name == "Website")
                                    {
                                        templateObject.Website = childNode.InnerText;
                                    }
                                }
                            }
                        }
                    }
                }
                
                /*
                node = rootList.Item(i); // Image node
                if (node.HasChildNodes)
                {

                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "Description")
                        {
                            templateObject.Description = childNode.InnerText;
                        }
                        if (childNode.Name == "Label")
                        {
                            templateObject.Label = childNode.InnerText;
                        }
                        if (childNode.Name == "Title")
                        {
                            templateObject.Title = childNode.InnerText;
                        }
                        if (childNode.Name == "Subject")
                        {
                            templateObject.Subject = childNode.InnerText;
                        }
                        if (childNode.Name == "Rating")
                        {
                            templateObject.Rating = childNode.InnerText;
                        }
                        if (childNode.Name == "RatingPercent")
                        {
                            templateObject.RatingPercent = childNode.InnerText;
                        }
                        if (childNode.Name == "Tags")
                        {
                            templateObject.Tags = childNode.InnerText;
                        }
                        
                        if (childNode.Name == "Keywords")
                        {
                            templateObject.Keywords = childNode.InnerText;
                        }
                        if (childNode.Name == "Comment")
                        {
                            templateObject.Comment = childNode.InnerText;
                        }
                        if (childNode.Name == "Author")
                        {
                            templateObject.Author = childNode.InnerText;
                        }
                        if (childNode.Name == "Copyright")
                        {
                            templateObject.Copyright = childNode.InnerText;
                        }
                        
                        if (childNode.Name == "Maker")
                        {
                            templateObject.Maker = childNode.InnerText;
                        }
                        if (childNode.Name == "Model")
                        {
                            templateObject.Model = childNode.InnerText;
                        }
                        if (childNode.Name == "Latitude")
                        {
                            templateObject.Latitude = childNode.InnerText;
                        }
                        if (childNode.Name == "Longitude")
                        {
                            templateObject.Longitude = childNode.InnerText;
                        }
                        if (childNode.Name == "Location")
                        {
                            templateObject.Location = childNode.InnerText;
                        }
                        if (childNode.Name == "Scene")
                        {
                            templateObject.Scene = childNode.InnerText;
                        }
                        if (childNode.Name == "SourceUrl")
                        {
                            templateObject.SourceURL = childNode.InnerText;
                        }
                        if (childNode.Name == "UsageRights")
                        {
                            templateObject.UsageRights = childNode.InnerText;
                        }
                        
                        if (childNode.Name == "CopyrightUrl")
                        {
                            templateObject.CopyrightURL = childNode.InnerText;
                        }
                        if (childNode.Name == "Headline")
                        {
                            templateObject.Headline = childNode.InnerText;
                        }
                        if (childNode.Name == "Category")
                        {
                            templateObject.Category = childNode.InnerText;
                        }
                        if (childNode.Name == "Source")
                        {
                            templateObject.Source = childNode.InnerText;
                        }
                        if (childNode.Name == "Instructions")
                        {
                            templateObject.Instructions = childNode.InnerText;
                        }
                        if (childNode.Name == "Creator")
                        {
                            templateObject.Creator = childNode.InnerText;
                        }
                        if (childNode.Name == "JobTitle")
                        {
                            templateObject.JobTitle = childNode.InnerText;
                        }
                        if (childNode.Name == "Address")
                        {
                            templateObject.Address = childNode.InnerText;
                        }
                        if (childNode.Name == "City")
                        {
                            templateObject.City = childNode.InnerText;
                        }
                      
                        if (childNode.Name == "State")
                        {
                            templateObject.State = childNode.InnerText;
                        }
                        if (childNode.Name == "PostalCode")
                        {
                            templateObject.PostalCode = childNode.InnerText;
                        }
                        if (childNode.Name == "Country")
                        {
                            templateObject.Country = childNode.InnerText;
                        }
                        
                        if (childNode.Name == "Phone")
                        {
                            templateObject.Phone = childNode.InnerText;
                        }
                        if (childNode.Name == "Email")
                        {
                            templateObject.Email = childNode.InnerText;
                        }
                        if (childNode.Name == "Website")
                        {
                            templateObject.Website = childNode.InnerText;
                        }
                    }
                }

                */
            }
        }
    }
}


