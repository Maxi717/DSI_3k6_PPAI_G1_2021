using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class ReservaVisita
    {
        private int cantidadAlumnos;
        private int cantidadAlumnosConfirmada;
        private int duracionEstimada;
        private DateTime fechaHoraCreacion;
        private DateTime fechaHoraReserva;
        private DateTime horaFinReal;
        private DateTime horaInicioReal;
        private int numeroReserva;
        private Sede sede;

        public ReservaVisita()
        {

        }
        public ReservaVisita(int cantidadAlumnos, int cantidadAlumnosConfirmada, int duracionEstimada, DateTime fechaHoraCreacion, DateTime fechaHoraReserva, DateTime horaFinReal, DateTime horaInicioReal, int numeroReserva, Sede sede)
        {
            this.cantidadAlumnos = cantidadAlumnos;
            this.cantidadAlumnosConfirmada = cantidadAlumnosConfirmada;
            this.duracionEstimada = duracionEstimada;
            this.fechaHoraCreacion = fechaHoraCreacion;
            this.fechaHoraReserva = fechaHoraReserva;
            this.horaFinReal = horaFinReal;
            this.horaInicioReal = horaInicioReal;
            this.numeroReserva = numeroReserva;
            this.sede = sede;
        }

        public void SetCantidadAlumnos(int nuevaCantidadAlumnos)
        {
            this.cantidadAlumnos = nuevaCantidadAlumnos;
        }
        public void SetCantidadAlumnosConfirmada(int nuevaCantidadAlumnosConfirmada)
        {
            this.cantidadAlumnosConfirmada = nuevaCantidadAlumnosConfirmada;
        }
        public void SetDuracionEstimada(int nuevaDuracionEstimada)
        {
            this.duracionEstimada = nuevaDuracionEstimada;
        }
        public void SetFechaHoraCreacion(DateTime nuevaFechaHoraCreacion)
        {
            this.fechaHoraCreacion = nuevaFechaHoraCreacion;
        }
        public void SetFechaHoraReserva(DateTime nuevaFechaHoraReserva)
        {
            this.fechaHoraReserva = nuevaFechaHoraReserva;
        }
        public void SetHoraFinReal(DateTime nuevaHoraFinReal)
        {
            this.horaFinReal = nuevaHoraFinReal;
        }
        public void SetHoraInicioReal(DateTime nuevaHoraInicioReal)
        {
            this.horaInicioReal = nuevaHoraInicioReal;
        }
        public void SetNumeroReserva(int nuevoNumeroReserva)
        {
            this.numeroReserva = nuevoNumeroReserva;
        }
        public void SetSede(Sede nuevaSede)
        {
            this.sede = nuevaSede;
        }

        public bool SonParaFechaHoraYSede(DateTime fechaYHora, Sede sede)
        {
            if (this.fechaHoraReserva == fechaYHora && this.sede == sede)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
