using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class ObraAD : IPersistencia
    {
        public Object Materializar(int id)
        {
            var db = new DSI_PPAI_G1Entities4();

            var obraPersistente = db.ObraPersistente.First(x => x.codigoSensor == id);

            Obra obra = new Obra();
            obra.SetAlto((float)obraPersistente.alto);
            obra.SetAncho((float)obraPersistente.ancho);
            obra.SetCodigoSensor(obraPersistente.codigoSensor);
            obra.SetDescripcion(obraPersistente.descripcion);
            obra.SetDuracionExtendida(obraPersistente.duracionExtendida);
            obra.SetDuracionResumida(obraPersistente.duracionResumida);
            obra.SetFechaCreacion(obraPersistente.fechaCreacion);
            obra.SetFechaPrimerIngreso(obraPersistente.fechaPrimerIngreso);
            obra.SetNombreObra(obraPersistente.nombreObra);
            obra.SetPeso((float)obraPersistente.peso);
            obra.SetValuacion((float)obraPersistente.valuacion);

            EmpleadoAD empleadoAD = new EmpleadoAD();
            Empleado empleado = (Empleado) empleadoAD.Materializar(obraPersistente.idEmpleado);
            obra.SetEmpleado(empleado);


            return obra;
        }

        public bool Desmaterializar(Object objeto)
        {
            return false;
        }


    }
}
