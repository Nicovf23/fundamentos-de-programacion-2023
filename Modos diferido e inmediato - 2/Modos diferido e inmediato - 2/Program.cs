using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modos_diferido_e_inmediato___2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            int[]numeros = {1.5.4.7.6.3.5.9.8.11}

            var valores = from n in numeros
                          where n % 2 == 0
                          select n;
        }




    }
}
