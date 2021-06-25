using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Sede        
        {
            private int cant_maxima_visitantes;
            private int cant_max_por_guia;
            private string nombre;
            private List <Tarifa>tarifas;
            private List<Exposicion>exposiciones;

        public Sede(int Cant_maxima_visitantes, int Cant_max_por_guia, string Nombre, List<Tarifa> Tarifas, List<Exposicion> Exposiciones)
        {
                this.cant_maxima_visitantes = cant_maxima_visitantes;
                this.cant_max_por_guia = cant_max_por_guia;
                this.nombre = nombre;
                this.tarifas = tarifas;
                this.exposiciones = exposiciones;
            }
            public Sede()
            {

            }
            public int Cant_maxima_visitantes
            {
                get => cant_maxima_visitantes;
                set => cant_maxima_visitantes = value;
            }
            public int Cant_max_por_guia
            {
                get => cant_max_por_guia;
                set => cant_max_por_guia = value;
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


        }
    }
