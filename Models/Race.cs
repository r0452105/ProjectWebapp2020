using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing0._1.Models
{
    public class Race
    {
        public int RaceID { get; set; }
        public string Naam { get; set; }
        public bool Finished { get; set; }
        public DateTime Startdatum { get; set; }
        public int Aantalritten { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Rit> Ritten { get; set; }

    }
}
