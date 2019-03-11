using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoznik.DomainModel
{
    public class Let
    {
        public String id { get; set; }
        public List<Karta> listakarata { get; set; }
        public Aerodrom polazniaerodrom { get; set; }
        public Aerodrom odredisniaerodrom { get; set; }
        public Avion avion { get; set; }
        public int osnovnacena { get; set; }
        public String datumpolaska { get; set; }
        public String vremepolaska { get; set; }
        public String vremeletenja { get; set; }
        public int brojsedista { get; set; }
        public Let() { }
    }
}
