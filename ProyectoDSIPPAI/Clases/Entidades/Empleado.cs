using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Empleado
    {
        string apellido;
        int codigoValidacion;
        int cuit;
        int dni;
        string domicilio;
        DateTime fechaIngreso;
        DateTime fechaNacimiento;
        string correo;
        string nombre;
        string sexo;
        int telefono;
        Sede sedeDondeTrabaja;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public int Cuit
        {
            get => cuit;
            set => cuit = value;
        }
        public int Dni
        {
            get => dni;
            set => dni = value;
        }

        public int CodigoValidacion
        {
            get => codigoValidacion;
            set => codigoValidacion = value;
        }

        public DateTime FechaIngreso
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }

        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        public string Correo
        {
            get => correo;
            set => correo = value;
        }

        public string Sexo
        {
            get => sexo;
            set => sexo = value;
        }

        public Sede Sede
        {
            get => sedeDondeTrabaja;
            set => sedeDondeTrabaja = value;
        }

        public string Domicilio
        {
            get => domicilio;
            set => domicilio = value;
        }

        public int Telefono
        {
            get => telefono;
            set => telefono = value;
        }


        public Sede ObtenerSede()
        {
            return this.sedeDondeTrabaja;
        }


        public string GetNombre()
        {
            return this.nombre;
        }

    }
}
