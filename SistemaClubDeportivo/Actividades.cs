using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class Actividades
    {
        List<string> ListaDeActividades = new List<string>();
        private string? PreciosDeActividades;

        public Actividades(List<string> listaDeActividades, string? preciosDeActividades)
        {
            ListaDeActividades1 = listaDeActividades;
            PreciosDeActividades1 = preciosDeActividades;
        }

        public List<string> ListaDeActividades1 { get => ListaDeActividades; set => ListaDeActividades = value; }
        public string? PreciosDeActividades1 { get => PreciosDeActividades; set => PreciosDeActividades = value; }
    }
}
