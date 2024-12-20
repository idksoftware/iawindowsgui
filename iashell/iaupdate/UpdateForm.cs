using System.Diagnostics;
using System.IO;
using iaforms;

namespace iaupdate
{
    public partial class UpdateForm : Form
    {
        private string m_installPath;
        private string m_picturePath;
        public UpdateForm(string installPath, string picturePath)
        {
            m_installPath = installPath;
            m_picturePath = picturePath;

            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string[] dirEntries = Directory.GetDirectories(m_picturePath);
            foreach (string path in dirEntries)
            {
                
                if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessYears(path);
                }
                else
                {
                    Debug.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
        }

        private void ProcessYears(string yearPath)
        {
            string[] dirEntries = Directory.GetDirectories(yearPath);
            foreach (string path in dirEntries)
            {

                if (Directory.Exists(path))
                {
                    // This path is a directory
                    Debug.WriteLine("Dir: {0}", path);
                    ProcessDay(path);
                }
                else
                {
                    Debug.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
        }

        private void ProcessDay(string dayPath)
        {
            string[] fileEntries = Directory.GetFiles(dayPath);
            foreach (string path in fileEntries)
            {

                if (File.Exists(path))
                {
                    // This path is a directory
                    Debug.WriteLine("Dir: {0}", path);
                    ProcessThumbs(path);
                }
                
                else
                {
                    Debug.WriteLine("{0} is not a valid file or directory.", path);
                }
            }
        }


        private void ProcessThumbs(string imagePath)
        {
            if (isImage(imagePath))
            {
                UpdateThumbnails.MakeThumbnails(imagePath);

                FileInfo image = new FileInfo(imagePath);
                string ext = image.Extension;
                ext = ext.ToLower();
                if (ext == ".jpg" || ext == ".bmp" || ext == ".gif" || ext == ".png" || ext == ".tiff" ||
                    ext == ".tif")
                {
                    return;
                }

                UpdateThumbnails.makePreviewFromRAW(m_installPath, imagePath);
            }
        }

        Boolean isImage(String e)
        {
            String extPath = m_installPath + "\\config\\ext.dat";
            if (!File.Exists(extPath))
            {
                return false;
            }

            string line;
            using (StreamReader sr = new StreamReader(extPath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    int idx = line.IndexOf(':');
                    String ext = line.Substring(0, idx);
                    ext = "." + ext;
                    if (string.Equals(e, ext, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}