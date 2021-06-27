using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Tarifa
    {
        private DateTime fechaFinVigencia { get; set; }
        private DateTime fechaInicioVigencia { get; set; }
        private int monto { get; set; }
        private int montoAdicionalGuia { get; set; }
        private TipoEntrada tipoEntrada { get; set; }
        private TipoVisita tipoVisita { get; set; }

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
            if (fechaFinVigencia >= DateTime.Now)
            {
                List<string> lista = new List<string>();
                lista.Add(monto.ToString());
                lista.Add(this.ConocerTipoEntrada());
                lista.Add(this.ConocerTipoVisita());
                return lista;
            }
            else
            {
                List<string> lista = new List<string>();
                return lista;
            }
        }

        public DateTime GetFechaFinVigencia()
        {
            return this.fechaFinVigencia;
        }
    }
}
