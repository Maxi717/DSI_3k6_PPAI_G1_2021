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


        public string GetNombre()
        {
            return this.nombre;

        }
        public void SetNombre(string valor)
        {

            this.nombre = valor;
        }

        public string GetApellido()
        {
            return this.apellido;

        }
        public void SetApellido(string apellido)
        {

            this.apellido = apellido;
        }

        public int GetCuit()
        {
            return this.cuit;

        }
        public void SetCuit(int value)
        {

            this.cuit = value;
        }

        public int GetDni()
        {
            return this.dni;

        }
        public void SetDni(int value)
        {

            this.dni = value;
        }

        public int GetCodigoValidacion()
        {
            return this.codigoValidacion;

        }
        public void SetCodigoValidacion(int value)
        {
            this.codigoValidacion = value;
        }

        public DateTime GetFechaIngreso()
        {
            return this.fechaIngreso;

        }
        public void SetFechaIngreso(DateTime value)
        {

            this.fechaIngreso = value;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public void SetFechaNacimiento(DateTime value)
        {

            this.fechaNacimiento = value;
        }


        public string GetCorreo()
        {
            return this.correo;

        }
        public void SetCorreo(string value)
        {

            this.correo = value;
        }

        public string GetSexo()
        {
            return this.sexo;

        }
        public void SetSexo(string sexo)
        {

            this.sexo = sexo;
        }

        public int GetTelefono()
        {
            return this.telefono;

        }
        public void SetTelefono(int value)
        {

            this.telefono = value;
        }

        public Sede GetSede()
        {
            return this.sedeDondeTrabaja;

        }

        public void SetSede(Sede value)
        {

            this.sedeDondeTrabaja = value;
        }

        public string GetDomicilio()
        {
            return this.domicilio;

        }
        public void SetDomicilio(string value)
        {

            domicilio = value;
        }

        public Sede ObtenerSede()
        {
            return this.sedeDondeTrabaja;
        }
    }
}