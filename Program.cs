using System;
using System.Windows.Forms;

namespace WebCrawler_JUSBrasil
{
    static class Program
    {
        /// entrada principal para o aplicativo.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}