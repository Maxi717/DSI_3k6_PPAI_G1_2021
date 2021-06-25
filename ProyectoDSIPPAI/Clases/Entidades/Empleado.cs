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
        int codigo_validacion;
        int cuit;
        int dni;
        string domicilio;
        DateTime fecha_ingreso;
        DateTime fecha_nacimiento;
        string correo;
        string nombre;
        string sexo;
        int telefono;
        Sede sedeDondeTrabaja;

        public string GetNombre
        {
            get => nombre;            
                
        }
        public Sede ObtenerSede
        {
            get => sedeDondeTrabaja;
        }

    }
}
