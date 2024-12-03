using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using System.Xml.Linq;
using System.Drawing;
using System.Security.Policy;
using System.IO;
using System.Security.Principal;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;


namespace on_picture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("on-picture {0}", args[0]);
            UpdateThumbnails.MakeThumbnails(args[0]);
        }
    }
}
