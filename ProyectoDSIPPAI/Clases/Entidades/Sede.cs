using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Sede
    {
        private int cantidadMaximaVisitntes;
        private int cantMaxPorGuia;
        private string nombre;
        private List<Tarifa> tarifas;
        private List<Exposicion> exposiciones;

        public Sede(int cantidadMaximaVisitntes, int cantMaxPorGuia, string nombre, List<Tarifa> tarifas, List<Exposicion> exposiciones)
        {
            this.cantidadMaximaVisitntes = cantidadMaximaVisitntes;
            this.cantMaxPorGuia = cantMaxPorGuia;
            this.nombre = nombre;
            this.tarifas = tarifas;
            this.exposiciones = exposiciones;
        }

        public Sede()
        {

        }

        public void SetCantidadMaximaVisitantes(int nuevaCantidadMaxima)
        {
            this.cantidadMaximaVisitntes = nuevaCantidadMaxima;
        }
        public void SetCantMaxPorGuia(int nuevaCantMax)
        {
            this.cantMaxPorGuia = nuevaCantMax;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetTarifas(List<Tarifa> nuevasTarifas)
        {
            this.tarifas = tarifas;
        }
        public void SetExposiciones(List<Exposicion> nuevaExposiciones)
        {
            this.exposiciones = exposiciones;
        }

        // EN EL DIAGR. DE CLASES ESTÁ COMO  getCantidadMaximaVisitntes()
        public int MostrarCantidadMaximaVisitantes()
        {
            return this.cantidadMaximaVisitntes;
        }


        public List<List<string>> ObtenerTarifasVigentes()
        {
            List<List<string>> tarifasVigentes = new List<List<string>>();
            for (int i = 0; i < this.tarifas.Count; i++)
            {
                // ALTERNATIVAS
                // if (Tarifa.mostrar_montos_vigentes() != List<string>())
                //if (Tarifa.mostrar_montos_vigentes().Count() == 0)

                List<string> montosVigentes = this.tarifas[i].MostrarMontosVigentes();
                if (montosVigentes.Count() != 0)
                {
                    tarifasVigentes.Add(montosVigentes);
                }
                else
                {
                }
            }
            return tarifasVigentes;
        }

        public int CalcularDuracionExposicionesVigentes()
        {
            int duracionExpoVigentes = 0;
            for (int i = 0; i < this.exposiciones.Count; i++)
            {
                bool vigencia = this.exposiciones[i].EsVigente();
                if (vigencia == true)
                {
                    duracionExpoVigentes += this.exposiciones[i].CalcularDuracionObrasExpuestas();
                }
                else
                {
                }
            }

            return duracionExpoVigentes;

        }
    }
}