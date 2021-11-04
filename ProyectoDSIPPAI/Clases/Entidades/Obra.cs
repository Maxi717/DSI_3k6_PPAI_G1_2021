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
        private Empleado empleadoCreo;
        
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
        public Obra()
        {

        }
        public void SetAlto(float nuevoAlto)
        {
            this.alto = nuevoAlto;
        }

        public void SetEmpleado(Empleado nuevoEmp)
        {
            this.empleadoCreo = nuevoEmp;
        }

        public void SetAncho(float nuevoAncho)
        {
            this.ancho = nuevoAncho;
        }
        public void SetCodigoSensor(int nuevoCodigoSensor)
        {
            this.codigoSensor = nuevoCodigoSensor;
        }
        public void SetDescripcion(string nuevaDescripcion)
        {
            this.descripcion = nuevaDescripcion;
        }
        public void SetDuracionExtendida(int nuevaDuracionExtendida)
        {
            this.duracionExtendida = nuevaDuracionExtendida;
        }
        public void SetDuracionResumida(int nuevaDuracionResumida)
        {
            this.duracionResumida = nuevaDuracionResumida;
        }
        public void SetFechaCreacion(DateTime nuevaFechaCreacion)
        {
            this.fechaCreacion = nuevaFechaCreacion;
        }
        public void SetFechaPrimerIngreso(DateTime nuevaFechaPrimerIngreso)
        {
            this.fechaPrimerIngreso = nuevaFechaPrimerIngreso;
        }
        public void SetNombreObra(string nuevoNombreObra)
        {
            this.nombreObra = nuevoNombreObra;
        }
        public void SetPeso(float nuevoPeso)
        {
            this.peso = nuevoPeso;
        }
        public void SetValuacion(float nuevaValuacion)
        {
            this.valuacion = nuevaValuacion;
        }



        public int GetDuracionResumida()
        {
            int duracion = this.duracionResumida;
            return duracion;
        }

        public int GetCodigoSensor()
        {
            return this.codigoSensor;
        }

    }
}