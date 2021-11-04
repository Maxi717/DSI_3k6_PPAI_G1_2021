using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Usuario
    {
        private DateTime caducidad;
        private string nombre;
        private string contra;
        private Empleado empleado;
        private int id;

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

        public string GetNombre()
        {
            return this.nombre;

        }
        public void SetNombre(string valor)
        {

            this.nombre = valor;
        }

        public DateTime GetCaducidad()
        {
            return this.caducidad;

        }
        public void SetCaducidad(DateTime valor)
        {

            this.caducidad = valor;
        }

        public string GetContraseña()
        {
            return this.contra;

        }
        public void SetContraseña(string valor)
        {

            this.contra = valor;
        }

        public Empleado GetEmpleado()
        {
            return this.empleado;

        }
        public void SetEmpleado(Empleado valor)
        {

            this.empleado = valor;
        }

        public Empleado ObtenerEmpleado()
        {
            return this.empleado;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }


    }
}
