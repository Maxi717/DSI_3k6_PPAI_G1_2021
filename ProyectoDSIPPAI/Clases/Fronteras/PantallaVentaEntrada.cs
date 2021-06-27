using ProyectoDSIPPAI.Clases.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDSIPPAI.Clases.Fronteras
{
    public partial class PantallaVentaEntrada : Form
    {
        GestorVentaEntrada gestor = new GestorVentaEntrada();
        public PantallaVentaEntrada()
        {
            InitializeComponent();
        }

        private void btnTomarTarifa_Click(object sender, EventArgs e)
        {

            if (grdTarifas.SelectedRows.Count < 1)
            {
                MessageBox.Show("Por favor seleccione una tarifa");

            }
            else
            {
                gestor.TomarTarifasSeleccionadas(this);
                
            }

        }


        public void MostrarTarifasVigentes(List<Tarifa> tarifas)
        {
            lblTarifas.Visible = true;
            grdTarifas.Visible = true;
            //btnTomarTarifa.Visible = true;

            foreach (var tarifa in tarifas)
            {

            }

        }

        private void PantallaVentaEntrada_Load(object sender, EventArgs e)
        {
            gestor.OpcionVentaEntradas();
        }

        public void SeleccionarCantidadEntradas()
        {
            lblCantidad.Visible = true;
            txtCantidad.Visible = true;
            btnCantidadEntradas.Visible = true;

        }

        private void btnCantidadEntradas_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese alguna cantidad de entradas");
            }
            else
            {
                int cantidad = int.Parse(txtCantidad.Text);
                gestor.CantidadEntradasAEmitir(cantidad);
            }
            
        }

        public void MostrarDetalleEntradas(DataTable detalle_entradas, int numero_entrada)
        {
            grdDetalle.Visible = true;

            grdDetalle.Rows.Add(numero_entrada, detalle_entradas.Rows[0][1].ToString(), detalle_entradas.Rows[0][2].ToString(), detalle_entradas.Rows[0][3].ToString(), detalle_entradas.Rows[0][4].ToString());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            gestor.TomarConfirmacionVenta();
        }

        private DataTable grdTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTomarTarifa.Visible = true;
            int indice = e.RowIndex;
            DataGridViewRow tarifaSeleccionada = grdTarifas.Rows[indice];
            string nombre_tarifa = tarifaSeleccionada.Cells["Nombre"].Value.ToString();
            string tipo_visita = tarifaSeleccionada.Cells["TipoVisita"].Value.ToString();
            string tipo_entrada = tarifaSeleccionada.Cells["TipoEntrada"].Value.ToString();
            string guia = tarifaSeleccionada.Cells["Guia"].Value.ToString();

            DataTable detalle_entradas = new DataTable();
            detalle_entradas.Rows[0][1] = nombre_tarifa;
            detalle_entradas.Rows[0][2] = tipo_visita;
            detalle_entradas.Rows[0][3] = tipo_entrada;
            detalle_entradas.Rows[0][4] = guia;
            return detalle_entradas;
        }

    }
}
