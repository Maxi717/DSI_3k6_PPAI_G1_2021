using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public interface IObservadorVisitante
    {

        void Actualizar(int cantidad);
        void SetCantidadVisitantes(int cantidad);


    }
}
