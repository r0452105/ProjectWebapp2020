﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAquadraat.Models
{
    public class RaceTeam
    {
        public int RaceTeamID { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public int RaceID { get; set; }
        public Race Race { get; set; }

    }
}
