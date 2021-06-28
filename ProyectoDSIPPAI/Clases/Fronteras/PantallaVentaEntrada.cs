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
using ProyectoDSIPPAI.Clases.Entidades;

namespace ProyectoDSIPPAI.Clases.Fronteras
{
    public partial class PantallaVentaEntrada : Form
    {
        private GestorVentaEntrada gestor;

        public PantallaVentaEntrada(Sesion sesion)
        {
            InitializeComponent();
            gestor = new GestorVentaEntrada();
            gestor.OpcionVentaEntradas(this, sesion);
        }

        private void TomarSeleccionTarifas(object sender, EventArgs e)
        {
            int indiceTarifa = (int)grdTarifas.CurrentRow.Cells[3].Value;
            Tarifa tarifaElegida = gestor.Tarifas[indiceTarifa];
            gestor.TomarTarifasSeleccionadas(tarifaElegida);


        }


        public void MostrarTarifasVigentes(List<Tarifa> tarifas)
        {
            lblTarifas.Visible = true;
            grdTarifas.Visible = true;
            btnTomarTarifa.Visible = true;
            btnTomarTarifa.Enabled = false;
            int rowNumber = 0;
            foreach (var tarifa in tarifas)
            {
                List<string> tarifasVector = tarifa.MostrarMontosVigentes();
                grdTarifas.Rows.Add();
                grdTarifas.Rows[rowNumber].Cells[0].Value = tarifasVector[0];
                grdTarifas.Rows[rowNumber].Cells[1].Value = tarifasVector[1];
                grdTarifas.Rows[rowNumber].Cells[2].Value = tarifasVector[2];
                grdTarifas.Rows[rowNumber].Cells[3].Value = rowNumber;
                rowNumber += 1;
            }


        }

        private void PantallaVentaEntrada_Load(object sender, EventArgs e)
        {
            ;
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

        private void grdTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTomarTarifa.Enabled = true;
            
        }

    }
}
