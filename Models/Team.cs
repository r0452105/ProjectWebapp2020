using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing0._1.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Naam { get; set; }
        public int RaceID { get; set; }
        public Race Race { get; set; }
        public virtual ICollection<GebruikerTeam> GebruikerTeams { get; set; }
    }
}
