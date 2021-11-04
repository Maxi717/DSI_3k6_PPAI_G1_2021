using ProyectoDSIPPAI.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    class EntradaAD : IPersistencia
    {
        public Object Materializar(int id)
        {
            var db = new DSI_PPAI_G1Entities4();

            var entradaPersistente = db.EntradaPersistente.First(x => x.idEntrada == id);

            Entrada objeto = new Entrada();
            objeto.SetFechaVenta(entradaPersistente.fechaVenta);
            objeto.SetHoraVenta(entradaPersistente.horaVenta);            
            objeto.SetMonto(entradaPersistente.monto);
            objeto.SetNumero(entradaPersistente.idEntrada);

            SedeAD sedeAD = new SedeAD();
            Sede sede =(Sede) sedeAD.Materializar(entradaPersistente.idSede);
            objeto.SetSede(sede);

            TarifaAD tarifaAD = new TarifaAD();
            Tarifa tarifa = (Tarifa)tarifaAD.Materializar(entradaPersistente.idTarifa);

            objeto.SetTarifa(tarifa);            

            return objeto;
        }

        public bool Desmaterializar(Object objeto)
        {

            try
            {
                Entrada entrada = (Entrada)objeto;
                var db = new DSI_PPAI_G1Entities4();

                EntradaPersistente entradaPersistente = new EntradaPersistente();
                entradaPersistente.fechaVenta = entrada.GetFechaVenta();
                entradaPersistente.horaVenta = entrada.GetHoraVenta();
                entradaPersistente.idEntrada = entrada.GetNumero();
                entradaPersistente.idSede = entrada.GetSede().GetId();
                entradaPersistente.idTarifa = entrada.GetTarifa().GetId();
                entradaPersistente.monto = (int)entrada.GetMonto();

                db.EntradaPersistente.Add(entradaPersistente);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Desmaterializar()
        {
            return false;
        }

        public List<Entrada> ObtenerEntradas()
        {
            var db = new DSI_PPAI_G1Entities4();
            List<EntradaPersistente> entradaPersistentes = db.EntradaPersistente.Where(x => true).ToList();

            List<Entrada> resultados = new List<Entrada>();
            foreach (EntradaPersistente entradaIterable in entradaPersistentes)
            {

                Entrada entrada = (Entrada)this.Materializar(entradaIterable.idEntrada);
                resultados.Add(entrada);

            }

            return resultados;

        }



    }
}
