using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoznik.DomainModel
{
    public class Aerodrom
    {
        public String id { get; set; }
        public String mesto { get; set; }
        public String kapacitet { get; set; }
        public List<Let> letovi { get; set; }
        public List<Avion> avioni { get; set; }
    }
}
