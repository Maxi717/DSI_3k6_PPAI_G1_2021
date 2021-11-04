using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class SedeAD : IPersistencia
    {
        public Object Materializar(int id)
        {
            var db = new DSI_PPAI_G1Entities4();

            var sedePersistente = db.SedePersistente.First(x => x.idSede == id);

            Sede sede = new Sede();
            sede.SetNombre(sedePersistente.nombre);
            sede.SetCantidadMaximaVisitantes(sedePersistente.cantMaximaVisitantes);
            sede.SetCantMaxPorGuia(sedePersistente.cantMaxPorGuia);
            
            List<Exposicion> listaExposiciones = new List<Exposicion>();
            foreach (var exposicion in sedePersistente.ExposicionPersistente)
            {               

                List<DetalleExposicion> listaDetalle = new List<DetalleExposicion>();
                foreach (var detalle in exposicion.DetalleExposicionPersistente)
                {
                    DetalleExposicion detalleAAgregar = new DetalleExposicion();
                    detalleAAgregar.SetLugarAsignado(detalle.lugarAsignado);
                    ObraAD obraAD = new ObraAD();                    

                    detalleAAgregar.SetObra((Obra)obraAD.Materializar(detalle.idObra));
                    listaDetalle.Add(detalleAAgregar);
                }

                ExposicionAD detalleAD = new ExposicionAD();
                Exposicion exposicionAAgregar = (Exposicion)detalleAD.Materializar(exposicion.idExposicion);
                
                listaExposiciones.Add(exposicionAAgregar);
            }

            sede.SetExposiciones(listaExposiciones);                         
            sede.SetId(sedePersistente.idSede);

            return sede;
        }

        public bool Desmaterializar(Object objeto)
        {
            return false;
        }



    }
}
