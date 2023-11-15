using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class NoSocio : Persona
    {

        private int? NumNoSocio;

        public NoSocio(string nombre, string apellido,string direccion, string dni, int NumNoSocio) : base (nombre, apellido,direccion, dni) 
        {
        }
    }
}
