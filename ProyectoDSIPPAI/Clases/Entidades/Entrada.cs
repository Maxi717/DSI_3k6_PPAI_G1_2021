using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Entrada
    {
        DateTime fechaVenta;
        TimeSpan horaVenta;
        int numero;
        float monto;

        Sede sede;
        Tarifa tarifa;

        public DateTime GetFechaVenta()
        {
            return this.fechaVenta;

        }
        public void SetFechaVenta(DateTime valor)
        {

            this.fechaVenta = valor;
        }

        public TimeSpan GetHoraVenta()
        {
            return this.horaVenta;

        }
        public void SetHoraVenta(TimeSpan valor)
        {

            this.horaVenta = valor;
        }

        public int GetNumero()
        {
            return this.numero;

        }
        public void SetNumero(int valor)
        {

            this.numero = valor;
        }

        public Sede GetSede()
        {
            return this.sede;

        }
        public void SetSede(Sede valor)
        {

            this.sede = valor;
        }

        public float GetMonto()
        {
            return this.monto;

        }
        public void SetMonto(int valor)
        {

            this.monto = valor;
        }


        public bool SonDeFechaYHoraSede(DateTime fechaActual, Sede sede)
        {
            bool resultado = false;

            DateTime fecha = fechaActual.Date;
            int hora = fechaActual.TimeOfDay.Hours;
            if (sede == this.sede && this.fechaVenta == fecha && this.horaVenta.Hours == hora )
            {
                resultado = true;

            }



            return resultado;

        }
    }
}
