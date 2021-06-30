using ProyectoDSIPPAI.Clases.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Sede
    {
        private int cantidadMaximaVisitantes;
        private int cantMaxPorGuia;
        private string nombre;
        private List<Tarifa> tarifas;
        private List<Exposicion> exposiciones;

        public Sede(int cantidadMaximaVisitntes, int cantMaxPorGuia, string nombre, List<Tarifa> tarifas, List<Exposicion> exposiciones)
        {
            this.cantidadMaximaVisitantes = cantidadMaximaVisitntes;
            this.cantMaxPorGuia = cantMaxPorGuia;
            this.nombre = nombre;
            this.tarifas = tarifas;
            this.exposiciones = exposiciones;
        }

        public Sede()
        {

        }

        public int GetCantidadMaximaVisitantes()
        {
            return this.cantidadMaximaVisitantes;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetCantidadMaximaVisitantes(int nuevaCantidadMaxima)
        {
            this.cantidadMaximaVisitantes = nuevaCantidadMaxima;
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
            this.tarifas = nuevasTarifas;
        }
        public void SetExposiciones(List<Exposicion> nuevaExposiciones)
        {
            this.exposiciones = nuevaExposiciones;
        }

        // EN EL DIAGR. DE CLASES ESTÁ COMO  getCantidadMaximaVisitntes()
        public int MostrarCantidadMaximaVisitantes()
        {
            return this.cantidadMaximaVisitantes;
        }


        public List<List<string>> ObtenerTarifasVigentes(GestorVentaEntrada gestor)
        {
            List<List<string>> tarifasVigentesStrings = new List<List<string>>();
            List<Tarifa> tarifasVigentes = new List<Tarifa>();
            for (int i = 0; i < this.tarifas.Count; i++)
            {

                List<string> montosVigentes = this.tarifas[i].MostrarMontosVigentes();
                if (montosVigentes.Count() != 0)
                {
                    tarifasVigentesStrings.Add(montosVigentes);
                    tarifasVigentes.Add(this.tarifas[i]);
                }
                else
                {
                }
            }

            gestor.SetTarifas(tarifasVigentes);
            return tarifasVigentesStrings;
        }



        public int CalcularDuracionExposicionesVigentes()
        {
            int duracionExpoVigentes = 0;

            List<Exposicion> exposicionesVigentes = new List<Exposicion>();
            foreach (Exposicion exposicion in this.exposiciones)
            {
                bool vigencia = exposicion.EsVigente();
                if (vigencia)
                {
                    exposicionesVigentes.Add(exposicion);
                }
            }

            for (int i = 0; i < exposicionesVigentes.Count; i++)
            {                
                duracionExpoVigentes += exposicionesVigentes[i].CalcularDuracionObrasExpuestas();
            }

            return duracionExpoVigentes;

        }
    }
}