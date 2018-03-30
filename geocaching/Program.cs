using System;
using System.Windows.Forms;

namespace geocaching
{
    internal static class Program
    {
        /// <summary>
        ///     Entry Point for Start Programm
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGCerfassen());
        }
    }
}