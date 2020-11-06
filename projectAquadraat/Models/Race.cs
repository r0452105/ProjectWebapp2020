using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAquadraat.Models
{
    public class Race
    {
        public int RaceID { get; set; }
        public string Naam { get; set; }
        public bool Finished { get; set; }
        public DateTime Startdatum { get; set; }
        public int Aantalritten { get; set; }

    }
}
