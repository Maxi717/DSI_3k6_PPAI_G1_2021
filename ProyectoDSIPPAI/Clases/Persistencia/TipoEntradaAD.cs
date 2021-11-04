using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class TipoEntradaAD : IPersistencia
    {
        public Object Materializar(int id)
        {
            var db = new DSI_PPAI_G1Entities4();

            var tipoEntradaPersistente = db.TipoDeEntradaPersistente.First(x => x.idTipoDeEntrada == id);

            TipoEntrada tipoEntrada = new TipoEntrada();
            tipoEntrada.SetNombre(tipoEntradaPersistente.nombre);
            tipoEntrada.SetId(tipoEntradaPersistente.idTipoDeEntrada);
            return tipoEntrada;
        }

        public bool Desmaterializar(Object objeto)
        {
            return false;
        }
      

    }
}
