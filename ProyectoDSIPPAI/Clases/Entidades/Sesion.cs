using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class Sesion
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private TimeSpan horaFin;
        private TimeSpan horaInicio;
        private Usuario usuario;


        public Sesion(DateTime fecha_fin, DateTime fecha_inicio, TimeSpan hora_fin, TimeSpan hora_inicio)
        {
            this.fechaFin = fecha_fin;
            this.fechaInicio = fecha_inicio;
            this.horaFin = hora_fin;
            this.horaInicio = hora_inicio;
        }
        public Sesion()
        {

        }

        public void SetFechaFin(DateTime fecha_fin_nueva)
        {
            this.fechaFin = fecha_fin_nueva;
        }
        public void SetFechaInicio(DateTime fecha_inicio_nueva)
        {
            this.fechaInicio = fecha_inicio_nueva;
        }
        public void SetHoraFin(TimeSpan hora_fin_nueva)
        {
            this.horaFin = hora_fin_nueva;
        }
        public void SetHoraInicio(TimeSpan hora_inicio_nueva)
        {
            this.horaInicio = hora_inicio_nueva;
        }

        public void SetUsuario(Usuario usuario_nuevo)
        {
            this.usuario = usuario_nuevo;
        }

        public Usuario conocer_usuario()
        {
            return usuario.getUsuario();
        }
        
        public string GetEmpleadoEnSesion()
        {
            return usuario.conocer_empleado();
        }
    }
}
