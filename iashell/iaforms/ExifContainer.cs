using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;

namespace iaforms
{

    public enum MeteringModeValues : byte
    {
        PHOTO_METERINGMODE_UNKNOWN = 0,
        PHOTO_METERINGMODE_AVERAGE,
        PHOTO_METERINGMODE_CENTER,
        PHOTO_METERINGMODE_SPOT,
        PHOTO_METERINGMODE_MULTISPOT,
        PHOTO_METERINGMODE_PATTERN,
        PHOTO_METERINGMODE_PARTIAL

    };

    public enum ViewOrientation : byte
    {
        PHOTO_ORIENTATION_UNKOWN = 0,
        PHOTO_ORIENTATION_NORMAL,
        PHOTO_ORIENTATION_FLIPHORIZONTAL,
        PHOTO_ORIENTATION_ROTATE180,
        PHOTO_ORIENTATION_FLIPVERTICAL,
        PHOTO_ORIENTATION_TRANSPOSE,
        PHOTO_ORIENTATION_ROTATE270,
        PHOTO_ORIENTATION_TRANSVERSE,
        PHOTO_ORIENTATION_ROTATE90
    };

    /*
    public enum Compress : byte
    {
        Unknown,
        Uncompressed,
        CCITT_1D,
        T4Group_3_Fax,
        T6Group_4_Fax,
        LZW,
        JPEG_OldStyle,
        JPEG,
        Adobe_Deflate,
        JBIG_BandW,
        JBIG_Color,
        JPEG_,
        Kodak_262,
        Next,
        Sony_ARW_Compressed,
        Packed_RAW,
        Samsung_SRW_Compressed,
        CCIRLEW,
        Samsung_SRW_Compressed_2,
        PackBits,
        Thunderscan,
        Kodak_KDC_Compressed,
        IT8CTPAD,
        IT8LW,
        IT8MP,
        IT8BL,
        PixarFilm,
        PixarLog,
        Deflate,
        DCS,
        Aperio_JPEG_2000_YCbCr,
        Aperio_JPEG_2000_RGB,
        JBIG,
        SGILog,
        SGILog24,
        JPEG_2000,
        Nikon_NEF_Compressed,
        JBIG2_TIFF_FX,
        Microsoft_Document_Imaging_(MDI)_Binary_Level_Codec,
        Microsoft_Document_Imaging_(MDI)_Progressive_Transform_Codec,
        Microsoft_Document_Imaging_(MDI)_Vector,
        ESRI_Lerc,
        Lossy_JPEG,
        LZMA2,
        Zstd,
        WebP,
        PNG,
        JPEG_XR,
        JPEG_XL,
        Kodak_DCR_Compressed,
        Pentax_PEF_Compressed,

    }
    */

    [DefaultPropertyAttribute("Exif")]
    public class ExifContainer
    {

        
        private string _SequenceId = "---";
        private string _Filename = "---";
        private string _OrginalName = "---";
        private string _Filepath = "---";
        private string _Uuid = "---";
        private string _MediaType = "---";
        private string _Sha256 = "---";
        private string _Crc = "---";
        private string _FileSize = "---";
        private string _DateCreate = "---";
        private string _DateModified = "---";
        private string _DateAdded = "---";
        private string _Privacy = "---";

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
        private string _Author = "---";
        private string _CaptureDate = "---";
        private string _SubsetTimeOriginal = "---";
        private string _Copyright = "";

        private string _Make = "---";
        private string _SSN = "---";
        private string _Model = "---";
        private string _Width = "---";
        private string _Height = "---";
        private string _Orientation = "---";  
        private string _XResolution = "---";  
        private string _YResolution = "---";  
        private string _ResolutionUnit = "---";  
        private string _Software = "---";  
        private string _DateTime = "---";  
        private string _YCbCrPositioning = "---";  
        private string _ExposureTime = "---";  
        private string _F_Number = "---";  
        private string _ExposureProgram = "---";  
        private string _ISOSpeedRating = "---";  
        private string _ExifVersion = "---";  
        private string _DateTimeOriginal = "---";  
        private string _DateTimeDigitized = "---";
        private string _BitsPerSample = "---";
        //private string _ComponentsConfiguration = "YCbCr";  
        private string _CompressedBitsPerPixel = "---";  
        private string _ExposureBiasValue = "---"; // EV  
        //private string _MaxApertureValue = "F4.4";  
        private string _MeteringMode = "---";  
        private string _LightSource = "---";  
        private string _Flash = "---";
        private string _FlashEnergy = "---";
        private string _FocalLength = "---";  
        private string _UserComment = "---"; 
        private string _Sub_SecTime = "---";  
        private string _Sub_SecTimeOriginal = "---";  
        private string _Sub_SecTimeDigitized = "---";  
        private string _FlashPixVersion = "---";  
        private string _ColorSpace = "---";  
        private string _ExifImageWidth = "---";  
        private string _ExifImageHeight = "---";  
        private string _SensingMethod = "---";  
        private string _FileSource = "---";  
        private string _SceneType = "===";  
        private string _CFAPattern = "---";  
        private string _CustomRendered = "---"; 
        private string _ExposureMode = "---"; 
        private string _WhiteBalance = "---";  
        private string _DigitalZoomRatio = "---";  
        private string _FocalLength35 = "---";  
        private string _SceneCaptureType = "---";  
        private string _GainControl = "---";  
        private string _Contrast = "---";  
        private string _Saturation = "---";  
        private string _Sharpness = "---";
        private string _BrightnessValue = "---";
        private string _SubjectDistance = "---";
        private string _SubjectDistanceRange = "---"; // 0 = Unknown 1 = Macro 2 = Close 3 = Distant
        private string _MaxApertureValue = "---";
        private string _Compression = "---";
        private string _PhotometricInterpretation = "---";
        private string _Latitude = "---";
        private string _Longitude = "---";
        private string _Location = "---";
        private string _Scene = "---";
        
        
        private string _SourceUrl = "---";
        private string _UsageRights = "---";
        private string _CopyrightUrl = "---";
        private string _Headline = "---";
        private string _Category = "---";
        private string _Source = "---";
        private string _Instructions = "---";
        private string _Creator = "---";
        private string _JobTitle = "---";
        private string _Address = "---";
        private string _City = "---";
        private string _State = "---";
        private string _PostalCode = "---";
        private string _Country = "---";
        private string _Phone = "---";
        private string _Email = "---";
        private string _Website = "---";
        
        
        private string _ThumbnailOffset = "---";  
        private string _ThumbnailLength = "---";  
        private string _ThumbnailData = "---";
        
        public string GetMeteringModeValueText(MeteringModeValues v)
        {
            switch (v)
            {
                case MeteringModeValues.PHOTO_METERINGMODE_UNKNOWN:
                    return "Unknown";
                case MeteringModeValues.PHOTO_METERINGMODE_AVERAGE:
                    return "Average";
                case MeteringModeValues.PHOTO_METERINGMODE_CENTER:
                    return "Center";
                case MeteringModeValues.PHOTO_METERINGMODE_SPOT:
                    return "Spot";
                case MeteringModeValues.PHOTO_METERINGMODE_MULTISPOT:
                    return "Multi Spot";
                case MeteringModeValues.PHOTO_METERINGMODE_PATTERN:
                    return "Pattern";
                case MeteringModeValues.PHOTO_METERINGMODE_PARTIAL:
                    return "Partial";
                default:
                    return "Unknown";
            }
        }

        public string GetOrientationText(ViewOrientation v)
        {
            switch (v)
            {
                case ViewOrientation.PHOTO_ORIENTATION_NORMAL:
                    return "Normal";
                case ViewOrientation.PHOTO_ORIENTATION_FLIPHORIZONTAL:
                    return "Flip horizontal";
                case ViewOrientation.PHOTO_ORIENTATION_ROTATE180:
                    return "Rotate 180 degrees";
                case ViewOrientation.PHOTO_ORIENTATION_FLIPVERTICAL:
                    return "Flip vertical";
                case ViewOrientation.PHOTO_ORIENTATION_TRANSPOSE:
                    return "Transpose";

                case ViewOrientation.PHOTO_ORIENTATION_TRANSVERSE:
                    return "Rotate 270 degrees";
                case ViewOrientation.PHOTO_ORIENTATION_ROTATE90:
                    return "Rotate 90 degrees";
                default:
                    return "Unknown";
            }
        }
        
        
        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Sequence Index")]
        public string SequenceId { get { return _SequenceId; } set { _SequenceId = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Image file name in the archive")]
        public string Filename { get { return _Filename; } set { _Filename = value; } }

        [CategoryAttribute("File"), ReadOnly(true), DescriptionAttribute("Orginal file name from source")]
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
        [CategoryAttribute("Description"), DescriptionAttribute("Description of image")]
        public string Description { get { return _Description; } set { _Description = value; }}
        [CategoryAttribute("Description"), DescriptionAttribute("The image label")]
        public string Label { get { return _Label; } set { _Label = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("Title of image")]
        public string Title { get { return _Title; } set { _Title = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("Subject of image")]
        public string Subject { get { return _Subject; } set { _Subject = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("Star rating of image")]
        public string Rating { get { return _Rating; } set { _Rating = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("Percentage rating of image")]
        public string RatingPercent { get { return _RatingPercent; } set { _RatingPercent = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("Hash tags associated with image")]
        public string Tags { get { return _Tags; } set { _Tags = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("Keyworks associated with image")] 
        public string Keywords { get { return _Keywords; } set { _Keywords = value; } }
        [CategoryAttribute("Description"), DescriptionAttribute("Version of image")]
        public string Version { get { return _Version; } set { _Version = value; } }
        

        /*
         <Origin>
<Comment/>
<Author/>
<CaptureDate>2024.08.22.13.26.29</CaptureDate>
<SubsetTimeOriginal/>
<Copyright/>
</Origin>
         */
        
        [CategoryAttribute("Origin"),
        DescriptionAttribute("Comment about the current image")]
        public string UserComment { get { return _UserComment; } set { _UserComment = value; } }
        [CategoryAttribute("Origin"),
        DescriptionAttribute("Comment about the current image")]
        public string Author {
            get { return _Author; }
            set { _Author = value; }
        }
        [CategoryAttribute("Origin"),
        DescriptionAttribute("Time date image captured")]
        public string CaptureDate { get { return _CaptureDate; } set { _CaptureDate = value; } }
        [CategoryAttribute("Origin"),
        DescriptionAttribute("This property records fractions of seconds for the related date time properties")]
        public string SubsetTimeOriginal { get { return _SubsetTimeOriginal; } set { _SubsetTimeOriginal = value; } }
        [CategoryAttribute("Origin"),
        DescriptionAttribute("Copyright of the image if any")]
        public string Copyright { get { return _Copyright; } set { _Copyright = value; } }
        
        // Name property with category attribute and 
        // description attribute added 
        /*
         <Width>5472</Width>
<Height>3648</Height>
<ViewRotation>1</ViewRotation>
<BitsPerSample>0</BitsPerSample>
<XResolution>180</XResolution>
<YResolution>180</YResolution>
<ResolutionUnit>inches</ResolutionUnit>
<Compression>6</Compression>
         */
        
        [CategoryAttribute("Image"), ReadOnly(true), DescriptionAttribute("Width in pixels")]
        public string Width { get { return _Width; } set { _Width = value; } }

        [CategoryAttribute("Image"), ReadOnly(true), DescriptionAttribute("Height in pixels")]
        public string Height { get { return _Height; } set { _Height = value; } }

        [CategoryAttribute("Image"), ReadOnly(true), DescriptionAttribute("Orientation i.e. Portrait, Landscape etc.")]
        public string Orientation
        {
            get
            {
                int value = 0;
                if (int.TryParse(_Orientation, out value))
                {
                    return GetOrientationText((ViewOrientation)value);
                }
                return _Orientation;
            }
            set { _Orientation = value; }
        }

        [CategoryAttribute("Image"), ReadOnly(true),
        DescriptionAttribute("Bits per sample can be defined as bits per pixel (bpp).")]
        public string BitsPerSample { get { return _BitsPerSample; } set { _BitsPerSample = value; } }

        [CategoryAttribute("Image"), ReadOnly(true),
        DescriptionAttribute("Provides the number of pixels per length unit for the width of the image")]
        public string XResolution { get { return _XResolution; } set { _XResolution = value; } }

        [CategoryAttribute("Image"), ReadOnly(true),
        DescriptionAttribute("Provides the number of pixels per length unit for the height of the image")]
        public string YResolution { get { return _YResolution; } set { _YResolution = value; } }

        [CategoryAttribute("Image"), ReadOnly(true),
        DescriptionAttribute("The length unit is specified by the tag ResolutionUnit used by XResolution/YResolution")]
        public string ResolutionUnit { get { return _ResolutionUnit; } set { _ResolutionUnit = value; } }

        [CategoryAttribute("Image"),
        DescriptionAttribute("Compression type or Uncompressed")]
        public string Compression { get { return _Compression; } set { _Compression = value; } }
        


        /*
         <Camera>
<Maker>Panasonic</Maker>
<Model>DMC-TZ100</Model>
<ExposureTime>10/8000</ExposureTime>
<Aperture>7.1</Aperture>
<IsoSpeedRating>125</IsoSpeedRating>
<ExposureBias>0</ExposureBias>
<ExposureProgram>Normal program</ExposureProgram>
<SubjectDistance>0</SubjectDistance>
<FocalLength>9.1</FocalLength>
<FocalLenghtIn35mm>25</FocalLenghtIn35mm>
<Flash>Off, Did not fire</Flash>
<MeteringMode>spot</MeteringMode>
<DigitalZoom>0</DigitalZoom>
         */
        
        [CategoryAttribute("Camera"), ReadOnly(true), DescriptionAttribute("Make of camera")]
        public string Make { get { return _Make; } set { _Make = value; } }

        [CategoryAttribute("Camera"), ReadOnly(true), DescriptionAttribute("Model of camera")]
        public string Model { get { return _Model; } set { _Model = value; } }

        [CategoryAttribute("Camera"), ReadOnly(true),
        DescriptionAttribute("Exposure is the amount of light per unit area reaching a photographic film or an electronic image sensor")]
        public string ExposureTime { get { return _ExposureTime; } set { _ExposureTime = value; } }

        [CategoryAttribute("Camera"), ReadOnly(true),
        DescriptionAttribute("A measure of the light-gathering ability of a camera lens. It is calculated by dividing the focal length by the diameter of the clear aperture")]
        public string F_Number { get { return _F_Number; } set { _F_Number = value; } }

        
        [CategoryAttribute("Camera"),
        DescriptionAttribute("ISO speed is the measure of a photographic film's or electronic image sensor's sensitivity to light")]
        public string ISOSpeedRating { get { return _ISOSpeedRating; } set { _ISOSpeedRating = value; } }

        [CategoryAttribute("Camera"),
        DescriptionAttribute("Compensation between the exposure meter calibration point for the given ISO setting and the standard output sensitivity")]
        public string ExposureBiasValue { get { return _ExposureBiasValue; } set { _ExposureBiasValue = value; } }

        [CategoryAttribute("Camera"), ReadOnly(true),
        DescriptionAttribute("Exposure Program: Were the ISO, F-number, and exposure time auto detected or set manually? (AE is auto exposure)")]
        public string ExposureProgram { get { return _ExposureProgram; } set { _ExposureProgram = value; } }

        [CategoryAttribute("Camera"),
       DescriptionAttribute("Distance between camera and subject")]
        public string SubjectDistance { get { return _SubjectDistance; } set { _SubjectDistance = value; } }

        [CategoryAttribute("Camera"),
        DescriptionAttribute("The focal length is a measurement taken when the lens is imaging a far distant object")]
        public string FocalLength { get { return _FocalLength; } set { _FocalLength = value; } }

        [CategoryAttribute("Camera"),
        DescriptionAttribute("the 35 mm equivalent focal length is a measure of the angle of view for a particular combination of a camera lens and film or image sensor size.")]
        public string FocalLength35 { get { return _FocalLength35; } set { _FocalLength35 = value; } }

        [CategoryAttribute("Camera"),
        DescriptionAttribute("Status of the camera flash")]
        public string Flash { get { return _Flash; } set { _Flash = value; } }

        [CategoryAttribute("Camera"),
        DescriptionAttribute("Determines how your camera meters light")]
        public string MeteringMode
        {
            get
            {
                int value = 0;
                if (int.TryParse(_MeteringMode, out value))
                {
                    return GetMeteringModeValueText((MeteringModeValues)value);
                }
                return _MeteringMode;
            }
            set
            {
                _MeteringMode = value;
            }
        }

        [CategoryAttribute("Camera"),
        DescriptionAttribute("Indicates the digital zoom ratio when the image was shot. If the numerator of the recorded value is 0, this indicates that digital zoom was not used.")]
        public string DigitalZoomRatio { get { return _DigitalZoomRatio; } set { _DigitalZoomRatio = value; } }
        
        /*
         <AdvancedPhoto>
        <LightSource>Cloudy</LightSource>
        <ColorSpace> sRGB</ColorSpace>
        <WhiteBalance/>
        <SceneCaptureType>stardard</SceneCaptureType>
        <Contrast>Normal</Contrast>
        <Saturation>Normal</Saturation>
        <Sharpness>Normal</Sharpness>
        <BrightnessValue>-6.27744e+66</BrightnessValue>
        <SubjectDistanceRange/>
        <MaxAperture>2.97266</MaxAperture>
        <CompressedBitsPerPixel>2</CompressedBitsPerPixel>
        <FlashEnergy>0</FlashEnergy>
        <ExifVersion>Ver.1.2 </ExifVersion>
        <Software>Ver.1.2 </Software>
        <PhotometricInterpretation>11</PhotometricInterpretation>
        <GpsTimeStamp/>
         */
        
        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("The light source when the photo was taken")]
        public string LightSource { get { return _LightSource; } set { _LightSource = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("The color model used (sRGB, Adobe RGB, etc.)")]
        public string ColorSpace { get { return _ColorSpace; } set { _ColorSpace = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("This instructs the camera to interpret the color information in the captured sensor data as if the photographed scene" +
            "was lit by a light source comparable to the daylight you have in cloudy weather.")]
        public string WhiteBalance { get { return _WhiteBalance; } set { _WhiteBalance = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Preset Scene types i.e. Standard, Landscape, Portrait, Night scene etc.")]
        public string SceneCaptureType { get { return _SceneCaptureType; } set { _SceneCaptureType = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Contrast is the relationship of two opposing visual elements")]
        public string Contrast { get { return _Contrast; } set { _Contrast = value;  } }
        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Saturation is the purity of a color.")]
        public string Saturation { get { return _Saturation; } set { _Saturation = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Sharpness is how clearly detail is rendered in an image")]
        public string Sharpness { get { return _Sharpness; } set { _Sharpness = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Sharpness is how clearly detail is rendered in an image")]
        public string BrightnessValue { get { return _BrightnessValue; } set { _BrightnessValue = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Distance to subject range i.e. Macro, Close or Distant")]
        public string SubjectDistanceRange { get { return _SubjectDistanceRange; } set { _SubjectDistanceRange = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Max aperture value is the largest aperture on the lens that was used to make the image")]
        public string MaxApertureValue { get { return _MaxApertureValue; } set { _MaxApertureValue = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Name of the compression preset used")]
        public string CompressedBitsPerPixel { get { return _CompressedBitsPerPixel; } set { _CompressedBitsPerPixel = value; } }
        
        [CategoryAttribute("AdvancedPhoto"), ReadOnly(true),
        DescriptionAttribute("Exif software version")]
        public string FlashEnergy { get { return _FlashEnergy; } set { _FlashEnergy = value; } }
        [CategoryAttribute("AdvancedPhoto"), ReadOnly(true),
        DescriptionAttribute("Exif software version")]
        public string Software { get { return _Software; } set { _Software = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("Version of the Exif standard")]
        public string ExifVersion { get { return _ExifVersion; } set { _ExifVersion = value; } }

        [CategoryAttribute("AdvancedPhoto"),
        DescriptionAttribute("The value of Photometric Interpretation specifies the intended interpretation of the image pixel data.")]
        public string PhotometricInterpretation { get { return _PhotometricInterpretation; } set { _PhotometricInterpretation = value; } }
        
        /*
         0 = WhiteIsZero
 1 = BlackIsZero
 2 = RGB
 3 = RGB Palette
 4 = Transparency Mask
 5 = CMYK
 6 = YCbCr
 8 = CIELab
 9 = ICCLab
 10 = ITULab
 32803 = Color Filter Array
 32844 = Pixar LogL
 32845 = Pixar LogLuv
 32892 = Sequential Color Filter
 34892 = Linear Raw
 51177 = Depth Map
 52527 = Semantic Mask

         */
        /*
         <Location>
        <Latitude/>
        <Longitude/>
        <Location/>
        <Scene/>
        </Location>
         */
        
        [CategoryAttribute("Location"),
        DescriptionAttribute("Time and Date image was digitized")]
        public string Latitude { get { return _Latitude; } set { _Latitude = value; } }

        [CategoryAttribute("Location"),
        DescriptionAttribute("Time and Date image was digitized")]
        public string Longitude { get { return _Longitude; } set { _Longitude = value; } }

        [CategoryAttribute("Location"),
       DescriptionAttribute("Time and Date image was digitized")]
        public string Location { get { return _Location; } set { _Location = value; } }

        [CategoryAttribute("Location"),
       DescriptionAttribute("Time and Date image was digitized")]
        public string Scene { get { return _Scene; } set { _Scene = value; } }
        
        /*
         <IPTC>
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
        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string SourceUrl { get { return _SourceUrl; } set { _SourceUrl = value; } }
        
        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string UsageRights { get { return _UsageRights; } set { _UsageRights = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string CopyrightUrl { get { return _CopyrightUrl; } set { _CopyrightUrl = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Headline { get { return _Headline; } set { _Headline = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Category { get { return _Category; } set { _Category = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Source { get { return _Source; } set { _Source = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Instructions { get { return _Instructions; } set { _Instructions = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Creator { get { return _Creator; } set { _Creator = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string JobTitle { get { return _JobTitle; } set { _JobTitle = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Address { get { return _Address; } set { _Address = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string City { get { return _City; } set { _City = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string State { get { return _State; } set { _State = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string PostalCode { get { return _PostalCode; } set { _PostalCode = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Country { get { return _Country; } set { _Country = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        
        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Email { get { return _Email; } set { _Email = value; } }

        [CategoryAttribute("IPTC"), DescriptionAttribute("Description of image")]
        public string Website { get { return _Email; } set { _Website = value; } }
        
    }
}
        /*
        [CategoryAttribute("Date Time"), ReadOnly(true),
        DescriptionAttribute("Time and date image taken")]
        public string DateTime { get { return _DateTime; } set { _DateTime = value; } }

        [CategoryAttribute("Exif"), ReadOnly(true),
        DescriptionAttribute("YCbCr color spaces are defined by a mathematical coordinate transformation from an associated RGB primaries and white point.")]
        public string YCbCrPositioning { get { return _YCbCrPositioning; } set { _YCbCrPositioning = value; } }

        
        
        [CategoryAttribute("Date Time"),
        DescriptionAttribute("Date time original is the the time the image was created")]
        public string DateTimeOriginal { get { return _DateTimeOriginal; } set { _DateTimeOriginal = value; } }
        [CategoryAttribute("Date Time"),
        DescriptionAttribute("Time and Date image was digitized")]
        public string DateTimeDigitized { get { return _DateTimeDigitized; } set { _DateTimeDigitized = value; } }
         
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

*/
