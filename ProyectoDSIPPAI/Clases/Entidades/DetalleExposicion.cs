using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class DetalleExposicion
    {
        private string lugarAsignado;
        private Obra obra;
        

        public string GetLugarAsignado()
        {
            return this.lugarAsignado;
        }
        public Obra GetObra()
        { 
            return this.obra;
        }

        public void SetObra(Obra nuevaObra)
        {
            this.obra = nuevaObra;
        }

        public void SetLugarAsignado(string nuevoLugar)
        {
            this.lugarAsignado = nuevoLugar;
        }

        public int BuscarDuracionObras()
        {
            obra = this.GetObra();
            return obra.GetDuracionResumida();
        }

        public int GetId()
        {
            return this.obra.GetCodigoSensor();
        }



    }
}
