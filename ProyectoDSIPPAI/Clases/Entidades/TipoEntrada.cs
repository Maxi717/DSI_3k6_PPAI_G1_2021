﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDSIPPAI.Clases.Entidades
{
    public class TipoEntrada
    {
        private string nombre { get; set; }

        public string GetNombre()
        {
            return nombre;
        }

        public string MostrarNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombreNuevo)
        {
            this.nombre = nombreNuevo;
        }

    }
}
