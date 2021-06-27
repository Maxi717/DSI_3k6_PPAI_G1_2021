using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Exposicion
    {
        private DateTime fechaFin;
        private DateTime fechaFinReplanificada;
        private DateTime fechaInicio;
        private DateTime fechaInicioReplanificada;
        private TimeSpan horaApertura;
        private TimeSpan horaCierre;
        private string nombre;
        private Empleado empleado;
        private List<DetalleExposicion> detalleExposicion;


        public bool EsVigente()
        {
            bool resultado = false;

            DateTime fechaActual = DateTime.Today;

            if (fechaFinReplanificada == null)
            {
                if (fechaFin > fechaActual)
                {
                    resultado = true;
                }
            }
            else
            {
                if (fechaFinReplanificada > fechaActual)
                {
                    resultado = true;
                }

                else
                {
                    resultado = false;
                }
            }
            return resultado;
        }

        public int CalcularDuracionObrasExpuestas()
        {
            int duracion = 0;

            foreach (DetalleExposicion detalle in this.detalleExposicion)
            {
                duracion += detalle.BuscarDuracionObras();
            }

            return duracion;
        }
    }
}
