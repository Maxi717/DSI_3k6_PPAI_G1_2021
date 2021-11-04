using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class TarifaAD : IPersistencia
    {
        public Object Materializar(int id)
        {
            // Hace una llamada a la base de datos y trae el objeto correspondiente            

            var db = new DSI_PPAI_G1Entities4();

            var objetoPersistente = db.TarifaPersistente.First(x => x.idTipoVisita == id);

            Tarifa objeto = new Tarifa();

            objeto.SetId(objetoPersistente.idTipoVisita);
            objeto.SetFechaFinVigencia(objetoPersistente.fechaFinVigencia);
            objeto.SetFechaInicioVigencia(objetoPersistente.fechaInicioVigencia);
            objeto.SetMonto(objetoPersistente.monto);
            objeto.SetMontoAdicionalGuia(objetoPersistente.montoAdicionalGuia);           
            TipoEntradaAD tipoEntAD = new TipoEntradaAD();
            TipoEntrada tipoEnt = (TipoEntrada) tipoEntAD.Materializar(objetoPersistente.idTipoDeEntrada);

            TipoVisitaAD tipoVisitaAD = new TipoVisitaAD();
            TipoVisita tipoVisita = (TipoVisita)tipoVisitaAD.Materializar(objetoPersistente.idTipoVisita);

            return objeto;
        }

        public bool Desmaterializar(Object objeto)
        {
            return false;
        }




    }
}
