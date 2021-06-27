using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Sesion
    {
        private DateTime fecha_fin;
        private DateTime fecha_inicio;
        private DateTime hora_fin;
        private DateTime hora_inicio;
        private Usuario usuario;


        public Sesion(DateTime fecha_fin, DateTime fecha_inicio, DateTime hora_fin, DateTime hora_inicio)
        {
            this.fecha_fin = fecha_fin;
            this.fecha_inicio = fecha_inicio;
            this.hora_fin = hora_fin;
            this.hora_inicio = hora_inicio;
        }
        public Sesion()
        {

        }
        public DateTime Fecha_fin
        {
            get => fecha_fin;
            set => fecha_fin = value;
        }
        public DateTime Fecha_inicio
        {
            get => fecha_inicio;
            set => fecha_inicio = value;
        }
        public DateTime Hora_fin
        {
            get => hora_fin;
            set => hora_fin = value;
        }
        public DateTime Hora_inicio
        {
            get => hora_inicio;
            set => hora_inicio = value;
        }

        public Usuario conocer_usuario()
        {
            return usuario.getUsuario();
        }
        
        public string get_empleado_en_sesion()
        {
            return usuario.conocer_empleado();
        }
    }
}
