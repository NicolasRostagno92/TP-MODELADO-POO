using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo
{
    internal class Cuota
    {
        private string? ValorCuota;
        private int CantCuotas;
        private int FechaVenciento;
        private string? MetodoPago;

        public Cuota(string? valorCuota, int cantCuotas, int fechaVenciento, string? metodoPago)
        {
            ValorCuota1 = valorCuota;
            CantCuotas1 = cantCuotas;
            FechaVenciento1 = fechaVenciento;
            MetodoPago1 = metodoPago;
        }

        public string? ValorCuota1 { get => ValorCuota; set => ValorCuota = value; }
        public int CantCuotas1 { get => CantCuotas; set => CantCuotas = value; }
        public int FechaVenciento1 { get => FechaVenciento; set => FechaVenciento = value; }
        public string? MetodoPago1 { get => MetodoPago; set => MetodoPago = value; }
    }
}
