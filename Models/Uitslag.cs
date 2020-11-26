using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing0._1.Models
{
    public class Uitslag
    {
        public int UitslagID { get; set; }

        public int? Puntenklassement { get; set; }
        public int? Bergklassement { get; set; }
        public int? Strijdlustklassement { get; set; }
        public int? Resultaat { get; set; }
        public  TimeSpan Algemeenklassement { get; set; }
        public int RitID { get; set; }
        public Rit Rit{ get; set; }
        public int GebruikerID { get; set; }
        public Gebruiker Gebruiker { get; set; }
    }
}
