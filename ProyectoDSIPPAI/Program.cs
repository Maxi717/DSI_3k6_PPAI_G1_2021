using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDSIPPAI.Clases.Fronteras;
using ProyectoDSIPPAI.Clases.Entidades;
using System.Data.SqlClient;
using System.Data;
using ProyectoDSIPPAI.Clases.Gestores;

namespace ProyectoDSIPPAI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TipoEntrada tipoEnt = new TipoEntrada();
            tipoEnt.SetNombre("PUBLICO EN GENERAL");
            TipoVisita tipoVis = new TipoVisita();
            tipoVis.SetNombre("VISITA COMPLETA SIN GUIA");
            Tarifa unaTarifa = new Tarifa();
            unaTarifa.SetFechaFinVigencia(DateTime.Parse("2022-05-09"));
            unaTarifa.SetFechaInicioVigencia(DateTime.Parse("2009-12-19"));
            unaTarifa.SetTipoEntrada(tipoEnt);
            unaTarifa.SetTipoVisita(tipoVis);
            unaTarifa.SetMonto(500);
            unaTarifa.SetMontoAdicionalGuia(0);
            Sede unaSede = new Sede();
            unaSede.SetCantidadMaximaVisitantes(400);
            unaSede.SetCantMaxPorGuia(60);
            unaSede.SetNombre("SEDE ABSTRACTA");
            List<Tarifa> tarifas = new List<Tarifa>() { unaTarifa };
            unaSede.SetTarifas(tarifas);
            Empleado unEmpleado = new Empleado();
            unEmpleado.SetApellido("Gonzalez");
            unEmpleado.SetNombre("Martin");
            unEmpleado.SetCodigoValidacion(15);
            unEmpleado.SetSede(unaSede);
            unEmpleado.SetDni(32654321);
            Exposicion unaExpo = new Exposicion();
            unaExpo.SetNombre("EXPO SURREAL");
            unaExpo.SetHoraApertura(TimeSpan.Parse("09:00:00"));
            unaExpo.SetHoraCierre(TimeSpan.Parse("20:00:00"));
            unaExpo.SetFechaInicio(DateTime.Parse("2020-05-05"));
            unaExpo.SetFechaFin(DateTime.Parse("2023-08-13"));
            unaExpo.SetEmpleado(unEmpleado);
            Obra unaObra = new Obra();
            unaObra.SetDuracionResumida(30);
            unaObra.SetEmpleado(unEmpleado);
            DetalleExposicion unDetalle = new DetalleExposicion();
            unDetalle.SetLugarAsignado("PASILLO UNO");
            unDetalle.SetObra(unaObra);
            List<DetalleExposicion> listaDetalles = new List<DetalleExposicion> { unDetalle };
            unaExpo.SetDetallesExposicion(listaDetalles);
            List<Exposicion> listaExpo = new List<Exposicion> { unaExpo };
            unaSede.SetExposiciones(listaExpo);
            Usuario unUsuario = new Usuario(DateTime.Parse("2040-06-08"),"MartiGonza01" , "admin1234", unEmpleado);
            Sesion sesion = new Sesion();
            sesion.SetFechaInicio(DateTime.Parse("2009-05-05"));
            sesion.SetHoraInicio(TimeSpan.Parse("09:00:00"));
            sesion.SetUsuario(unUsuario);

            PantallaSala pantallaSala = new PantallaSala(unaSede.GetCantidadMaximaVisitantes());
            PantallaEntrada pantallaEntrada = new PantallaEntrada(unaSede.GetCantidadMaximaVisitantes());
            GestorVentaEntrada gestor = new GestorVentaEntrada(pantallaEntrada, pantallaSala);
            pantallaSala.Show();
            pantallaEntrada.Show();
            Application.Run(new PantallaVentaEntrada(sesion, gestor));
        }
    }
}
