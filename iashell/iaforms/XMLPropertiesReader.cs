using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Diagnostics;
 
namespace iaforms
{
    

    class NameValue
    {
        public String name;
        public String value;
    }

    public class ImageProperties
    {
        // AssetProperties
        //    public String revision;
        public String number;
        public String filename;
        public String originalFile;
        public String filePath;
        public String uUID;
        public String description;
        public String label;
        public String rating;
        public String ratingPercent;
        public String mediaType;
        public String sha;
        public String crc;
        public String size;
        public String dateCreate;
        public String lastModified;
        public String dateAdded;
        public String version;
        public String archiveName;
        public String title;
        public String subject;
        public String imageDate;
        public String author;
        public String hardCopyLocation;
        public String comments;
        public String latestRevision;
        public String editor;
        public String language;
        public String type;
        public String category;
        public String camera;
        public String metering;
        public String shutter;
        public String modeExp;
        public String flashMode;
        public String keywords;
        public String tags;
        public String subsetTimeOriginal;
        // Jounal
        public String timesBackedUp;
        public String inPrimaryStorage;
        public String checkedStatus;
        public String lastModifiedVersion;
        // MediaProerties
        public String width;
        public String height;
        public String xresolution;
        public String yresolution;
        public String bitsPerSample;
        public String viewRotation;
        public String resolutionUnit;
        public String sampleColor;
        public String colorSpace;
        public String compression;
        public String primaryEncoding;
        // CameraInformation
        public String maker;
        public String model;
        public String software;
        public String sourceURL;
        public String exifVersion;
        public String captureDate;
        public String exposureProgram;
        public String isoSpeedRating;
        public String exposureBias;
        public String exposureTime;
        public String aperture;
        public String meteringMode;
        public String lightSource;
        public String flash;
        public String focalLength;
        public String sensingMethod;
        public String digitalZoom;
        // GPS
        public String latitude;
        public String longitude;
        public String location;
        public String scene;
        // CopyrightProperties
        public String copyright;
        public String usageRights;
        public String copyrightURL;
    }
    
    public class XMLPropertiesReader
    {

        ImageProperties imageProperties = new ImageProperties();

        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        List<NameValue> propertiesList = null;
        NameValue currentNameValue = null;
        public XMLPropertiesReader(string fileName)
        {
            reader = new XmlTextReader(fileName);
            document.Load(fileName);
            propertiesList = new List<NameValue>();
        }
        
        public void Process()
        {
            reader.Read();
            document.Load(reader);

            XmlNodeList nodeList = document.GetElementsByTagName("File");
            for (int i = 0; i < nodeList.Count; ++i)
            {
                //Debug.Write(nodeList.Item(i).Name);
                XmlNode node = nodeList.Item(i);
                if (node.HasChildNodes)
                {

                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "SequenceId")
                        {
                            imageProperties.number = childNode.InnerText;
                        }
                        if (childNode.Name == "Filename")
                        {
                            imageProperties.filename = childNode.InnerText;
                        }
                        if (childNode.Name == "OrginalName")
                        {
                            imageProperties.originalFile = childNode.InnerText;
                        }
                        if (childNode.Name == "Filepath")
                        {
                            imageProperties.filePath = childNode.InnerText;
                        }
                        if (childNode.Name == "Uuid")
                        {
                            imageProperties.uUID = childNode.InnerText;
                        }
                        if (childNode.Name == "MediaType")
                        {
                            imageProperties.mediaType = childNode.InnerText;
                        }
                        if (childNode.Name == "Sha256")
                        {
                            imageProperties.sha = childNode.InnerText;
                        }
                        if (childNode.Name == "Crc")
                        {
                            imageProperties.crc = childNode.InnerText;
                        }
                        if (childNode.Name == "FileSize")
                        {
                            imageProperties.size = childNode.InnerText;
                        }
                        if (childNode.Name == "DateCreate")
                        {
                            imageProperties.dateCreate = childNode.InnerText;
                        }
                        if (childNode.Name == "DateModified")
                        {
                            imageProperties.lastModified = childNode.InnerText;
                        }
                        if (childNode.Name == "DateAdded")
                        {
                            imageProperties.dateAdded = childNode.InnerText;
                        }
                    }
                    
                }
                //Debug.Write(nodeList.Item(i).);
            }
            nodeList = document.GetElementsByTagName("Description");
            for (int i = 0; i < nodeList.Count; ++i)
            {
                //Debug.Write(nodeList.Item(i).Name);
                XmlNode node = nodeList.Item(i);
                if (node.HasChildNodes)
                {
                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        
                        if (childNode.Name == "Description")
                        {
                            imageProperties.description = childNode.InnerText;
                        }
                        if (childNode.Name == "Label")
                        {
                            imageProperties.label = childNode.InnerText;
                        }
                        if (childNode.Name == "Title")
                        {
                            imageProperties.title = childNode.InnerText;
                        }
                        if (childNode.Name == "Subject")
                        {
                            imageProperties.subject = childNode.InnerText;
                        }
                        if (childNode.Name == "Rating")
                        {
                            imageProperties.rating = childNode.InnerText;
                        }
                        
                        if (childNode.Name == "RatingPercent")
                        {
                            imageProperties.ratingPercent = childNode.InnerText;
                        }
                        if (childNode.Name == "Tags")
                        {
                            imageProperties.tags = childNode.InnerText;
                        }
                        if (childNode.Name == "Keywords")
                        {
                            imageProperties.keywords = childNode.InnerText;
                        }
                        if (childNode.Name == "Version")
                        {
                            imageProperties.version = childNode.InnerText;
                        }
                        
                    }
                }
                //Debug.Write(nodeList.Item(i).);
            }
            nodeList = document.GetElementsByTagName("Origin");
            for (int i = 0; i < nodeList.Count; ++i)
            {
                XmlNode node = nodeList.Item(i);
                if (node.HasChildNodes)
                {
                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "Comment")
                        {
                            imageProperties.comments = childNode.InnerText;
                        }
                        if (childNode.Name == "Author")
                        {
                            imageProperties.author = childNode.InnerText;
                        }
                        if (childNode.Name == "CaptureDate")
                        {
                            imageProperties.captureDate = childNode.InnerText;
                        }
                        if (childNode.Name == "SubsetTimeOriginal")
                        {
                            imageProperties.subsetTimeOriginal = childNode.InnerText;
                        }
                        if (childNode.Name == "Copyright")
                        {
                            imageProperties.copyright = childNode.InnerText;
                        }
                    }
                }
            }
            nodeList = document.GetElementsByTagName("Image");
            for (int i = 0; i < nodeList.Count; ++i)
            {
                XmlNode node = nodeList.Item(i);
                if (node.HasChildNodes)
                {
                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "Width")
                        {
                            imageProperties.width = childNode.InnerText;
                        }
                        if (childNode.Name == "Height")
                        {
                            imageProperties.height = childNode.InnerText;
                        }
                        if (childNode.Name == "XResolution")
                        {
                            imageProperties.xresolution = childNode.InnerText;
                        }
                        if (childNode.Name == "YResolution")
                        {
                            imageProperties.yresolution = childNode.InnerText;
                        }
                        if (childNode.Name == "BitsPerSample")
                        {
                            imageProperties.bitsPerSample = childNode.InnerText;
                        }
                        if (childNode.Name == "ViewRotation")
                        {
                            imageProperties.viewRotation = childNode.InnerText;
                        }
                        if (childNode.Name == "ResolutionUnit")
                        {
                            imageProperties.resolutionUnit = childNode.InnerText;
                        }
                        if (childNode.Name == "ColorSpace")
                        {
                            imageProperties.colorSpace = childNode.InnerText;
                        }
                        if (childNode.Name == "Compression")
                        {
                            imageProperties.compression = childNode.InnerText;
                        }
                        if (childNode.Name == "PrimaryEncoding")
                        {
                            imageProperties.primaryEncoding = childNode.InnerText;
                        }
                    }
                }
            }
            nodeList = document.GetElementsByTagName("CameraInformation");
            for (int i = 0; i < nodeList.Count; ++i)
            {
                XmlNode node = nodeList.Item(i);
                if (node.HasChildNodes)
                {
                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {

                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "Maker")
                        {
                            imageProperties.maker = childNode.InnerText;
                        }
                        if (childNode.Name == "Model")
                        {
                            imageProperties.model = childNode.InnerText;
                        }
                        if (childNode.Name == "Software")
                        {
                            imageProperties.software = childNode.InnerText;
                        }
                        if (childNode.Name == "SourceURL")
                        {
                            imageProperties.sourceURL = childNode.InnerText;
                        }
                        if (childNode.Name == "ExifVersion")
                        {
                            imageProperties.exifVersion = childNode.InnerText;
                        }
                        if (childNode.Name == "CaptureDate")
                        {
                            imageProperties.captureDate = childNode.InnerText;
                        }
                        if (childNode.Name == "ExposureProgram")
                        {
                            imageProperties.exposureProgram = childNode.InnerText;
                        }
                        if (childNode.Name == "ISOSpeedRating")
                        {
                            imageProperties.isoSpeedRating = childNode.InnerText;
                        }
                        if (childNode.Name == "ExposureBias")
                        {
                            imageProperties.exposureBias = childNode.InnerText;
                        }
                        if (childNode.Name == "ExposureTime")
                        {
                            imageProperties.exposureTime = childNode.InnerText;
                        }
                        if (childNode.Name == "Aperture")
                        {
                            imageProperties.aperture = childNode.InnerText;
                        }
                        if (childNode.Name == "MeteringMode")
                        {
                            imageProperties.meteringMode = childNode.InnerText;
                        }
                        if (childNode.Name == "LightSource")
                        {
                            imageProperties.lightSource = childNode.InnerText;
                        }
                        if (childNode.Name == "Flash")
                        {
                            imageProperties.flash = childNode.InnerText;
                        }
                        if (childNode.Name == "FocalLength")
                        {
                            imageProperties.focalLength = childNode.InnerText;
                        }
                        if (childNode.Name == "SensingMethod")
                        {
                            imageProperties.sensingMethod = childNode.InnerText;
                        }
                        if (childNode.Name == "DigitalZoom")
                        {
                            imageProperties.digitalZoom = childNode.InnerText;
                        }
                    }
                }
            }
            nodeList = document.GetElementsByTagName("Location");
            for (int i = 0; i < nodeList.Count; ++i)
            {
                //Debug.Write(nodeList.Item(i).Name);
                XmlNode node = nodeList.Item(i);
                if (node.HasChildNodes)
                {
                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "Latitude")
                        {
                            imageProperties.latitude = childNode.InnerText;
                        }
                        if (childNode.Name == "Longitude")
                        {
                            imageProperties.longitude = childNode.InnerText;
                        }
                        if (childNode.Name == "Location")
                        {
                            imageProperties.location = childNode.InnerText;
                        }
                        if (childNode.Name == "Scene")
                        {
                            imageProperties.scene = childNode.InnerText;
                        }
                    }
                    /*
                     <Latitude>Latitude</Latitude>
<Longitude>Longitude</Longitude>
<Location>Location</Location>
<Scene>The scene in the image</Scene>
                    */
                }
            }
            nodeList = document.GetElementsByTagName("CopyrightProperties");
            for (int i = 0; i < nodeList.Count; ++i)
            {
                //Debug.Write(nodeList.Item(i).Name);
                XmlNode node = nodeList.Item(i);
                if (node.HasChildNodes)
                {
                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "Copyright")
                        {
                            imageProperties.copyright = childNode.InnerText;
                        }
                        if (childNode.Name == "UsageRights")
                        {
                            imageProperties.usageRights = childNode.InnerText;
                        }
                        if (childNode.Name == "CopyrightURL")
                        {
                            imageProperties.copyrightURL = childNode.InnerText;
                        }
                    }
                }
            } 



        }
        public XmlDocument XMLDocument { get { return document; } }
        public ImageProperties ImageProperties { get { return imageProperties; } }
    }
}
