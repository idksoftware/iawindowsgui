using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static iabrowserlib.Album;

namespace iabrowserlib
{
    class AlbumInfo
    {
        private string m_title;
        private string m_discription;
        private int m_size;
        private string m_lastUpdated;
        private string m_filename;
        private List<string> m_ImageList = new List<string>();

        public AlbumInfo(string title, string discription, int size, string lastUpdated, string filename)
        {
            m_title = title;
            m_discription = discription;
            m_size = size;
            m_lastUpdated = lastUpdated;
            m_filename = filename;
        }

        public AlbumInfo(string title)
        {
            m_title = title;
           
        }

        public AlbumInfo(string filename, string lastUpdated)
        {
            m_filename = filename;
            m_lastUpdated = lastUpdated;
        }

        

        public string Title { get => m_title; set => m_title = value; }
        public string Discription { get => m_discription; set => m_discription = value; }
        public int Size { get => m_size; set => m_size = value; }
        public string LastUpdated { get => m_lastUpdated; }
        public string Filename { get => m_filename; set => m_filename = value; }
        public List<string> ImageList { get => m_ImageList; set => m_ImageList = value; }
    }

    internal class AlbumManager
    {
        private static Dictionary<string, AlbumInfo> m_AlbumList = new Dictionary<string, AlbumInfo>();
        private static string m_albumsPath;
        private static string m_picturesPath;
        public AlbumManager(string albumsPath, string picturesPath)
        {
            m_albumsPath = albumsPath;
            m_picturesPath = picturesPath;
        }

        public static bool LoadAlbums()
        {
            AlbumManager.AlbumRWritter albumRWritter = new AlbumManager.AlbumRWritter();
            DirectoryInfo albumDirectoryInfo = new DirectoryInfo(m_albumsPath);
            foreach (FileInfo fileInfo in albumDirectoryInfo.GetFiles())
            {

                AlbumInfo albumInfo = new AlbumInfo(fileInfo.Name, fileInfo.LastWriteTime.ToShortTimeString());
                albumRWritter.albumReader(albumInfo);
                ListViewItem lvi = new ListViewItem(albumRWritter.Heading);
            }
            return true;
        }


        public static bool Add(string title, string discription)
        {
            AlbumInfo albumInfo = new AlbumInfo(title);
            string filename = MakeValidFileName(title, '_' ,false);
            albumInfo.Filename = filename;
            m_AlbumList.Add(title, albumInfo);
            return true;
        }

        public static AlbumInfo GetAlbumInfo(string name)
        {
            AlbumInfo albumInfo = null;
            bool ret = m_AlbumList.TryGetValue(name, out albumInfo);
           
            return albumInfo;
        }


        public static List<string> getImageFileList(string title)
        {
            bool ret = false;
            AlbumInfo albumInfo = GetAlbumInfo(title);
            List<string> images = new List<string>();
            if (albumInfo.Size == 0)
            {
                return images;
            }
            string path = m_albumsPath + "\\" + albumInfo.Filename;
            
            IEnumerable<string> lines = File.ReadLines(path);
            
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
                    string imagePath = m_picturesPath + "\\" + year + "\\" + month + filename;
                    images.Add(imagePath);
                }
            }

            return images;
        }

        public Dictionary<string, AlbumInfo> AlbumList { get => m_AlbumList; }

        static char[] _invalids;

        /// <summary>Replaces characters in <c>text</c> that are not allowed in 
        /// file names with the specified replacement character.</summary>
        /// <param name="text">Text to make into a valid filename. The same string is returned if it is valid already.</param>
        /// <param name="replacement">Replacement character, or null to simply remove bad characters.</param>
        /// <param name="fancy">Whether to replace quotes and slashes with the non-ASCII characters ” and ⁄.</param>
        /// <returns>A string that can be used as a filename. If the output string would otherwise be empty, returns "_".</returns>
        public static string MakeValidFileName(string text, char? replacement = '_', bool fancy = true)
        {
            StringBuilder sb = new StringBuilder(text.Length);
            var invalids = _invalids ?? (_invalids = Path.GetInvalidFileNameChars());
            bool changed = false;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (invalids.Contains(c))
                {
                    changed = true;
                    var repl = replacement ?? '\0';
                    if (fancy)
                    {
                        if (c == '"') repl = '”'; // U+201D right double quotation mark
                        else if (c == '\'') repl = '’'; // U+2019 right single quotation mark
                        else if (c == '/') repl = '⁄'; // U+2044 fraction slash
                    }
                    if (repl != '\0')
                        sb.Append(repl);
                }
                else
                {
                    sb.Append(c);
                }
            }
            if (sb.Length == 0)
                return "_";
            return changed ? sb.ToString() : text;
        }


        internal class AlbumRWritter
        {
            private string m_heading;


            private List<string> m_imageList = new List<string>();
            public AlbumRWritter() //string rootPath)
            {
                //m_rootPath = rootPath;
            }


            public bool albumReader(AlbumInfo albumInfo)
            {
                bool firstLine = true;
                string path = m_albumsPath + "\\" + albumInfo.Filename;

                IEnumerable<string> lines = File.ReadLines(path);
                foreach (string line in lines)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        albumInfo.Title = line;
                        m_AlbumList.Add(albumInfo.Title, albumInfo);
                    }
                    else
                    {
                        albumInfo.ImageList.Add(line);
                    }
                }

                albumInfo.Size = albumInfo.ImageList.Count;
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

/*
 // Album list
   string albumsPath = m_userspacePath + "\\.imga\\.albums";
   Album album = new Album(albumsPath, m_picturesPath);
   Album.AlbumRWritter albumRWritter = new Album.AlbumRWritter();
   DirectoryInfo albumDirectoryInfo = new DirectoryInfo(albumsPath);
   foreach (FileInfo albumInfo in albumDirectoryInfo.GetFiles())
   {
       albumRWritter.albumReader(albumInfo.Name);
       ListViewItem lvi = new ListViewItem(albumRWritter.Heading);
       lvi.SubItems.Add("143");
       lvi.SubItems.Add("2022/06/11");
       listViewAlbum.Items.Add(lvi);
   }
   
 */