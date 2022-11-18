using C_GUI.QLForm;

namespace C_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new FormNhanViencs());
=======
            Application.Run(new FormChiTietGiay());
>>>>>>> parent of c8a1d28 (thieuxk)
        }
    }
}