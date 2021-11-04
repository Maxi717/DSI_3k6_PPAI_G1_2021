using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class EmpleadoAD : IPersistencia
    {
        public Object Materializar(int id)
        {
            var db = new DSI_PPAI_G1Entities4();

            var empleadoPersistente = db.EmpleadoPersistente.First(x => x.idEmpleado == id);

            Empleado empleado = new Empleado();
            empleado.SetApellido(empleadoPersistente.apellido);
            empleado.SetCodigoValidacion(empleadoPersistente.codigoValidacion);
            empleado.SetCorreo(empleadoPersistente.correo);
            empleado.SetCuit((int)empleadoPersistente.cuit);
            empleado.SetDni(empleadoPersistente.dni);
            empleado.SetDomicilio(empleadoPersistente.domicili);
            empleado.SetFechaIngreso(empleadoPersistente.fechaIngreso);
            empleado.SetFechaNacimiento(empleadoPersistente.fechaNacimiento);
            empleado.SetId(empleadoPersistente.idEmpleado);
            empleado.SetNombre(empleadoPersistente.nombre);            
            empleado.SetSexo(empleadoPersistente.sexo);                       
            
            return empleado;
        }

        public bool Desmaterializar(Object objeto)
        {
            return false;
        }



    }
}
