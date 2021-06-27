using ProyectoDSIPPAI.AccesoADatos;
using ProyectoDSIPPAI.Clases.Entidades;
using ProyectoDSIPPAI.Clases.Fronteras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Gestores
{
    public class GestorVentaEntrada
    {
        private Empleado logueadoEmpleado;
        private List<Tarifa> tarifas;
        private Usuario usuario;


        private GestorVentaEntrada(Empleado logueadoEmpleado, List<Tarifa> tarifas, Usuario usuario)
        {
            this.logueadoEmpleado = logueadoEmpleado;
            this.tarifas = tarifas;
            this.usuario = usuario;
        }

        public Empleado Empleado
        {

            get => logueadoEmpleado;
            set => logueadoEmpleado = value;

        }
        public List<Tarifa> Tarifas
        {

            get => tarifas;
            set => tarifas = value;

        }
        public Usuario Usuario
        {

            get => usuario;
            set => usuario = value;

        }
        public void OpcionVentaEntradas(PantallaVentaEntrada pantalla, Sesion sesion)
        {
            this.logueadoEmpleado = BuscarEmpleadoLogeado(sesion);
            Sede sede = BuscarSede();
            List<Tarifa> tarifas = buscarTarifasDeSede(sede);
            pantalla.MostrarTarifasVigentes(tarifas);
        }
        
        
        private Empleado BuscarEmpleadoLogeado(Sesion sesion)
        {
            Empleado empleado = sesion.GetEmpleadoEnSesion();
            return empleado;
        }

        private Sede BuscarSede()
        {
            Sede sede = this.logueadoEmpleado.ObtenerSede();
            return sede;
        }

        private List<Tarifa> buscarTarifasDeSede(Sede sede)
        {
            List<Tarifa> tarifasVigentes = sede.ObtenerTarifasVigentes();
            return tarifasVigentes;
        }

        public void TomarTarifasSeleccionadas(Tarifa tarifaSeleccionada)
        {
            Tarifa tarifa = tarifaSeleccionada;
            int duracionExposicionesVigentes = BuscarExposicionesVigentes();
            
        }

        public int BuscarExposicionesVigentes()
        {
            Sede sede = BuscarSede();
            int duracionExposicionesVigentes = sede.CalcularDuracionExposicionesVigentes();
            return duracionExposicionesVigentes;
        }

        public void CantidadEntradasAEmitir(int cantidadEntradas)
        {
            
            int capacidadMaxima = BuscarCapacidadSede();
            DateTime fechaHoraActual = ObtenerFechaHoraActual();
            int cantidadVisitantesEnSede = BuscarVisitantesEnSede(fechaHoraActual);
            int cantidadVisitantesPorAsistir = BuscarReservasParaAsistir(fechaHoraActual);
            bool validacion = ValidarLimiteVisitantes(capacidadMaxima, cantidadVisitantesEnSede, cantidadVisitantesPorAsistir, cantidadEntradas);

        }
        public int BuscarCapacidadSede()
        {
            Sede sede = BuscarSede();
            int capacidadSede = sede.MostrarCantidadMaximaVisitantes();
            return capacidadSede;
        }
        public DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        public int BuscarVisitantesEnSede(DateTime fechaHoraActual)
        {
            Sede sede = BuscarSede();
            int cantidadVisitantesEnSede = 0;
            DataTable tablaEntradas = new DataTable();
            tablaEntradas = ADEntradas.ObtenerListadoEntradas();
            for (int i = 0; i < tablaEntradas.Rows.Count; i++)
            {
                DateTime fechaVenta = DateTime.Parse(tablaEntradas.Rows[i][0].ToString());
                TimeSpan horaVenta = TimeSpan.Parse(tablaEntradas.Rows[i][1].ToString());
                int numero = int.Parse(tablaEntradas.Rows[i][2].ToString());
                float monto = float.Parse(tablaEntradas.Rows[i][3].ToString());
                int sedeEntrada = int.Parse(tablaEntradas.Rows[i][4].ToString());
                int tarifa = int.Parse(tablaEntradas.Rows[i][5].ToString());
                Entrada entrada = new Entrada(fechaVenta,horaVenta,numero,monto,sedeEntrada,tarifa);
                if (entrada.SonDeFechaYHoraSede(fechaHoraActual, sede))
                {
                    cantidadVisitantesEnSede += 1;
                }

            }
            return cantidadVisitantesEnSede;
        }
        public int BuscarReservasParaAsistir(DateTime fechaHoraActual)
        {
            Sede sede = BuscarSede();
            int cantidadVisitantesPorAsistir = 0;
            DataTable tablaReservas = new DataTable();
            tablaReservas = ADReservaVisita.ObtenerListadoReservaVisita();
            for (int i = 0; i < tablaReservas.Rows.Count; i++)
            {
                int cantidadAlumnos = int.Parse(tablaReservas.Rows[i][0].ToString());
                int cantidadAlumnosConfirmada = int.Parse(tablaReservas.Rows[i][1].ToString());
                int duracionEstimada = int.Parse(tablaReservas.Rows[i][2].ToString());
                DateTime fechaHoraCreacion = DateTime.Parse(tablaReservas.Rows[i][3].ToString());
                DateTime fechaHoraReserva = DateTime.Parse(tablaReservas.Rows[i][4].ToString());
                DateTime fechaHoraInicioReal = DateTime.Parse(tablaReservas.Rows[i][5].ToString());
                int numeroReserva = int.Parse(tablaReservas.Rows[i][6].ToString());
                string sedeReserva = tablaReservas.Rows[i][0].ToString(); //Este creo que es int pero asi estaba definido en la clase ReservaVisita
                

                ReservaVisita reserva = new ReservaVisita(cantidadAlumnos, cantidadAlumnosConfirmada, duracionEstimada, fechaHoraCreacion, fechaHoraReserva, fechaHoraInicioReal, fechaHoraActual, numeroReserva, sedeReserva);
                if (reserva.SonParaFechaYHoraSede(fechaHoraActual, sede))
                {
                    cantidadVisitantesPorAsistir += 1;
                }

            }
            return cantidadVisitantesPorAsistir;
        }
        public bool ValidarLimiteVisitantes(int capacidadMaxima, int cantidadEnSede, int cantidadPorVenir, int cantidadEntradasAEmitir)
        {
            int cantidadTotal = cantidadEnSede + cantidadPorVenir + cantidadEntradasAEmitir;
            if (capacidadMaxima >= cantidadTotal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }






    }
}
