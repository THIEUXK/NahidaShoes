using System.Security.Cryptography;
using C_GUI.QLForm;
using C_GUI.Views;

namespace C_GUI
{
    internal static class Program
    {
        public static Login Login = new();
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
            Application.Run(new FormSale());
=======
            Application.Run(new Login());
>>>>>>> 0c23dbb0d347f9d24464f525bc1310fe0205095c
            
        }
    }
}