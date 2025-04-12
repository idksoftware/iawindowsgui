using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace iaforms
{
    public class FileObject
    {
        public DateTime lastWriteTime;
        public String path = null;
        public FileAttributes attributes;
    }

    public class FileItem : FileObject
    {

        public long size = 0;
        public uint crc32 = 0;
    }

    public class FolderItem : FileObject
    {

    }

}
