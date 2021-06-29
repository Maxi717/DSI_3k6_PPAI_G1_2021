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
    public partial class PantallaSala : Form
    {
        public PantallaSala(int capacidad)
        {
            InitializeComponent();
            lblCapacidad.Text = capacidad.ToString();
        }

        public void ActualizarCantidadVisitantes(int cantidadASumar)
        {
            int cantidadActual = int.Parse(lblCantVisitantes.Text);
            lblCantVisitantes.Text = (cantidadActual + cantidadASumar).ToString();
        }
    }
}
