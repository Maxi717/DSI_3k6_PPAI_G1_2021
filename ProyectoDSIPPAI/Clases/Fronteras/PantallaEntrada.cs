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
    public partial class PantallaEntrada : Form
    {
        public PantallaEntrada(int capacidad)
        {
            InitializeComponent();
            lblCapacidad.Text = capacidad.ToString();
        }

        internal void ActualizarCantidadVisitantes(int cantidadASumar)
        {
            int cantidadActual = int.Parse(lblCantVisitantes.Text);
            lblCantVisitantes.Text = (cantidadActual + cantidadASumar).ToString(); 
        }

        private void lblCantVisitantes_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
