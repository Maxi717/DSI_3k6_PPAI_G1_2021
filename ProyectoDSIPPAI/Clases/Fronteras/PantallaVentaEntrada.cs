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
        private int tarifaSeleccionada;
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

        // aa:bb minutos / 60 = aa --> minutos % 60 = b

        private void TomarCantidadEntradas(object sender, EventArgs e)
        {
            if(txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese alguna cantidad de entradas");
            }
            else
            {
                int cantidad = int.Parse(txtCantidad.Text);
                gestor.CantidadEntradasAEmitir(this, cantidad);
            }
            
        }

        public void MostrarDetalleEntradas(DataTable detalle_entradas, int numero_entrada)
        {


            // jkjjjjjjjjjjjj grdDetalle.Rows.Add(numero_entrada, detalle_entradas.Rows[0][1].ToString(), detalle_entradas.Rows[0][2].ToString(), detalle_entradas.Rows[0][3].ToString(), detalle_entradas.Rows[0][4].ToString());
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // jjjjjjjjjjjjjjjjjjjjgestor.TomarConfirmacionVenta();
        }

        private void grdTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTomarTarifa.Enabled = true;
            
        }

    }
}
