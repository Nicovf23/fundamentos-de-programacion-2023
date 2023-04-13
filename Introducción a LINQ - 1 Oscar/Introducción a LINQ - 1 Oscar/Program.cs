using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introducción_a_LINQ___1_Oscar
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            int[] numeros = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema", 5, 9, 8 };

            IEnumerable<int> valores = from p in numeros
                                       where p > 3 && n < 8
                                       select p;

            foreach (string postre in encontrados)
                Console.WriteLine(postre);

            Console.WriteLine("------");

        } 
    }
}
