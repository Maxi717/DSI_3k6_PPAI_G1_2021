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

        public string GetLugarAsignado
        {
            get => lugarAsignado;
        }
        public string SetLugarAsignado
        { 
            set => lugarAsignado = value;
        }

        public Obra GetObra
        {
            get => obra;
        }
        public Obra SetObra
        {
            set => obra = value;
        }

        public int BuscarDuracionObras()
        {
            return this.GetObra.GetDuracionResumida();
        }

    }
}
