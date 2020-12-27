using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing0._1.Models;

namespace Testing0._1.ViewModels
{
    public class ListTeamsViewModel
    {
      public List<Team> Teams { get; set; }
      public List<Gebruiker> Gebruikers { get; set; }
      public List<Race> Races { get; set; }
    }
}
