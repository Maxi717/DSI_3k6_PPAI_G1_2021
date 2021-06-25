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

        public int GetNumero 
        {
            get => numero;
            set => numero = value;
        }

        public Sede GetSede
        {
            get => sede;
            set => sede = value;

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
