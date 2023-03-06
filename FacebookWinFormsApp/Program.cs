using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            
            Clipboard.SetText("Muhammadsh@mta.ac.il");
            UIManager.Instance.StartApplication();
        }
    }
}