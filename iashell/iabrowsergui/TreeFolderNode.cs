using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iabrowsergui
{
    public class TreeFolderNode : TreeNode
    {
        TreeFolderNode(DirectoryInfo info)
        {
            directoryInfo = info;
        }

        public DirectoryInfo directoryInfo;

        public DirectoryInfo DirectoryInfo
        {
            get => directoryInfo;
        }
    }
}
