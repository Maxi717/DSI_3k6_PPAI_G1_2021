using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Tarifa
    {
        private DateTime fechaFinVigencia;
        private DateTime fechaInicioVigencia;
        private float monto;
        private float montoAdicionalGuia;
        private TipoEntrada tipoEntrada;
        private TipoVisita tipoVisita;
        private int id;
        public void SetFechaFinVigencia(DateTime fechaNueva)
        {
            this.fechaFinVigencia = fechaNueva;
        }

        public void SetFechaInicioVigencia(DateTime fechaNueva)
        {
            this.fechaInicioVigencia = fechaNueva;
        }

        public void SetMonto(float montoNuevo)
        {
            this.monto = montoNuevo;
        }

        public void SetMontoAdicionalGuia(float montoNuevo)
        {
            this.montoAdicionalGuia = montoNuevo;
        }

        public void SetTipoEntrada(TipoEntrada tipoEntradaNueva)
        {
            this.tipoEntrada = tipoEntradaNueva;
        }

        public void SetTipoVisita(TipoVisita tipoVisitaNueva)
        {
            this.tipoVisita = tipoVisitaNueva;
        }

        public string ConocerTipoVisita()
        {
            return tipoVisita.ConocerNombre();
        }

        public string ConocerTipoEntrada()
        {
            return tipoEntrada.MostrarNombre();
        }


        public List<string> MostrarMontosVigentes()
        {
            List<string> lista = new List<string>();

            int resultado = DateTime.Compare(fechaFinVigencia, DateTime.Now);

            if (resultado >= 0)
            {
                lista.Add(monto.ToString());
                lista.Add(this.tipoEntrada.MostrarNombre());
                lista.Add(this.tipoVisita.MostrarNombre());
            }                        
            
            return lista;
        }

        public DateTime GetFechaFinVigencia()
        {
            return this.fechaFinVigencia;
        }

        public float GetMonto()
        {
            return this.monto;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }
    }
}
