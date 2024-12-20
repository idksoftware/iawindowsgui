using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace iabrowserlib
{ 
    internal class Album
    {
        private static Dictionary<string, string> m_titleToFileName = new Dictionary<string, string>();
        private static string m_rootPath;
        private static string m_picturePath;

        public Album(string rootPath, string picturePath)
        {
            m_rootPath = rootPath;
            m_picturePath = picturePath;
        }

        public static string GetFileName(string heading, bool ret)
        {
            string fileName = null;
            ret = m_titleToFileName.TryGetValue(heading, out fileName);
            return fileName;
        }

        public static List<string> getImageFileList(string header)
        {
            bool ret = false;
            string fileName = GetFileName(header, ret);
            string path = m_rootPath + "\\" + fileName;
            IEnumerable<string> lines = File.ReadLines(path);
            List<string> images = new List<string>();
            bool firstLine = true;
            foreach (string line in lines)
            {
                if (firstLine)
                {
                    firstLine = false;
                }
                else
                {

                    string year = line.Substring(0, 4);
                    string month = line.Substring(0, 10);
                    string filename = line.Substring(10, (line.Length - 10));
                    string imagePath = m_picturePath + "\\" + year + "\\" + month + filename;
                    images.Add(imagePath);
                }
            }

            return images;
        }
        internal class AlbumRWritter
        {
            private string m_heading;
            

            private List<string> m_imageList = new List<string>();
            public AlbumRWritter() //string rootPath)
            {
                //m_rootPath = rootPath;
            }


            public bool albumReader(string fileName)
            {
                bool firstLine = true;
                string path = m_rootPath + "\\" + fileName;

                IEnumerable<string> lines = File.ReadLines(path);
                foreach (string line in lines)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        m_heading = line;
                        m_titleToFileName.Add(m_heading, fileName);
                    }
                    else
                    {
                        m_imageList.Add(line);
                    }
                }
                return true;
            }

            public string Heading
            {
                get => m_heading; set => m_heading = value;
            }

            public List<string> ImageList
            {
                get => m_imageList; set => m_imageList = value;
            }

        }
    }
}
