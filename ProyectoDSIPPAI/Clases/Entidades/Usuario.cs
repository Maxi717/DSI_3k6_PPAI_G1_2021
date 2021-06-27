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
        private int empleado;


        public Usuario(DateTime caducidad, string nombre, string contra, int empleado)
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
        public int Empleado
        {
            get => empleado;
            set => empleado = value;
        }

    }
}
