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
