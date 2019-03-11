using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AvioPrevoznik.DomainModel
{
   public class Putnik
    {
        public String id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String pasos { get; set; }
        public List<Karta> ListaKarata { get; set; }

    }
}
