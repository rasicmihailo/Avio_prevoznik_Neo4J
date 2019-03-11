using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoznik.DomainModel
{
    public class Avion
    {
        public String id { get; set; }
        public String marka { get; set; }
        public int brojsedista { get; set; }
        public String godinaproizvodnje { get; set; }
        public List<Let> letovi { get; set; }
        public Aerodrom aerodrom { get; set; }
    }
}
