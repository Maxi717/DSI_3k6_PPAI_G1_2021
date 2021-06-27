using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Entrada
    {
        private DateTime fechaVenta;
        private TimeSpan horaVenta;
        private int numero;
        private float monto;

        private Sede sede;
        private Tarifa tarifa;

        public int GetNumero
        {
            get => numero;
        }

        public int SetNumero
        {
            set => numero = value;
        }

        public Sede GetSede
        {
            get => sede;

        }

        public Sede SetSede
        {
            set => sede = value;

        }

        public DateTime GetFechaVenta
        {
            get => fechaVenta.Date;

        }

        public DateTime SetFechaVenta
        { 
            set => fechaVenta = value;

        }

        public TimeSpan GetHoraVenta
        {
            get => fechaVenta.TimeOfDay;
        }

        public TimeSpan SetHoraVenta
        {
            set => horaVenta = value;

        }

        public Tarifa GetTarifa
        {
            get => tarifa;
        }

        public Tarifa SetTarifa
        {
            set => tarifa = value;

        }

        public float GetMonto
        {
            get => monto;
        }

        public float SetMonto
        {
            set => monto = value;

        }

        public bool SonDeFechaYHoraSede(Sede sede)
        {
            bool resultado = false;

            DateTime fechaActual = DateTime.Today;
            TimeSpan horaActual = DateTime.Now.TimeOfDay;
            if (sede == this.sede && this.fechaVenta == fechaActual && this.horaVenta == horaActual)
            {
                resultado = true;


            }



            return resultado;

        }



    }
}
