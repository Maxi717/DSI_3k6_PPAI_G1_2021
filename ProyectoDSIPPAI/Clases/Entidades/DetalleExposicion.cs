using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class DetalleExposicion
    {
        string lugarAsignado;
        Obra obra;

        public string LugarAsignado {
            get => lugarAsignado;
            set => lugarAsignado = value;

        }

        public Obra Obra
        {
            get => obra;
            set => obra = value;
        }

        public int buscar_duracion_obras()
        {
            return this.Obra.GetDuracionResumida();
        }

    }
}
