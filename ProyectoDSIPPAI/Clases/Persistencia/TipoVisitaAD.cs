using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class TipoVisitaAD : IPersistencia
    {
        public Object Materializar(int id)
        {
            var db = new DSI_PPAI_G1Entities4();

            var objetoPersistente = db.TipoVisitaPersistente.First(x => x.idTipoVisita == id);

            TipoVisita objeto = new TipoVisita();
            objeto.SetNombre(objetoPersistente.nombre);
            objeto.SetId(objetoPersistente.idTipoVisita);        

            return objeto;
        }

        public bool Desmaterializar(Object objeto)
        {
            return false;
        }



    }
}
