using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Obra
    {
        private float alto;
        private float ancho;
        private int codigoSensor;
        private string descripcion;
        private int duracionExtendida;
        private int duracionResumida;
        private DateTime fechaCreacion;
        private DateTime fechaPrimerIngreso;
        private string  nombreObra;
        private float peso;
        private float valuacion;


        public int GetDuracionResumida()
        {

            return this.duracionResumida;

        }



    }
}
