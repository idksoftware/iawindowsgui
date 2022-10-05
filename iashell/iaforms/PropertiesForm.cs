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
            //labelInPrimaryStorage.Text = imageProperties.inPrimaryStorage;
            //labelCheckedStatus.Text = imageProperties.checkedStatus;
        // File
            labelFile.Text = imageProperties.originalFile;
            labelSize.Text = imageProperties.size;
            labelCRC.Text = imageProperties.crc;
            labelMD5.Text = imageProperties.sha;
            labelAddress.Text = imageProperties.filePath;
            labelMediaType.Text = imageProperties.mediaType;
            labelUUID.Text = imageProperties.uUID;
            labelDateCreated.Text = imageProperties.dateCreate;
            labelDateModified.Text = imageProperties.lastModified;
            labelDateAdded.Text = imageProperties.dateAdded;

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
            labelHeight.Text = imageProperties.height;
            labelViewRotation.Text = imageProperties.viewRotation;
            labelBitsPerSample.Text = imageProperties.bitsPerSample;
            labelXResolution.Text = imageProperties.xresolution;
            labelYResolution.Text = imageProperties.yresolution;
            labelResolutionUnit.Text = imageProperties.resolutionUnit;
            labelCompression.Text = imageProperties.compression;


            labelCameraMaker.Text = imageProperties.maker;
            labelCameraModel.Text = imageProperties.model;
            labelExposureTime.Text = imageProperties.exposureTime;
            labelAperture.Text = imageProperties.aperture;
            labelISORating.Text = imageProperties.isoSpeedRating;
            labelExposureBias.Text = imageProperties.exposureBias;
            labelExposureProgram.Text = imageProperties.exposureProgram;
            labelSubjectDistance.Text = imageProperties.subjectDistance;
            labelFocalLength.Text = imageProperties.focalLength;
            labelFocalLenghtIn35mm.Text = imageProperties.focalLenghtIn35mm;
            labelFlash.Text = imageProperties.flash;
            labelMeteringMode.Text = imageProperties.meteringMode;
            labelDigitalZoom.Text = imageProperties.digitalZoom;

            // Camera Details
            labelLightSource.Text = imageProperties.lightSource;
            labelColorSpace.Text = imageProperties.colorSpace;
            labelWhiteBalance.Text = imageProperties.whiteBalance;
            labelSceneCaptureType.Text = imageProperties.sceneCaptureType;
            labelContrast.Text = imageProperties.contrast;
            labelSaturation.Text = imageProperties.saturation;
            labelSharpness.Text = imageProperties.sharpness;
            labelBrightnessValue.Text = imageProperties.brightnessValue;
            labelSubjectDistanceRange.Text = imageProperties.subjectDistanceRange;
            labelMaxAperture.Text = imageProperties.maxAperture;
            labelCompressedBitsPerPixel.Text = imageProperties.compressedBitsPerPixel;
            labelFlashEnergy.Text = imageProperties.flashEnergy;
            labelExifVersion.Text = imageProperties.exifVersion;
            labelSoftware.Text = imageProperties.software;
            labelPhotometricInterpretation.Text = imageProperties.photometricInterpretation;
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

        
    }
}