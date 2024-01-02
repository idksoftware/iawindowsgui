using iaforms;

namespace iaimagepreviewer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            string rawImage = "C:\\Users\\iferg\\ImgArchive\\Pictures\\.imga\\rawimage.jpg";
            Application.Run(new ImagePreview(args[0], rawImage));
        }
    }
}