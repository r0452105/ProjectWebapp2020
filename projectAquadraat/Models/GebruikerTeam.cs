using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAquadraat.Models
{
    public class GebruikerTeam
    {
        public int GebruikerTeamID { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public int GebruikerID { get; set; }
        public Gebruiker Gebruiker { get; set; }
    }
}
