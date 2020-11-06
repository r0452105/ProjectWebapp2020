using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAquadraat.Models
{
    public class Gebruiker
    {
        public int GebruikerID { get; set; }
        public string Naam { get; set; }

        public string Voornaam { get; set; }

        public string VolledigeNaam => $"{Voornaam} {Naam}";

        public string Nationaliteit { get; set; }

        public string Profielfoto { get; set; }

    }
}
