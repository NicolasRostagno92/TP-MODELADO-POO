﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class Socio : Persona
    {
        private int? NumCarnetSocio;


        public Socio(string nombre, string apellido, string direccion, string dni, int NumCarnetSocio) : base(nombre, apellido, direccion, dni)
        {
        }


    }
}
