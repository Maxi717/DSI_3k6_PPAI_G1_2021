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

        public string GetNombre
        {
            get => nombre;

        }
        public string SetNombre
        {

            set => nombre = value;
        }

        public string GetApellido
        {
            get => apellido;

        }
        public string SetApellido
        {

            set => apellido = value;
        }

        public int GetCuit
        {
            get => cuit;

        }
        public int SetCuit
        {

            set => cuit = value;
        }

        public int GetDni
        {
            get => dni;

        }
        public int SetDni
        {

            set => dni = value;
        }

        public int GetCodigoValidacion
        {
            get => codigoValidacion;

        }
        public int SetCodigoValidacion
        {

            set => codigoValidacion = value;
        }

        public DateTime GetFechaIngreso
        {
            get => fechaIngreso;

        }
        public DateTime SetFechaIngreso
        {

            set => fechaIngreso = value;
        }

        public DateTime GetFechaNacimiento
        {
            get => fechaNacimiento;

        }
        public DateTime SetFechaNacimiento
        {

            set => fechaNacimiento = value;
        }


        public string GetCorreo
        {
            get => correo;

        }
        public string SetCorreo
        {

            set => correo = value;
        }

        public string GetSexo
        {
            get => sexo;

        }
        public string SetSexo
        {

            set => sexo = value;
        }

        public int GetTelefono
        {
            get => telefono;

        }
        public int SetTelefono
        {

            set => telefono = value;
        }





        //Creo que un ConocerSede serìa mas correcto en lugar de un get
        public Sede GetSede
        {
            get => sedeDondeTrabaja;

        }

        public Sede SetSede
        {

            set => sedeDondeTrabaja = value;
        }

        public string GetDomicilio
        {
            get => domicilio;

        }
        public string SetDomicilio
        {

            set => domicilio = value;
        }


        // Metodos originales, eliminar aquellos que no tengan referencias
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


    }
}
