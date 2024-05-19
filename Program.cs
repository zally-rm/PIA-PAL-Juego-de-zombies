using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_2
{
    internal static class Program
    {
        public static List<(string, int)> puntuaciones = new List<(string, int)>();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // se agregó de aquí hacia abajo
            var primeraPantalla = new Inicio();
            primeraPantalla.FormClosed += new FormClosedEventHandler(FormClosed);
            primeraPantalla.Show();
            Application.Run();  // se cambió Application.Run(new Form1()) por Application.Run(new Inicio())
                                // se volvió a cambiar a Application.Run()
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
