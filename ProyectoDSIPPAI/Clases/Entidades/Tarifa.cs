using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Tarifa
    {
        public DateTime fecha_fin_vigencia { get; set; }
        public DateTime fecha_inicio_vigencia { get; set; }
        public int monto { get; set; }
        public int monto_adicional_guia { get; set; }
        public TipoEntrada tipo_entrada { get; set; }
        public TipoVisita tipo_visita { get; set; }

        public string conocer_tipo_visita()
        {
            return tipo_visita.mostrar_nombre();
        }

        public string conocer_tipo_entrada()
        {
            return tipo_visita.tipo_entrada.mostar_nombre();
        }

        public List<string> mostrar_montos_vigentes()
        {
            if (fecha_fin_vigencia >= DateTime.now())
            {
                List<string> lista = new List<string>();
                lista.Add(monto.ToString());
                lista.Add(this.conocer_tipo_entrada());
                lista.Add(this.conocer_tipo_visita());
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
