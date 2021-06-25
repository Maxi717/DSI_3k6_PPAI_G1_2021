using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
        public class ReservaVisita
        {
            private int cantidad_alumnos;
            private int cantidad_alumnos_confirmada;
            private int duracion_estimada;
            private DateTime fecha_hora_creacion;
            private DateTime fecha_hora_reserva;
            private DateTime hora_fin_real;
            private DateTime hora_inicio_real;
            private int numero_reserva;
            private string sede;


            public ReservaVisita(int cantidad_alumnos, int cantidad_alumnos_confirmada, int duracion_estimada, DateTime fecha_hora_creacion, DateTime fecha_hora_reserva, DateTime hora_fin_real, DateTime hora_inicio_real, int numero_reserva, string sede)
            {
                this.cantidad_alumnos = cantidad_alumnos;
                this.cantidad_alumnos_confirmada = cantidad_alumnos_confirmada;
                this.duracion_estimada = duracion_estimada;
                this.fecha_hora_creacion = fecha_hora_creacion;
                this.fecha_hora_reserva = fecha_hora_reserva;
                this.hora_fin_real = hora_fin_real;
                this.hora_inicio_real = hora_inicio_real;
                this.numero_reserva = numero_reserva;
                this.sede = sede;
            }
            public ReservaVisita()
            {

            }
            public int Cant_maxima_visitantes
            {
                get => cantidad_alumnos;
                set => cantidad_alumnos = value;
            }
            public int Cantidad_alumnos_confirmada
            {
                get => cantidad_alumnos_confirmada;
                set => cantidad_alumnos_confirmada = value;
            }
            public int Duracion_estimada
            {
                get => duracion_estimada;
                set => duracion_estimada = value;
            }
            public DateTime Fecha_hora_creacion
            {
                get => fecha_hora_creacion;
                set => fecha_hora_creacion = value;
            }
            public DateTime Fecha_hora_reserva
            {
                get => fecha_hora_reserva;
                set => fecha_hora_reserva = value;
            }
            public DateTime Hora_fin_real
            {
                get => hora_fin_real;
                set => hora_fin_real = value;
            }
            public DateTime Hora_inicio_real
            {
                get => hora_inicio_real;
                set => hora_inicio_real = value;
            }
            public int Numero_reserva
            {
                get => numero_reserva;
                set => numero_reserva = value;
            }
            public string Sede
            {
                get => sede;
                set => sede = value;
            }
        }
    }
