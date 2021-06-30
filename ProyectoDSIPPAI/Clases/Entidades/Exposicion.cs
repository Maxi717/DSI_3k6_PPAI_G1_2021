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

        public void SetNombre(string unNombre)
        {
            this.nombre = unNombre;
        }

        public void SetEmpleado(Empleado unEmpleado)
        {
            this.empleado = unEmpleado;
        }

        public void SetDetallesExposicion(List<DetalleExposicion> unaLista)
        {
            this.detalleExposicion = unaLista;
        }

        
        public void SetFechaFin(DateTime nuevaFecha)
        {
            this.fechaFin = nuevaFecha;
        }

        public void SetFechaFinReplanificada(DateTime nuevaFecha)
        {
            this.fechaFinReplanificada = nuevaFecha;
        }

        public void SetFechaInicio(DateTime nuevaFecha)
        {
            this.fechaInicio = nuevaFecha;
        }

        public void SetFechaInicioReplanificada(DateTime nuevaFecha)
        {
            this.fechaInicioReplanificada = nuevaFecha;
        }

        public void SetHoraApertura(TimeSpan unaHora)
        {
            this.horaApertura = unaHora;
        }

        public void SetHoraCierre(TimeSpan unaHora)
        {
            this.horaCierre = unaHora;
        }


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
