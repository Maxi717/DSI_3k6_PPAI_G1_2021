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
        public int CantidadMaximaVisitntes
        {
            get => cantidadMaximaVisitntes;
            set => cantidadMaximaVisitntes = value;
        }
        public int CantMaxPorGuia
        {
            get => cantMaxPorGuia;
            set => cantMaxPorGuia = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public List<Tarifa> Tarifas
        {
            get => tarifas;
            set => tarifas = value;
        }
        public List<Exposicion> Exposiciones
        {
            get => exposiciones;
            set => exposiciones = value;
        }

        // EN EL DIAGR. DE CLASES ESTÁ COMO  getCantidadMaximaVisitntes()
        public int mostrarCantidadMaximaVisitantes()
        {
            return this.cantidadMaximaVisitntes;
        }


        public List<List<string>> obtenerTarifasVigentes()
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

        public int calcularDuracionExposicionesVigentes()
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