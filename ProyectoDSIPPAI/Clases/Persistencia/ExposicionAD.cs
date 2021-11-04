using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class ExposicionAD : IPersistencia
    {
        public Object Materializar(int id)
        {
            var db = new DSI_PPAI_G1Entities4();

            var objetoPersistente = db.ExposicionPersistente.First(x => x.idExposicion == id);

            Exposicion objeto = new Exposicion();
            objeto.SetNombre(objetoPersistente.nombre);
            objeto.SetId(objetoPersistente.idExposicion);

            List<DetalleExposicion> lista = new List<DetalleExposicion>();
            foreach(var detalle in objetoPersistente.DetalleExposicionPersistente)
            {
                DetalleExposicion detalleAAgregar = new DetalleExposicion();
                detalleAAgregar.SetLugarAsignado(detalle.lugarAsignado);
                ObraAD detalleAD = new ObraAD();

                detalleAAgregar.SetObra((Obra)detalleAD.Materializar(detalle.idObra));
                lista.Add(detalleAAgregar);
            }

            objeto.SetDetallesExposicion(lista);


            return objeto;
        }

        public bool Desmaterializar(Object objeto)
        {
            return false;
        }





    }
}
