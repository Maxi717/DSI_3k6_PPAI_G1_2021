using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public interface ISujetoVisitante
    {
        
        void Notificar(int cantidad);

        void Quitar(IObservadorVisitante observadorVisitante);

        void Suscribir(List<IObservadorVisitante> observadorVisitante);

    }
}
