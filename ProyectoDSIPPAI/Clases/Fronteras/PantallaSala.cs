using ProyectoDSIPPAI.Clases.Entidades;
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
    public partial class PantallaSala : Form , IObservadorVisitante
    {
        public PantallaSala(int capacidad)
        {
            InitializeComponent();
            lblCapacidad.Text = capacidad.ToString();
        }

        public void Actualizar(int cantidad)
        {
            SetCantidadVisitantes(cantidad);
        }

        public void SetCantidadVisitantes(int cantidad)
        {
            lblCantVisitantes.Text = (int.Parse(lblCantVisitantes.Text) + cantidad).ToString();
        }
    }
}
