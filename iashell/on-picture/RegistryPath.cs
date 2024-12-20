using System;
using System.Collections.Generic;
using System.Text;

namespace on_picture
{
    public class RegistryPath
    {
        static String registryCurrentPath = "Software\\IDK Software\\ImgArchive 1.0";
        public static String CurPath { get { return registryCurrentPath; } }
        static String registryLocalPath = "SOFTWARE\\IDK Software\\ImgArchive 1.0";
        public static String LocalPath { get { return registryLocalPath; } }
    }
}
