using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class TipoVisita
    {
        private string nombre { get; set; }

        public void SetNombre(string nombreNuevo)
        {
            this.nombre = nombreNuevo;
        }

        public string ConocerNombre()
        {
            return nombre;
        }

        public string MostrarNombre()
        {
            return nombre;
        }
    }
}
