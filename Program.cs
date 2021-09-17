using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace CSGO_Cheat_Cleaner_Detector
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            bool connection = NetworkInterface.GetIsNetworkAvailable();
            if (connection == true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login_Form());

            }
            else
            {
                MessageBox.Show("No Network Connection", "Error");
            }
        }
    }
}
