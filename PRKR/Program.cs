using System;
using System.Windows.Forms;

namespace R
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine(array[1].ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
