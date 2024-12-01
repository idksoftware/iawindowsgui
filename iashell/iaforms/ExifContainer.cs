using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;

namespace iaforms
{
    [DefaultPropertyAttribute("Exif")]
    public class ExifContainer
    {

        private string _SequenceId = "49818";
        private string _Filename = "Image1.jpg";
        private string _OrginalName = "Image1.jpg";
        private string _Filepath = "2003-02-04";
        private string _Uuid = "5dea74b3-ac69-c71-98ac-1e86382e1b95";
        private string _MediaType = "jpg";
        private string _Sha256 = "c5b481d8855586e798e939bc0d934b30382f3a012c0407946c75b76c932df955";
        private string _Crc = "13651013667916770286";
        private string _FileSize = "2114908";
        private string _DateCreate = "2017.04.04.07.02.56";
        private string _DateModified = "2011.10.10.19.17.28";
        private string _DateAdded = "2024.11.06.11.54.04";
        private string _Privacy = "Private";

        // Images Description Information
        private string _Description = "---";
        private string _Label = "---";
        private string _Title = "---";
        private string _Subject = "---";
        private string _Rating = "---";
        private string _RatingPercent = "---";
        private string _Tags = "---";
        private string _Keywords = "---";
        private string _Version = "---";

        private string _Comment = "This is a comment";
        private string _Author = "";
        private string _CaptureDate = "";
        private string _SubsetTimeOriginal = "";
        private string _Copyright = "";

        private string _Make = "NIKON CORPORATION";
        private string _SSN = "123545";
        private string _Model = " NIKON D800";
        private string _Width = "12345";
        private string _Height = "12345";
        private string _Orientation = " Top, left side (Horizontal / normal)";  
        private string _XResolution = " 300 dots per inch";  
        private string _YResolution = " 300 dots per inch";  
        private string _ResolutionUnit = "Inch";  
        private string _Software = "Ver.1.10";  
        private string _DateTime = "DateTime";  
        private string _YCbCrPositioning = "Datum point";  
        private string _ExposureTime = "1/125 sec";  
        private string _F_Number = "F4.5";  
        private string _ExposureProgram = "Unknown program (0)";  
        private string _ISOSpeedRatings = "100";  
        private string _ExifVersion = "2.21";  
        private string _DateTimeOriginal = "DateTimeOriginal";  
        private string _DateTimeDigitized = "DateTimeDigitized";  
        private string _ComponentsConfiguration = "YCbCr";  
        private string _CompressedBitsPerPixel = "1 bit/pixel";  
        private string _ExposureBiasValue = "0 EV";  
        private string _MaxApertureValue = "F4.4";  
        private string _MeteringMode = "Multi-segment";  
        private string _LightSource = "Unknown";  
        private string _Flash = "Flash fired, return detected, auto";  
        private string _FocalLength = "70.0 mm";  
        private string _UserComment = ""; 
        private string _Sub_SecTime = "50";  
        private string _Sub_SecTimeOriginal = "50";  
        private string _Sub_SecTimeDigitized = "50";  
        private string _FlashPixVersion = "1.00";  
        private string _ColorSpace = "sRGB";  
        private string _ExifImageWidth = "3872 pixels";  
        private string _ExifImageHeight = "2592 pixels";  
        private string _SensingMethod = "One-chip color area sensor";  
        private string _FileSource = "Digital Still Camera (DSC)";  
        private string _SceneType = "Directly photographed image";  
        private string _CFAPattern = "0 2 0 2 1 2 0 1";  
        private string _CustomRendered = "Normal process"; 
        private string _ExposureMode = "Auto exposure"; 
        private string _WhiteBalance = "Auto white balance";  
        private string _DigitalZoomRatio = "1";  
        private string _FocalLength35 = "105mm";  
        private string _SceneCaptureType = "Standard";  
        private string _GainControl = "None";  
        private string _Contrast = "None";  
        private string _Saturation = "None";  
        private string _Sharpness = "None";  
        private string _SubjectDistanceRange = "Unknown";  
        private string _Compression = "JPEG (old-style)";  
        private string _ThumbnailOffset = "29196 bytes";  
        private string _ThumbnailLength = "9370 bytes";  
        private string _ThumbnailData = "[9370 bytes of thumbnail data]";

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Sequence Index")]
        public string SequenceId { get { return _SequenceId; } set { _SequenceId = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Image file name in the archive")]
        public string Filename { get { return _Filename; } set { _Filename = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Orginal file name from souirce")]
        public string OrginalName { get { return _OrginalName; } set { _OrginalName = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Image file path in the archive")] 
        public string Filepath { get { return _Filepath; } set { _Filepath = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Universally Unique Identifier is a 128-bit label used to uniquely identify the image")]
        public string Uuid { get { return _Uuid; } set { _Uuid = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Type of image media i.e. JPG or a RAW type")]
        public string MediaType { get { return _MediaType; } set { _MediaType = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Secure 256-bit Hash Algorithm used to uniquely finger print the image")]
        public string Sha256 { get { return _Sha256; } set { _Sha256 = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Universally Unique Identifier is a 128-bit label used to uniquely identify  \ncyclic redundancy check error-detecting code used to detect accidental changes to digital data used to validate the integrity of the image")]
        public string Crc { get { return _Crc; } set { _Crc = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Size of the image file")]
        public string FileSize { get { return _FileSize; } set { _FileSize = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Time and date the image was created")]
        public string DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Time and date the image was modified")]
        public string DateModified { get { return _DateModified; } set { _DateModified = value; } }

        [CategoryAttribute("File"), DescriptionAttribute("Time and date the image was added to the archive")]
        public string DateAdded { get { return _DateAdded; } set { _DateAdded = value; } }

        [CategoryAttribute("File"), DescriptionAttribute("Privacy - Public or Private")]
        public string Privacy { get { return _Privacy; } set { _Privacy = value; } }

        // Images Description Information
        [CategoryAttribute("Description"), DescriptionAttribute("---")]
        public string Description { get { return _Description; } set { _Description = value; }}
        [CategoryAttribute("Description"), DescriptionAttribute("---")]
        public string Label { get { return _Label; } set { _Label = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("---")]
        public string Title { get { return _Title; } set { _Title = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("---")]
        public string Subject { get { return _Subject; } set { _Subject = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("---")]
        public string Rating { get { return _Rating; } set { _Rating = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("---")]
        public string RatingPercent { get { return _RatingPercent; } set { _RatingPercent = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("---")]
        public string Tags { get { return _Tags; } set { _Tags = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("---")] 
        public string Keywords { get { return _Keywords; } set { _Keywords = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("---")]
        public string Version { get { return _Version; } set { _Version = value; } }
    



// Name property with category attribute and 
// description attribute added 
[CategoryAttribute("Camera"), ReadOnly(true), DescriptionAttribute("Make of camera")]
        public string Make { get { return _Make; } set { _Make = value; } }

        [CategoryAttribute("Camera"), ReadOnly(true), DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Model { get { return _Model; } set { _Model = value; } }

        [CategoryAttribute("Exif"), ReadOnly(true),
         DescriptionAttribute("Orientation")]
        public string Width { get { return _Width; } set { _Width = value; } }

        [CategoryAttribute("Exif"), ReadOnly(true),
         DescriptionAttribute("Orientation")]
        public string Height { get { return _Height; } set { _Height = value; } }

        [CategoryAttribute("Exif"), ReadOnly(true),
        DescriptionAttribute("Orientation")]
        public string Orientation { get { return _Orientation; } set { _Orientation = value; } }

        [CategoryAttribute("Exif"), ReadOnly(true),
        DescriptionAttribute("XResolution")]
        public string XResolution { get { return _XResolution; } set { _XResolution = value; } }

        [CategoryAttribute("Exif"), ReadOnly(true),
        DescriptionAttribute("YResolution")]
        public string YResolution { get { return _YResolution; } set { _YResolution = value; } }

        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ResolutionUnit { get { return _ResolutionUnit; } set { _ResolutionUnit = value; } }

        [CategoryAttribute("Exif"), ReadOnly(true),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Software { get { return _Software; } set { _Software = value; } }

        [CategoryAttribute("Date Time"), ReadOnly(true),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string DateTime { get { return _DateTime; } set { _DateTime = value; } }

        [CategoryAttribute("Exif"), ReadOnly(true),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string YCbCrPositioning { get { return _YCbCrPositioning; } set { _YCbCrPositioning = value; } }

        [CategoryAttribute("Settings"), ReadOnly(true),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ExposureTime { get { return _ExposureTime; } set { _ExposureTime = value; } }

        [CategoryAttribute("Settings"), ReadOnly(true),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string F_Number { get { return _F_Number; } set { _F_Number = value; } }

        [CategoryAttribute("Settings"), ReadOnly(true),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ExposureProgram
        {
            get
            {
                return _ExposureProgram;
            }
            set
            {
                _ExposureProgram = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ISOSpeedRatings
        {
            get
            {
                return _ISOSpeedRatings;
            }
            set
            {
                _ISOSpeedRatings = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ExifVersion
        {
            get
            {
                return _ExifVersion;
            }
            set
            {
                _ExifVersion = value;
            }
        }
        [CategoryAttribute("Date Time"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string DateTimeOriginal
        {
            get
            {
                return _DateTimeOriginal;
            }
            set
            {
                _DateTimeOriginal = value;
            }
        }
        [CategoryAttribute("Date Time"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string DateTimeDigitized
        {
            get
            {
                return _DateTimeDigitized;
            }
            set
            {
                _DateTimeDigitized = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ComponentsConfiguration
        {
            get
            {
                return _ComponentsConfiguration;
            }
            set
            {
                _ComponentsConfiguration = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string CompressedBitsPerPixel
        {
            get
            {
                return _CompressedBitsPerPixel;
            }
            set
            {
                _CompressedBitsPerPixel = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ExposureBiasValue
        {
            get
            {
                return _ExposureBiasValue;
            }
            set
            {
                _ExposureBiasValue = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string MaxApertureValue
        {
            get
            {
                return _MaxApertureValue;
            }
            set
            {
                _MaxApertureValue = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string MeteringMode
        {
            get
            {
                return _MeteringMode;
            }
            set
            {
                _MeteringMode = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string LightSource
        {
            get
            {
                return _LightSource;
            }
            set
            {
                _LightSource = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Flash
        {
            get
            {
                return _Flash;
            }
            set
            {
                _Flash = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string FocalLength
        {
            get
            {
                return _FocalLength;
            }
            set
            {
                _FocalLength = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string UserComment
        {
            get
            {
                return _UserComment;
            }
            set
            {
                _UserComment = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Sub_SecTime
        {
            get
            {
                return _Sub_SecTime;
            }
            set
            {
                _Sub_SecTime = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Sub_SecTimeOriginal
        {
            get
            {
                return _Sub_SecTimeOriginal;
            }
            set
            {
                _Sub_SecTimeOriginal = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Sub_SecTimeDigitized
        {
            get
            {
                return _Sub_SecTimeDigitized;
            }
            set
            {
                _Sub_SecTimeDigitized = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string FlashPixVersion
        {
            get
            {
                return _FlashPixVersion;
            }
            set
            {
                _FlashPixVersion = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ColorSpace
        {
            get
            {
                return _ColorSpace;
            }
            set
            {
                _ColorSpace = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ExifImageWidth
        {
            get
            {
                return _ExifImageWidth;
            }
            set
            {
                _ExifImageWidth = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ExifImageHeight
        {
            get
            {
                return _ExifImageHeight;
            }
            set
            {
                _ExifImageHeight = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string SensingMethod
        {
            get
            {
                return _SensingMethod;
            }
            set
            {
                _SensingMethod = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string FileSource
        {
            get
            {
                return _FileSource;
            }
            set
            {
                _FileSource = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string SceneType
        {
            get
            {
                return _SceneType;
            }
            set
            {
                _SceneType = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string CFAPattern
        {
            get
            {
                return _CFAPattern;
            }
            set
            {
                _CFAPattern = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string CustomRendered
        {
            get
            {
                return _CustomRendered;
            }
            set
            {
                _CustomRendered = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ExposureMode
        {
            get
            {
                return _ExposureMode;
            }
            set
            {
                _ExposureMode = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string WhiteBalance
        {
            get
            {
                return _WhiteBalance;
            }
            set
            {
                _WhiteBalance = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string DigitalZoomRatio
        {
            get
            {
                return _DigitalZoomRatio;
            }
            set
            {
                _DigitalZoomRatio = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string FocalLength35
        {
            get
            {
                return _FocalLength35;
            }
            set
            {
                _FocalLength35 = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string SceneCaptureType
        {
            get
            {
                return _SceneCaptureType;
            }
            set
            {
                _SceneCaptureType = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string GainControl
        {
            get
            {
                return _GainControl;
            }
            set
            {
                _GainControl = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Contrast
        {
            get
            {
                return _Contrast;
            }
            set
            {
                _Contrast = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Saturation
        {
            get
            {
                return _Saturation;
            }
            set
            {
                _Saturation = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Sharpness
        {
            get
            {
                return _Sharpness;
            }
            set
            {
                _Sharpness = value;
            }
        }
        [CategoryAttribute("Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string SubjectDistanceRange
        {
            get
            {
                return _SubjectDistanceRange;
            }
            set
            {
                _SubjectDistanceRange = value;
            }
        }
        [CategoryAttribute("Exif"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string Compression
        {
            get
            {
                return _Compression;
            }
            set
            {
                _Compression = value;
            }
        }
        [CategoryAttribute("Thumbnail"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ThumbnailOffset
        {
            get
            {
                return _ThumbnailOffset;
            }
            set
            {
                _ThumbnailOffset = value;
            }
        }
        [CategoryAttribute("Thumbnail"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ThumbnailLength
        {
            get
            {
                return _ThumbnailLength;
            }
            set
            {
                _ThumbnailLength = value;
            }
        }
        [CategoryAttribute("Thumbnail"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public string ThumbnailData
        {
            get
            {
                return _ThumbnailData;
            }
            set
            {
                _ThumbnailData = value;
            }
        }        
    } 

}


/*
<Exif>
  Make NIKON CORPORATION 
  Model NIKON D80 
  Orientation Top, left side (Horizontal / normal)</Orientation> 
  XResolution 300 dots per inch</XResolution> 
  YResolution 300 dots per inch</YResolution> 
  ResolutionUnit>Inch</ResolutionUnit> 
  Software>Ver.1.10</Software> 
  DateTime>2008:03:08 18:57:50</DateTime> 
  YCbCrPositioning>Datum point</YCbCrPositioning> 
  ExposureTime>1/125 sec</ExposureTime> 
  F-Number>F4.5</F-Number> 
  ExposureProgram>Unknown program (0)</ExposureProgram> 
  ISOSpeedRatings>100</ISOSpeedRatings> 
  ExifVersion>2.21</ExifVersion> 
  DateTimeOriginal>2008:03:08 18:57:50</DateTimeOriginal> 
  DateTimeDigitized>2008:03:08 18:57:50</DateTimeDigitized> 
  ComponentsConfiguration>YCbCr</ComponentsConfiguration> 
  CompressedBitsPerPixel>1 bit/pixel</CompressedBitsPerPixel> 
  ExposureBiasValue>0 EV</ExposureBiasValue> 
  MaxApertureValue>F4.4</MaxApertureValue> 
  MeteringMode>Multi-segment</MeteringMode> 
  LightSource>Unknown</LightSource> 
  Flash>Flash fired, return detected, auto</Flash> 
  FocalLength>70.0 mm</FocalLength> 
  UserComment /> 
  Sub-SecTime>50</Sub-SecTime> 
  Sub-SecTimeOriginal>50</Sub-SecTimeOriginal> 
  Sub-SecTimeDigitized>50</Sub-SecTimeDigitized> 
  FlashPixVersion>1.00</FlashPixVersion> 
  ColorSpace>sRGB</ColorSpace> 
  ExifImageWidth>3872 pixels</ExifImageWidth> 
  ExifImageHeight>2592 pixels</ExifImageHeight> 
  SensingMethod>One-chip color area sensor</SensingMethod> 
  FileSource>Digital Still Camera (DSC)</FileSource> 
  SceneType>Directly photographed image</SceneType> 
  CFAPattern>0 2 0 2 1 2 0 1</CFAPattern> 
  CustomRendered>Normal process</CustomRendered> 
  ExposureMode>Auto exposure</ExposureMode> 
  WhiteBalance>Auto white balance</WhiteBalance> 
  DigitalZoomRatio>1</DigitalZoomRatio> 
  FocalLength35>105mm</FocalLength35> 
  SceneCaptureType>Standard</SceneCaptureType> 
  GainControl>None</GainControl> 
  Contrast>None</Contrast> 
  Saturation>None</Saturation> 
  Sharpness>None</Sharpness> 
  SubjectDistanceRange>Unknown</SubjectDistanceRange> 
  Compression>JPEG (old-style)</Compression> 
  ThumbnailOffset>29196 bytes</ThumbnailOffset> 
  ThumbnailLength>9370 bytes</ThumbnailLength> 
  ThumbnailData>[9370 bytes of thumbnail data]</ThumbnailData> 
  </Exif>
- <NikonMakernote>
  <FirmwareVersion>2.10</FirmwareVersion> 
  <ISO>ISO 100</ISO> 
  <ColorMode>COLOR</ColorMode> 
  <QualityAndFileFormat>BASIC</QualityAndFileFormat> 
  <WhiteBalance>AUTO</WhiteBalance> 
  <Sharpening>AUTO</Sharpening> 
  <AFType>AF-A</AFType> 
  <FlashSyncMode>NORMAL</FlashSyncMode> 
  <AutoFlashMode>Built-in,TTL</AutoFlashMode> 
  <WhiteBalanceFine>0</WhiteBalanceFine> 
  <WhiteBalanceRBCoefficients>506/256 310/256 256/256 256/256</WhiteBalanceRBCoefficients> 
  <AutoFlashCompensation>Unknown</AutoFlashCompensation> 
  <ISO>0 100</ISO> 
  <ToneCompensation>AUTO</ToneCompensation> 
  <Lens>18-70mm f/3.5-4.5</Lens> 
  <AFFocusPosition>Unknown (0 0 0 1)</AFFocusPosition> 
  <ColourMode>MODE3a</ColourMode> 
  <Lightsource>SPEEDLIGHT</Lightsource> 
  <CameraHueAdjustment>0 degrees</CameraHueAdjustment> 
  <NoiseReduction>OFF</NoiseReduction> 
  <ExposureSequenceNumber>4617</ExposureSequenceNumber> 
  </NikonMakernote>
- <Interoperability>
  <InteroperabilityIndex>Recommended Exif Interoperability Rules (ExifR98)</InteroperabilityIndex> 
  <InteroperabilityVersion>1.00</InteroperabilityVersion> 
  </Interoperability>
- <Jpeg>
  <DataPrecision>8 bits</DataPrecision> 
  <ImageHeight>2592 pixels</ImageHeight> 
  <ImageWidth>3872 pixels</ImageWidth> 
  <NumberOfComponents>3</NumberOfComponents> 
  <Component1>Y component: Quantization table 0, Sampling factors 1 horiz/2 vert</Component1> 
  <Component2>Cb component: Quantization table 1, Sampling factors 1 horiz/1 vert</Component2> 
  <Component3>Cr component: Quantization table 1, Sampling factors 1 horiz/1 vert</Component3> 
  </Jpeg>
*/
