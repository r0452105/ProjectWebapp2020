﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing0._1.Models
{
    public class Gebruiker
    {
        public int GebruikerID { get; set; }
        public string Naam { get; set; }

        public string Voornaam { get; set; }

        public string VolledigeNaam => $"{Voornaam} {Naam}";

        public string Nationaliteit { get; set; }

        public string Profielfoto { get; set; }

        public int Score { get; set; }
        public virtual ICollection<GebruikerTeam> GebruikerTeams { get; set; }

    }
}
