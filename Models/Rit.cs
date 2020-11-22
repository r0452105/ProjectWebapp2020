using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing0._1.Models
{
    public class Rit
    {
        public int RitID { get; set; }
        public int Afstand { get; set; }
        public DateTime Datum { get; set; }
        public string Profielfoto { get; set; }
        public int RitsoortID { get; set; }
        public Ritsoort Ritsoort { get; set; }
        public int RaceID { get; set; }
        public Race Race { get; set; }
    }
}



