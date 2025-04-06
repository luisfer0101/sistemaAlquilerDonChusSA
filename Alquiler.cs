using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaAlquilerDonChusSA
{
    internal class Alquiler
    {

        public string NitCliente { get; set; }
        public string PlacaAuto { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int KilometrosRecorridos { get; set; }



    }
}
