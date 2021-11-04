using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    interface IPersistencia
    {

        Object Materializar(int id);
        // Se trae el objeto a memoria


        bool Desmaterializar(Object objeto);
        // Se envía el objeto a la base de datos


    }
}
