using ProyectoDSIPPAI.Clases.Entidades;
using ProyectoDSIPPAI.Clases.Fronteras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoDSIPPAI.Clases.Gestores
{
    public class GestorVentaEntrada
    {
        private Empleado logueadoEmpleado;
        private List<Tarifa> tarifas;
        private Usuario usuario;
        private Sede sedeActual;
        private int duracionExpo;
        private PantallaEntrada pantallaEntrada;
        private PantallaSala pantallaSala;

        public GestorVentaEntrada(PantallaEntrada pantallaEnt, PantallaSala pantallaSal)
        {
            this.pantallaEntrada = pantallaEnt;
            this.pantallaSala = pantallaSal;
        }

        public List<Tarifa> GetTarifas()
        {
            return this.tarifas;
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
            BuscarSede();
            List<List<string>> tarifas = BuscarTarifasDeSede();
            pantalla.MostrarTarifasVigentes(tarifas);
        }


        private Empleado BuscarEmpleadoLogeado(Sesion sesion)
        {
            Empleado empleado = sesion.GetEmpleadoEnSesion();
            return empleado;
        }

        private void BuscarSede()
        {
            sedeActual = this.logueadoEmpleado.ObtenerSede();
            
        }

        private List<List<string>> BuscarTarifasDeSede()
        {   

            List<List<string>> tarifasVigentes = sedeActual.ObtenerTarifasVigentes(this);
            return tarifasVigentes;
        }

        public void TomarTarifasSeleccionadas(PantallaVentaEntrada pantalla, int tarifaSelecc)
        {                 
            
            this.duracionExpo = BuscarExposicionesVigentes();

            pantalla.SeleccionarCantidadEntradas();

        }

        public int BuscarExposicionesVigentes()
        {
            int duracionExposicionesVigentes = sedeActual.CalcularDuracionExposicionesVigentes();
            return duracionExposicionesVigentes;
        }

        public void CantidadEntradasAEmitir(PantallaVentaEntrada pantalla , int cantidadEntradas, float precioUnitario)
        {

            int capacidadMaxima = BuscarCapacidadSede();
            DateTime fechaHoraActual = ObtenerFechaHoraActual();
            int cantidadVisitantesEnSede = BuscarVisitantesEnSede(fechaHoraActual);
            int cantidadVisitantesPorAsistir = BuscarReservasParaAsistir(fechaHoraActual);
            bool validacion = ValidarLimiteVisitantes(capacidadMaxima, cantidadVisitantesEnSede, cantidadVisitantesPorAsistir, cantidadEntradas);
            if (validacion)
            {
                float precioTotal = CalcularTotalVenta(cantidadEntradas, precioUnitario);
                pantalla.MostrarDetalleEntradas(precioTotal);
            }
        }

        public void TomarConfirmacionVenta(int cantidadEntradas, Tarifa tarifa)
        {
            int ultimoNro = BuscarUltimoNroEntrada();
            List<Entrada> entradasAImprimir = GenerarEntradas(ultimoNro, cantidadEntradas, tarifa);
            ImprimirEntradas(entradasAImprimir);
            ActualizarVisitantesEnPantallas(cantidadEntradas);


        }

        public void ActualizarVisitantesEnPantallas(int cantidadASumar)
        {
            pantallaSala.ActualizarCantidadVisitantes(cantidadASumar);
            pantallaEntrada.ActualizarCantidadVisitantes(cantidadASumar);
        }

        public void ImprimirEntradas(List<Entrada> entradas)
        {
            foreach (Entrada entrada in entradas)
            {
                ImpresorEntradas.imprimir(entrada);
            }
        }

        public List<Entrada> GenerarEntradas(int ultimoNro, int cantidad, Tarifa tarifa)
        {
            List<Entrada> entradasGeneradas = new List<Entrada>();
            for (int i = 0; i < cantidad; i++)
            {
                Entrada entradaGenerada = new Entrada();
                entradaGenerada.SetFechaVenta(DateTime.Now.Date);
                entradaGenerada.SetHoraVenta(DateTime.Now.TimeOfDay);
                entradaGenerada.SetNumero(ultimoNro + i);
                entradaGenerada.SetMonto(tarifa.GetMonto());
                entradaGenerada.SetTarifa(tarifa);
                entradaGenerada.SetSede(this.sedeActual);
                entradasGeneradas.Add(entradaGenerada);
            }
            return entradasGeneradas;
        }

        public int BuscarUltimoNroEntrada()
        {
            List<Entrada> entradas = new List<Entrada>();
            int numeroMayor = 0;
            // ACÁ IRÍA CODIGO QUE LLENA LA LIST CON OBJETOS ENTRADA
            foreach (Entrada entrada in entradas)
            {
                int numeroEntrada = entrada.GetNumero();
                if (numeroEntrada > numeroMayor)
                {
                    numeroMayor = numeroEntrada;
                }
            }

            return numeroMayor + 1;
        }

        public int BuscarCapacidadSede()
        {
            
            int capacidadSede = this.sedeActual.MostrarCantidadMaximaVisitantes();
            return capacidadSede;
        }


        public DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        public int BuscarVisitantesEnSede(DateTime fechaHoraActual)
        {
            
            int cantidadVisitantesEnSede = 0;
            DataTable tablaEntradas = new DataTable();

            List<Entrada> listaEntrada = new List<Entrada>();

            //Acceso a base


            foreach (Entrada unaEntrada in listaEntrada)
            {
              
                if (unaEntrada.SonDeFechaYHoraSede(fechaHoraActual, this.sedeActual))
                {
                    cantidadVisitantesEnSede += 1;
                }

            }

            return cantidadVisitantesEnSede;

            //tablaEntradas = ADEntradas.ObtenerListadoEntradas();

            // 
            //for (int i = 0; i < tablaEntradas.Rows.Count; i++)
            //{
            //    DateTime fechaVenta = DateTime.Parse(tablaEntradas.Rows[i][0].ToString());
            //    TimeSpan horaVenta = TimeSpan.Parse(tablaEntradas.Rows[i][1].ToString());
            //    int numero = int.Parse(tablaEntradas.Rows[i][2].ToString());
            //    float monto = float.Parse(tablaEntradas.Rows[i][3].ToString());
            //    int sedeEntrada = int.Parse(tablaEntradas.Rows[i][4].ToString());
            //    int tarifa = int.Parse(tablaEntradas.Rows[i][5].ToString());
            //    Entrada entrada = new Entrada(fechaVenta, horaVenta, numero, monto, sedeEntrada, tarifa);
            //    if (entrada.SonDeFechaYHoraSede(fechaHoraActual, this.sedeActual))
            //    {
            //        cantidadVisitantesEnSede += 1;
            //    }

            //}
        }
        public int BuscarReservasParaAsistir(DateTime fechaHoraActual)
        {

            
            int cantidadVisitantesEnSede = 0;
            //DataTable tablaEntradas = new DataTable();

            List<ReservaVisita> listaReserva = new List<ReservaVisita>();

            //Acceso a base
            //            
            DateTime finVisita = DateTime.Now.AddMinutes(duracionExpo);

            foreach (ReservaVisita reserva in listaReserva)
            {

                if (reserva.SonParaFechaHoraYSede(finVisita, this.sedeActual ))
                {
                    cantidadVisitantesEnSede += 1;
                }

            }

            return cantidadVisitantesEnSede;


            //int cantidadVisitantesPorAsistir = 0;
            //DataTable tablaReservas = new DataTable();
            //tablaReservas = ADReservaVisita.ObtenerListadoReservaVisita();
            //for (int i = 0; i < tablaReservas.Rows.Count; i++)
            //{
            //    int cantidadAlumnos = int.Parse(tablaReservas.Rows[i][0].ToString());
            //    int cantidadAlumnosConfirmada = int.Parse(tablaReservas.Rows[i][1].ToString());
            //    int duracionEstimada = int.Parse(tablaReservas.Rows[i][2].ToString());
            //    DateTime fechaHoraCreacion = DateTime.Parse(tablaReservas.Rows[i][3].ToString());
            //    DateTime fechaHoraReserva = DateTime.Parse(tablaReservas.Rows[i][4].ToString());
            //    DateTime fechaHoraInicioReal = DateTime.Parse(tablaReservas.Rows[i][5].ToString());
            //    int numeroReserva = int.Parse(tablaReservas.Rows[i][6].ToString());
            //    string sedeReserva = tablaReservas.Rows[i][0].ToString(); //Este creo que es int pero asi estaba definido en la clase ReservaVisita


            //    ReservaVisita reserva = new ReservaVisita(cantidadAlumnos, cantidadAlumnosConfirmada, duracionEstimada, fechaHoraCreacion, fechaHoraReserva, fechaHoraInicioReal, fechaHoraActual, numeroReserva, sedeReserva);
            //    if (reserva.SonParaFechaYHoraSede(fechaHoraActual, this.sedeActual))
            //    {
            //        cantidadVisitantesPorAsistir += 1;
            //    }


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
        
        public float CalcularTotalVenta(int cantidadEntradas, float precioEntrada)
        {
            float total = cantidadEntradas * precioEntrada;
            return total;
        }

        public void SetTarifas(List<Tarifa> tarifas)
        {
            this.tarifas = tarifas;
        }
    }
}
