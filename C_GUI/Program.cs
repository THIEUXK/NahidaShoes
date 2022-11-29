using C_GUI.QLForm;
using C_GUI.Views;

namespace C_GUI
{
    internal static class Program
    {
        public static TrangChu TrangChu = new();
<<<<<<< HEAD

=======
>>>>>>> parent of 784c824 (Merge pull request #44 from CuongDeveloper/PH26084)
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new TrangChu());
=======
            Application.Run(TrangChu);
>>>>>>> parent of 784c824 (Merge pull request #44 from CuongDeveloper/PH26084)
        }
    }
    
}

