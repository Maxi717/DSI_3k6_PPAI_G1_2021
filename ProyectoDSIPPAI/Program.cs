using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDSIPPAI.Clases.Fronteras;
using ProyectoDSIPPAI.Clases.Entidades;

namespace ProyectoDSIPPAI
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
            Usuario usuario = new Usuario();
            Empleado empleado = new Empleado();
            Sede sede = new Sede();
            Sesion sesion = new Sesion();
            Application.Run(new PantallaVentaEntrada(sesion));
        }
    }
}
