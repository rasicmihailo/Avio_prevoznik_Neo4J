using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoznik.DomainModel
{
    public class Karta
    {
        public String id { get; set; }
        public int cena { get; set; }
        public Let let { get; set; }
        public Putnik putnik { get; set; }
        public String klasa { get; set; }
        public int brojsedista { get; set; }
        public String velicinaprtljaga { get; set; }

        public Karta() { }

    }
}
