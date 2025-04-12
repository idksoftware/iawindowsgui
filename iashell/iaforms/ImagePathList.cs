using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iaforms
{
    public class Folder
    {
        string m_name;
        string m_path;
        string m_leval;
        int m_images;

        public Folder(string name, string path)
        {
            m_name = name;
            m_path = path;
        }

        public int Images
        {
            get => m_images;
            set => m_images = value;
        }
        public string Name
        {
            get => m_name;
            set => m_name = value;
        }
        public string Path
        {
            get => m_path;
            set => m_path = value;
        }
    }
    public class ImagePathList
    {
        private string m_scanPath;
        private List<FileObject> fileList = new List<FileObject>();
        List<Folder> folders = new List<Folder>();
        List<Folder> subFolders = new List<Folder>();
        List<Folder> allFolders = new List<Folder>();

        public ImagePathList(string scanPath)
        {
            m_scanPath = scanPath;
        }

        public List<Folder> AllFolders
        {
            get => allFolders;
        }
        public void Process()
        {
            ScanDriveDirectories(m_scanPath);
            int level;
            string folderName = "";
            int images = 0;
            Folder folder = null;
            foreach (var file in fileList)
            {
                //Debug.Print("  file:            {0, 15}", file.path);
                string path = m_scanPath + file.path;
                FileInfo fi = new FileInfo(path);

                if (folderName != fi.DirectoryName)
                {
                    folderName = fi.DirectoryName;
                    //Debug.Print("  folderName:            {0, 15} ", folderName);
                    folder = new Folder(folderName, path);
                    folder.Images++;
                    folders.Add(folder);

                }
                else
                {
                    folder.Images++;
                    //Debug.Print("  folderName:{0} Images {1}", folderName, folder.Images);

                }

            }


            foreach (var f in folders)
            {
                bool dup = false;
                //folder = f;
                folder = getDirectoryInfo(f.Name);
                List<DirectoryInfo> flist = getDirectories(folder.Name);


                foreach (DirectoryInfo d in flist)
                {

                    if (!IsDup(subFolders, d.FullName))
                    {
                        //Debug.Print("  +++ Folders:{0}", d.FullName);
                        Folder newFolder = new Folder(d.FullName, d.FullName);
                        subFolders.Add(newFolder);
                    }
                }
            }

            foreach (var f in subFolders)
            {
                //
                int nImage = 0;
                string path = f.Name;
                foreach (var v in folders)
                {
                    //Debug.Print("  folderName:{0} Images {1}", v.Name, v.Images);
                    if (v.Name.Length >= f.Name.Length)
                    {
                        string subPath = v.Name.Substring(0, f.Name.Length);
                        if (f.Name == subPath)
                        {
                            f.Images += v.Images;
                        }
                    }
                }
            }

            Debug.Print("++++++++++++++++++++++++++++++++++\n");
            foreach (var f in folders)
            {
                //Debug.Print("  Folders:{0} Images {1}", f.Name, f.Images);
            }

            foreach (var f in subFolders)
            {
                //Debug.Print("  subFolders:{0} Images {1}", f.Name, f.Images);
            }

            foreach (var f in subFolders)
            {
                int nImage = 0;
                string path = f.Name;
                allFolders.Add(f);
                foreach (var v in folders)
                {
                    Folder sf = getDirectoryInfo(v.Name);
                    if (sf.Name == f.Name)
                    {
                        allFolders.Add(v);
                    }
                    //Debug.Print("  folderName:{0} Images {1}", v.Name, v.Images);

                }
            }

            foreach (var f in allFolders)
            {
                Debug.Print("  allFolders:{0} Images {1}", f.Name, f.Images);
            }


        }

        public void ScanDriveDirectories(String path)
        {
            ScanDirectory scanDirectory = new ScanDirectory();
            //scanDirectory.TotalSize = totalSize;

            // Add a DirectoryEvent to the class
            scanDirectory.DirectoryEvent += new ScanDirectory.DirectoryEventHandler(scanDirectory_DirectoryEvent);

            // Add a FileEvent to the class
            scanDirectory.FileEvent += new ScanDirectory.FileEventHandler(scanDirectory_FileEvent);

            scanDirectory.SearchPattern = "*.*";
            scanDirectory.readImageExtFile("C:\\ProgramData\\IDK-Software\\ImgArchive\\config\\ext.dat");
            scanDirectory.WalkDirectory(path);
            //needsScanning = false;
            //if (CompletedEvent != null)
            //{
            //    CompletedEvent(this);
            //}
        }

        private void scanDirectory_DirectoryEvent(object sender, DirectoryEventArgs e)
        {

            switch (e.Action)
            {
                case ScanDirectoryAction.Enter:
                    if (e.Info.FullName.EndsWith(":\\") == true)
                    {
                        break; // skip drive letters
                    }
                    FolderItem fi = new FolderItem();
                    fi.path = e.Info.FullName.Substring(2); // do not include drive letter (X:)
                                                            //Debug.Print("  folder:            {0, 15}", fi.path);
                    fi.attributes = e.Info.Attributes;
                    fi.lastWriteTime = e.Info.LastWriteTime;
                    //fileList.Add(fi);
                    break;
                case ScanDirectoryAction.Leave:
                    break;
            }
            //e.Cancel = !buttonCancel.Enabled;

        }

        private void scanDirectory_FileEvent(object sender, FileEventArgs e)
        {
            //noFilesFound++;
            //filesDone++;

            FileItem fi = new FileItem();
            //fi.path = e.Info.FullName;
            fi.path = e.Info.FullName.Substring(2);
            fi.attributes = e.Info.Attributes;
            fi.crc32 = 0;
            fi.size = e.Info.Length;
            fi.lastWriteTime = e.Info.LastWriteTime;
            //
            fileList.Add(fi);
            //OnFileEvent(this);
            //processedSize += e.Info.Length;
            //double processed = processedSize;
            //double total = totalSize - availableFreeSpace;
            /*
            int progress = 0;
            double fraction = processed / total;
            fraction *= 100;
            progress = (int)fraction;
            Debug.Print("  processedSize:            {0, 15} ", fraction);
            Debug.Print("  Percent:            {0, 15} ", progress);
            */
            //RaiseProgressEvent((int)progress);
            //e.Cancel = !buttonCancel.Enabled;       
        }



        Folder getDirectoryInfo(string name)
        {
            DirectoryInfo di = new DirectoryInfo(name);
            if (di.Parent == null)
            {
                return null;
            }
            Folder folder = new Folder(di.Parent.FullName, name);
            return folder;
        }

        internal static List<DirectoryInfo> getDirectories(string name)
        {
            DirectoryInfo di = new DirectoryInfo(name);
            return Split(di);
        }
        internal static List<DirectoryInfo> Split(DirectoryInfo path)
        {
            if (path == null) throw new ArgumentNullException("path");
            var ret = new List<DirectoryInfo>();
            if (path.Parent != null) ret.AddRange(Split(path.Parent));
            ret.Add(path);
            return ret;
        }

        internal bool IsDup(List<Folder> folders, string name)
        {

            foreach (var v in folders)
            {
                if (v.Name == name)
                {
                    return true;
                }
                //Debug.Print("  new folder:{0} match {1}", v.Name, f.Name);
            }

            return false;

        }
    }

}

