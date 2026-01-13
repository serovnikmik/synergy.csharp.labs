using lab7;
using System;
using System.Windows.Forms;

namespace lab7_Serov
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstMainForm());
        }
    }
}