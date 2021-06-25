using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    class Usuario
    {
        private DateTime caducidad;
        private string nombre;
        private string contra;
        private Empleado empleado;


        public Usuario(DateTime caducidad, string nombre, string contra, Empleado empleado)
        {
            this.caducidad = caducidad;
            this.nombre = nombre;
            this.contra = contra;
            this.empleado = empleado;
        }
        public Usuario()
        {

        }
        public DateTime Caducidad
        {
            get => caducidad;
            set => caducidad = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Contra
        {
            get => contra;
            set => contra = value;
        }
        public Empleado Empleado
        {
            get => empleado;
            set => empleado = value;
        }

        public Empleado ObtenerEmpleado()
        {
            return this.empleado;
        }

    }
}
