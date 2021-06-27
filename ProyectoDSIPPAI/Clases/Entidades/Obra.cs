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
        private string nombreObra;
        private float peso;
        private float valuacion;

        public Obra(float alto, float ancho, int codigoSensor, string descripcion, int duracionExtendida, int duracionResumida, DateTime fechaCreacion, DateTime fechaPrimerIngreso, string nombreObra, float peso, float valuacion)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.codigoSensor = codigoSensor;
            this.descripcion = descripcion;
            this.duracionExtendida = duracionExtendida;
            this.duracionResumida = duracionResumida;
            this.fechaCreacion = fechaCreacion;
            this.fechaPrimerIngreso = fechaPrimerIngreso;
            this.nombreObra = nombreObra;
            this.peso = peso;
            this.valuacion = valuacion;
        }

        public float Alto
        {

            get => alto;
            set => alto = value;

        }
        public float Ancho
        {

            get => ancho;
            set => ancho = value;

        }
        public int CodigoSensor
        {

            get => codigoSensor;
            set => codigoSensor = value;

        }
        public string Descripcion
        {

            get => descripcion;
            set => descripcion = value;

        }
        public int DuracionExtendida
        {

            get => duracionExtendida;
            set => duracionExtendida = value;

        }
        public int DuracionResumida
        {

            get => duracionResumida;
            set => duracionResumida = value;

        }
        public DateTime FechaCreacion
        {

            get => fechaCreacion;
            set => fechaCreacion = value;

        }
        public DateTime FechaPrimerIngreso
        {

            get => fechaPrimerIngreso;
            set => fechaPrimerIngreso = value;

        }
        public string NombreObra
        {

            get => nombreObra;
            set => nombreObra = value;

        }
        public float Peso
        {

            get => peso;
            set => peso = value;

        }
        public float Valuacion
        {

            get => valuacion;
            set => valuacion = value;

        }

        public int GetDuracionResumida()
        {
            return this.duracionResumida;
        }
    }
}