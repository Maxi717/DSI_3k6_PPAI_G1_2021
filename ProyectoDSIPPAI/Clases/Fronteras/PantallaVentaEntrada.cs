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


        public void MostrarTarifasVigentes()
        {
            lblTarifas.Visible = true;
            grdTarifas.Visible = true;
            btnTomarTarifa.Visible = true;

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
            gestor.CantidadEntradasAEmitir();
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
