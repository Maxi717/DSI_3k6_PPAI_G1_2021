using ProyectoDSIPPAI.Clases.Entidades;
using ProyectoDSIPPAI.Clases.Fronteras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Gestores
{
    public class GestorVentaEntrada
    {
        private Empleado logueadoEmpleado;
        private List<Tarifa> tarifas;
        private Usuario usuario;


        public void opcionventaentradas(PantallaVentaEntrada pantalla, Sesion sesion)
        {
            this.logueadoEmpleado = BuscarEmpleadoLogeado(sesion);
            BuscarSede();
            List<Tarifa> tarifas = BuscarTarifaDeSede();
            pantalla.MostrarTarifasVigentes();
        }

        private Empleado BuscarEmpleadoLogeado(Sesion sesion)
        {
            Empleado empleado = sesion.GetEmpleadoEnSesion();
            return empleado;

        }

        private Sede BuscarSede()
        {
            Sede sede = this.logueadoEmpleado.ObtenerSede();
            return sede;
        }

        private List<Tarifa> BuscarTarifasDeSede()
        {
            Sede sede = BuscarSede();
            List<Tarifa> tarifasVigentes = sede.ObtenerTarifasVigentes();
            return tarifasVigentes;
        }

        public void TomarTarifasSeleccionadas(PantallaVentaEntrada pantalla)
        {


        }





    }
}
