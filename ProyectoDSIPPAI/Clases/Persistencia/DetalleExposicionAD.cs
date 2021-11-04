using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class DetalleExposicionAD : IPersistencia
    {

        public Object Materializar(int id)
        {
            return false;
        }

        public Object materializar(int idObra, int idExposicion)
        {
            var db = new DSI_PPAI_G1Entities4();

            var detallePersistente = db.DetalleExposicionPersistente.First(x => x.idObra == idObra && x.idExposicion == idExposicion);

            DetalleExposicion detalle = new DetalleExposicion();
            ObraAD obraAD = new ObraAD();
            Obra obra = (Obra) obraAD.Materializar(idObra);

            detalle.SetObra(obra);
            detalle.SetLugarAsignado(detallePersistente.lugarAsignado);

            return detalle;
        }


        public bool Desmaterializar(Object objeto)
        {
            return false;
        }



    }
}
