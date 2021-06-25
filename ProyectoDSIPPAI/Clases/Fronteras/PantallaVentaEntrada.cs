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
                DataGridViewSelectedRowCollection tarifas = grdTarifas.SelectedRows;
                gestor.TomarTarifasSeleccionadas(this, tarifas);
                
            }

        }


        public void MostrarTarifasVigentes()
        {
            lblTarifas.Visible = true;
            grdTarifas.Visible = true;
            btnTomarTarifa.Visible = true;

        }

        private void PantallaVentaEntrada_Load(object sender, EventArgs e)
        {
            gestor.OpcionVentaEntradas(this, null);
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

        public void MostrarDetalleEntradas()
        {
            
            grdDetalle.Visible = true;

            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            gestor.TomarConfirmacionVenta();
        }
    }
}
