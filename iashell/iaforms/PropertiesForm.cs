using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;
using System.Diagnostics;
using System.Xml;
using System.Xml.XPath;


namespace iaforms
{
    public partial class PropertiesForm : Form
    {
        public XMLPropertiesReader xmlPropertiesReader = null;
        public ImageProperties imageProperties = null;
        public XmlDocument document = null;
        public String imageFilename;

        public PropertiesForm(string fn)
        {
            InitializeComponent();
            string fName = Path.GetFileName(fn);
            string fpath = Path.GetDirectoryName(fn);
            string filename = fpath + "\\.imga\\metadata\\" + fName + ".xml";

            imageFilename = fn;

            FileInfo fileInfo = new FileInfo(filename);
            string name = Path.GetFileNameWithoutExtension(filename);

            this.Text = name + " Properties";
            if (fileInfo.Exists == false)
            {
                MessageBox.Show("File \"" + fileInfo.Name + "\" not found", "ImgAchive Properties");
                return;
            }    
            String ext = fileInfo.Extension;
            string filenameOnly = fileInfo.Name;
            if (ext.Equals(".lnk"))
            {
                //FileStream fileStream = fileInfo.Open(FileMode.Open);
                //ileStream.
                WshShell shell = new WshShell();
                String p = fileInfo.ToString();
                IWshShortcut link = (IWshShortcut)shell.CreateShortcut(p);
               
                FileInfo doesItExist = new FileInfo(link.TargetPath);
                if (doesItExist.Exists == false)
                {
                    MessageBox.Show("File \"" + fileInfo.Name + "\" not found", "ImgAchive Propertes");
                    return;
                }    
                xmlPropertiesReader = new XMLPropertiesReader(link.TargetPath);
                xmlPropertiesReader.Process();
                imageProperties = xmlPropertiesReader.ImageProperties;
                document = xmlPropertiesReader.XMLDocument;
               
            }
            else if (ext.Equals(".xml"))
            {
                XMLPropertiesReader xmlPropertiesReader = new XMLPropertiesReader(fileInfo.FullName);
                xmlPropertiesReader.Process();
                imageProperties = xmlPropertiesReader.ImageProperties;
                document = xmlPropertiesReader.XMLDocument;
            }
            else
            {
                return;
            }
            
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);

            Size newSize = new Size(destWidth, destHeight);

            return (Image)(new Bitmap(imgToResize, newSize));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ExifContainer exifContainer = new ExifContainer();
            exifPropertyGrid.SelectedObject = exifContainer;
            //timerRefresh.Start();
            LoadTagList();
            LoadKeywordList();
            labelImage.Text = imageProperties.filePath + '\\' + imageProperties.originalFile;
            labelImageDetails.Text = imageProperties.filePath + '\\' + imageProperties.originalFile;
            labelImageCamera.Text = imageProperties.filePath + '\\' + imageProperties.originalFile;
            labelImageIPTC.Text = imageProperties.filePath + '\\' + imageProperties.originalFile;
            labelNumber.Text = imageProperties.number;
            string version = (Int16.Parse(imageProperties.version) == 0) ? "Inital" : imageProperties.version;
            labelRevision.Text = version;
            // Jounal
            //labelTimesBackedUp.Text = imageProperties.timesBackedUp;
            //labelInPrimaryStpublic String number;

            //labelCheckedStatus.Text = imageProperties.checkedStatus;
            // File
            /*
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
            public String dateAdded; orage.Text = imageProperties.inPrimaryStorage;
             */
            exifContainer.SequenceId = imageProperties.number;

            labelFile.Text = imageProperties.originalFile;

            labelSize.Text = imageProperties.size;
            exifContainer.FileSize = imageProperties.size;
            labelCRC.Text = imageProperties.crc;
            exifContainer.Crc = imageProperties.crc;
            labelMD5.Text = imageProperties.sha;
            exifContainer.Sha256 = imageProperties.sha;
            labelAddress.Text = imageProperties.filePath;
            exifContainer.Filepath = imageProperties.filePath;
            labelMediaType.Text = imageProperties.mediaType;
            exifContainer.MediaType = imageProperties.mediaType;
            labelUUID.Text = imageProperties.uUID;
            exifContainer.Uuid = imageProperties.uUID;
            labelDateCreated.Text = imageProperties.dateCreate;
            exifContainer.DateCreate = imageProperties.dateCreate;
            labelDateModified.Text = imageProperties.lastModified;
            exifContainer.DateModified = imageProperties.lastModified;
            labelDateAdded.Text = imageProperties.dateAdded;
            exifContainer.DateAdded = imageProperties.dateAdded;

            // Details
            labelTitle.Text = imageProperties.title;
            labelDescription.Text = imageProperties.description;
            labelSubject.Text = imageProperties.subject;
            labelViewRotation.Text = imageProperties.imageDate;
            labelLabel.Text = imageProperties.label;
            labelRating.Text = imageProperties.rating;
            labelRatingPercent.Text = imageProperties.ratingPercent;
            labelTitle.Text = imageProperties.title;
            //labelHardcopyLocation.Text = imageProperties.hardCopyLocation;
            labelComments.Text = imageProperties.comments;
            //labelHeight.Text = imageProperties.editor;
            //labelrunit.Text = imageProperties.language;
            labelAuthor.Text = imageProperties.author;
            //labelTitle.Text = imageProperties.keywords;
            //labeType.Text = imageProperties.type;
            //labelTitle.Text = imageProperties.tags;
            

            labelWidth.Text = imageProperties.width;
            exifContainer.Width = imageProperties.width;
            labelHeight.Text = imageProperties.height;
            exifContainer.Height = imageProperties.height;
            labelViewRotation.Text = imageProperties.viewRotation;
            exifContainer.Orientation = imageProperties.viewRotation;
            labelBitsPerSample.Text = imageProperties.bitsPerSample;
            exifContainer.CompressedBitsPerPixel = imageProperties.bitsPerSample;
            labelXResolution.Text = imageProperties.xresolution;
            exifContainer.XResolution = imageProperties.width;
            labelYResolution.Text = imageProperties.yresolution;
            exifContainer.YResolution = imageProperties.height;
            labelResolutionUnit.Text = imageProperties.resolutionUnit;
            exifContainer.ResolutionUnit = imageProperties.resolutionUnit;
            labelCompression.Text = imageProperties.compression;
            exifContainer.Compression = imageProperties.compression;

            labelCameraMaker.Text = imageProperties.maker;
            exifContainer.Make = imageProperties.maker;
            labelCameraModel.Text = imageProperties.model;
            exifContainer.Model = imageProperties.model;
            labelExposureTime.Text = imageProperties.exposureTime;
            exifContainer.ExposureTime = imageProperties.exposureTime;
            labelAperture.Text = imageProperties.aperture;
            exifContainer.F_Number = imageProperties.aperture;
            labelISORating.Text = imageProperties.isoSpeedRating;
            exifContainer.ISOSpeedRating = imageProperties.isoSpeedRating;
            labelExposureBias.Text = imageProperties.exposureBias;
            exifContainer.ExposureBiasValue = imageProperties.exposureBias;
            labelExposureProgram.Text = imageProperties.exposureProgram;
            exifContainer.ExposureProgram = imageProperties.exposureProgram;
            labelSubjectDistance.Text = imageProperties.subjectDistance;
            exifContainer.SubjectDistance = imageProperties.subjectDistance;
            labelFocalLength.Text = imageProperties.focalLength;
            exifContainer.FocalLength = imageProperties.focalLength;
            labelFocalLenghtIn35mm.Text = imageProperties.focalLenghtIn35mm;
            exifContainer.FocalLength35 = imageProperties.focalLenghtIn35mm;
            labelFlash.Text = imageProperties.flash;
            exifContainer.Flash = imageProperties.flash;
            labelMeteringMode.Text = imageProperties.meteringMode;
            exifContainer.MeteringMode = imageProperties.meteringMode;
            labelDigitalZoom.Text = imageProperties.digitalZoom;
            exifContainer.DigitalZoomRatio = imageProperties.digitalZoom;

            exifContainer.UserComment = imageProperties.comments;
            exifContainer.Author = imageProperties.author;
            exifContainer.CaptureDate = imageProperties.captureDate;
            exifContainer.SubsetTimeOriginal = imageProperties.subsetTimeOriginal;
            exifContainer.Copyright = imageProperties.copyright;

            exifContainer.BitsPerSample = imageProperties.bitsPerSample;
            


            labelLightSource.Text = imageProperties.lightSource;
            exifContainer.LightSource = imageProperties.lightSource;
            labelColorSpace.Text = imageProperties.colorSpace;
            exifContainer.ColorSpace = imageProperties.colorSpace;
            labelWhiteBalance.Text = imageProperties.whiteBalance;
            exifContainer.WhiteBalance = imageProperties.whiteBalance;
            labelSceneCaptureType.Text = imageProperties.sceneCaptureType;
            exifContainer.SceneCaptureType = imageProperties.sceneCaptureType;
            labelContrast.Text = imageProperties.contrast;
            exifContainer.Contrast = imageProperties.contrast;
            labelSaturation.Text = imageProperties.saturation;
            exifContainer.Saturation = imageProperties.saturation;
            labelSharpness.Text = imageProperties.sharpness;
            exifContainer.Sharpness = imageProperties.sharpness;
            labelBrightnessValue.Text = imageProperties.brightnessValue;
            exifContainer.BrightnessValue = imageProperties.brightnessValue;
            labelSubjectDistanceRange.Text = imageProperties.subjectDistanceRange;
            exifContainer.SubjectDistanceRange = imageProperties.subjectDistanceRange;
            labelMaxAperture.Text = imageProperties.maxAperture;
            exifContainer.MaxApertureValue = imageProperties.maxAperture;
            labelCompressedBitsPerPixel.Text = imageProperties.compressedBitsPerPixel;
            exifContainer.CompressedBitsPerPixel = imageProperties.compressedBitsPerPixel;
            labelFlashEnergy.Text = imageProperties.flashEnergy;
            exifContainer.FlashEnergy = imageProperties.flashEnergy;
            labelExifVersion.Text = imageProperties.exifVersion;
            exifContainer.ExifVersion = imageProperties.exifVersion;
            labelSoftware.Text = imageProperties.software;
            exifContainer.Software = imageProperties.software;
            labelPhotometricInterpretation.Text = imageProperties.photometricInterpretation;
            exifContainer.PhotometricInterpretation = imageProperties.photometricInterpretation;

            exifContainer.Latitude = imageProperties.latitude;
            exifContainer.Longitude = imageProperties.longitude;
            exifContainer.Location = imageProperties.location;
            exifContainer.Scene = imageProperties.scene;

            /*
              <SourceUrl/>
        <UsageRights/>
        <CopyrightUrl/>
        <Headline/>
        <Category/>
        <Source/>
        <Instructions/>
        <Creator/>
        <JobTitle/>
        <Address/>
        <City/>
        <State/>
        <PostalCode/>
        <Country/>
        <Phone/>
        <Email/>
        <Website/>
        </IPTC>
             */
            exifContainer.SourceUrl = imageProperties.sourceUrl;
            exifContainer.UsageRights = imageProperties.usageRights;
            exifContainer.CopyrightUrl = imageProperties.copyrightUrl;
            exifContainer.Headline = imageProperties.headline;
            exifContainer.Category = imageProperties.category;
            exifContainer.Source = imageProperties.source;
            exifContainer.Instructions = imageProperties.instructions;
            exifContainer.Creator = imageProperties.creator;
            exifContainer.JobTitle = imageProperties.jobTitle;
            exifContainer.Address = imageProperties.address;
            exifContainer.City = imageProperties.city;
            exifContainer.State = imageProperties.state;
            exifContainer.PostalCode = imageProperties.postalCode;
            exifContainer.Country = imageProperties.country;
            exifContainer.Phone = imageProperties.phone;
            exifContainer.Email = imageProperties.email;
            exifContainer.Website = imageProperties.website;

            labelGpsTimeStamp.Text = imageProperties.gpsTimeStamp;

            labelCameraMaker.Text = imageProperties.camera;
            labelExposureProgram.Text = imageProperties.metering;
            //labelShutter.Text = imageProperties.shutter;
            labelExposureTime.Text = imageProperties.aperture;
            labelAperture.Text = imageProperties.modeExp;
            labelISORating.Text = imageProperties.focalLength;
            labelExposureBias.Text = imageProperties.flashMode;

            // Location
            labelLatitude.Text = imageProperties.latitude;
            labelLongitude.Text = imageProperties.longitude;
            labelLocation.Text = imageProperties.location;
            labelScene.Text = imageProperties.scene;

            // IPTC

            labelSourceUrl.Text = imageProperties.sourceUrl;
            labelUsageRights.Text = imageProperties.usageRights;
            labelCopyrightUrl.Text = imageProperties.copyrightUrl;
            labelHeadline.Text = imageProperties.headline;
            labelCategory.Text = imageProperties.category;
            labelSource.Text = imageProperties.source;
            labelInstructions.Text = imageProperties.instructions;
            labelCreator.Text = imageProperties.creator;
            labelJobTitle.Text = imageProperties.jobTitle;
            labelLocationAddress.Text = imageProperties.address;
            labelCity.Text = imageProperties.city;
            labelState.Text = imageProperties.state;
            labelPostCode.Text = imageProperties.postalCode;
            labelCountry.Text = imageProperties.country;
            labelPhone.Text = imageProperties.phone;
            labelEmail.Text = imageProperties.email;
            labelWebsite.Text = imageProperties.website;

            exifContainer.Make = "Sony";

            try
            {
               
                //Image img = Image.FromFile(@"E:\workspace\2017\2017-07-15\_8005649_00001L.JPG");
                Image img = Image.FromFile(imageFilename);
                Bitmap imgbitmap = new Bitmap(img);
                Image resizedImage = resizeImage(imgbitmap, new Size(previewPage.Width, previewPage.Height));
                previewPage.BackgroundImageLayout = ImageLayout.Center;
                previewPage.BackgroundImage = resizedImage;
            } catch {
                tabControlMain.TabPages.Remove(previewPage);
            }


        }

        private void buttonTagChange_Click(object sender, EventArgs e)
        {
            XmlDocument newDocument = (XmlDocument)document.Clone();
            ChangeTagForm form = new ChangeTagForm(newDocument);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                document = newDocument;
                tagListBox.Items.Clear();
                LoadTagList();
            }
            else
            {
                return;
            }
        }

        private void buttonKeywordsChange_Click(object sender, EventArgs e)
        {
            XmlDocument newDocument = (XmlDocument)document.Clone();
            ChangeKeywordForm form = new ChangeKeywordForm(newDocument);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                document = newDocument;
                keywordListBox.Items.Clear();
                LoadKeywordList();
            }
            else
            {
                return;
            }
        }

            

        private void LoadTagList()
        {
            XmlNodeList nodeList = document.GetElementsByTagName("Tags");
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
                        tagListBox.Items.Add(childNode.InnerText);
                    }
                }

            }
        }

        private void LoadKeywordList()
        {
            XmlNodeList nodeList = document.GetElementsByTagName("Keywords");
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
                        keywordListBox.Items.Add(childNode.InnerText);
                    }
                }

            }
        }

       

        private void buttonChangeDetails_Click(object sender, EventArgs e)
        {
            XmlDocument newDocument = (XmlDocument)document.Clone();
            ChangeDetailsForm form = new ChangeDetailsForm(newDocument);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                document = newDocument;
                labelViewRotation.Text = form.ImageDate;
                labelViewRotation.Text = form.Author;
                labelRating.Text = form.LatestRevision;
                //labelHardcopyLocation.Text = form.HardCopyLocation;
                labelCategory.Text = form.Category;
                labelComments.Text = form.Comments;
                labelHeight.Text = form.Editor;
                //labelrunit.Text = form.Language;
                //labeType.Text = form.Type;
                
                //LoadKeywordList();
            }
            else
            {
                return;
            }
        }

        private void buttonChangeTitle_Click(object sender, EventArgs e)
        {
            XmlDocument newDocument = (XmlDocument)document.Clone();
            ChangeTitleForm form = new ChangeTitleForm(newDocument);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                document = newDocument;
                labelTitle.Text = form.Title;
                labelSubject.Text = form.Subject;
            }
            else
            {
                return;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            XmlDocument newDocument = (XmlDocument)document.Clone();
            CameraChangeForm form = new CameraChangeForm(newDocument);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                document = newDocument;
            }
            else
            {
                return;
            }
        }

        public static void GetAddress(string path, out string address)
        {
            string firstPart;
            string addressPart;
            addressPart = path.Substring(0, path.LastIndexOf('\\'));
            firstPart = addressPart.Substring(0, addressPart.LastIndexOf('\\'));

            address = path.Substring(addressPart.Length + 1, 10);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            /*
            file = item.SubItems[0].Text;
            string path = item.SubItems[4].Text;
            //string fullPath = path + "\\.imga\\metadata\\" + file + ".xml";
            fullPath = path + "\\" + file;
            */
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            string fName = Path.GetFileName(imageFilename);
            string fpath = Path.GetDirectoryName(imageFilename);
            string address;
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            GetAddress(fpath, out address);
            (new LogForm(address, fName, exePath, workPath)).Show();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            exifPropertyGrid.Refresh();
        }
    }
}