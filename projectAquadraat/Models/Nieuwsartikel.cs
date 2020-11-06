using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAquadraat.Models
{
    public class Nieuwsartikel
    {
        public int NieuwsartikelID { get; set; }
        public string Titel { get; set; }
        public string  KorteOmschrijving { get; set; }
        public string ArtikelTekst { get; set; }
        public string Artikelfoto { get; set; }
    }
}
