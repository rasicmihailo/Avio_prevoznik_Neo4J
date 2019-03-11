using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoznik
{
    public class User
    {
        public String korisnicko { get; set; }
        public String sifra { get; set; }
        public String id { get; set; }
        public int a { get; set; } //a == 1 - admin, a == 0 - radnik
        public String ime { get; set; }
        public String prezime { get; set; }


        public User() { }
    }
}
