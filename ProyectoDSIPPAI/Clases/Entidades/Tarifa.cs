using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Tarifa
    {
        public DateTime fechaFinVigencia { get; set; }
        public DateTime fechaInicioVigencia { get; set; }
        public int monto { get; set; }
        public int montoAdicionalGuia { get; set; }
        public TipoEntrada tipoEntrada { get; set; }
        public TipoVisita tipoVisita { get; set; }

        public string ConocerTipoVisita()
        {
            return tipoVisita.ConocerNombre();
        }

        public string ConocerTipoEntrada()
        {
            return tipoEntrada.mostrarNombre();
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
    }
}
