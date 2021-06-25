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

        public int CantidadAlumnos
        {
            get => cantidadAlumnos;
            set => cantidadAlumnos = value;
        }
        public int CantidadAlumnosConfirmada
        {
            get => cantidadAlumnosConfirmada;
            set => cantidadAlumnosConfirmada = value;
        }
        public int DuracionEstimada
        {
            get => duracionEstimada;
            set => duracionEstimada = value;
        }
        public DateTime FechaHoraCreacion
        {
            get => fechaHoraCreacion;
            set => fechaHoraCreacion = value;
        }
        public DateTime FechaHoraReserva
        {
            get => fechaHoraReserva;
            set => fechaHoraReserva = value;
        }
        public DateTime HoraFinReal
        {
            get => horaFinReal;
            set => horaFinReal = value;
        }
        public DateTime HoraInicioReal
        {
            get => horaInicioReal;
            set => horaInicioReal = value;
        }
        public int NumeroReserva
        {
            get => numeroReserva;
            set => numeroReserva = value;
        }
        public Sede Sede
        {
            get => sede;
            set => sede = value;
        }
        public bool sonParaFechaHoraYSede(DateTime fechaYHora, Sede sede)
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
