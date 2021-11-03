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
        private Tarifa tarifaSeleccionada;
        private GestorVentaEntrada gestor;

        public PantallaVentaEntrada(Sesion sesion, GestorVentaEntrada gestor)
        {
            InitializeComponent();

            this.gestor = gestor;
            gestor.OpcionVentaEntradas(this, sesion);
        }

        private void TomarSeleccionTarifas(object sender, EventArgs e )
        {
            int indiceTarifa = (int)grdTarifas.CurrentRow.Cells[3].Value;
            this.tarifaSeleccionada = gestor.GetTarifas()[indiceTarifa];
            gestor.TomarTarifasSeleccionadas(this, indiceTarifa);

        }


        public void MostrarTarifasVigentes(List<List<string>> tarifas)
        {
            lblTarifas.Visible = true;
            grdTarifas.Visible = true;
            btnTomarTarifa.Visible = true;
            btnTomarTarifa.Enabled = false;
            int rowNumber = 0;
            foreach (var tarifa in tarifas)
            {               
                grdTarifas.Rows.Add();
                grdTarifas.Rows[rowNumber].Cells[0].Value = tarifa[0];
                grdTarifas.Rows[rowNumber].Cells[2].Value = tarifa[1];
                grdTarifas.Rows[rowNumber].Cells[1].Value = tarifa[2];                
                grdTarifas.Rows[rowNumber].Cells[3].Value = rowNumber;
                rowNumber += 1;
            }


        }

        private void PantallaVentaEntrada_Load(object sender, EventArgs e)
        {
            
        }

        public void SeleccionarCantidadEntradas()
        {
          
            txtCantidad.Enabled = true;
            btnCantidadEntradas.Enabled = true;

        }
       

        private void TomarCantidadEntradas(object sender, EventArgs e)
        {
            if(txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese alguna cantidad de entradas");
            }
            else
            {
                int cantidad = int.Parse(txtCantidad.Text);
                
                bool resultado = gestor.CantidadEntradasAEmitir(this, cantidad, tarifaSeleccionada.GetMonto());

                if ( ! resultado)
                {
                    MessageBox.Show("La cantidad de entradas excede a la capacidad actual de la sede.");
                    btnConfirmar.Enabled = false;
                }
            }   
            
        }

        public void MostrarDetalleEntradas(float precioTotal)
        {
            txtCantidadAMostrar.Text = txtCantidad.Text;
            txtPrecioUnitario.Text = tarifaSeleccionada.GetMonto().ToString();
            txtPrecioTotal.Text = precioTotal.ToString();
            btnConfirmar.Enabled = true;
        }

        private void TomarConfirmacionVenta(object sender, EventArgs e)
        {
            gestor.TomarConfirmacionVenta(int.Parse(txtCantidad.Text), this.tarifaSeleccionada);
        }

        private void grdTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTomarTarifa.Enabled = true;
            
        }

    }
}
