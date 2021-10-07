using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Abro el form de login en un diálogo modal desde el MAIN, solo si se valida el Usuario abre el form principal
            Inicio login = new Inicio();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Principal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
