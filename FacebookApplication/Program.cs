using System;
using System.Windows.Forms;


namespace FacebookApplication
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("checkkk");
            Application.Run(MainForm.Instance);
            
        }
    }
}
