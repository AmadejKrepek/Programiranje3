using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Karta
    {
        public int id_sedez { get; set; }
        //Obiskovalec
        public double cenaVstopnice { get; set; }
        public Obiskovalec obiskovalec { get; set; }
        public Karta() { }
        public Karta(int id_sedez, double cenaVstopnice, Obiskovalec obiskovalec)
        {
            this.id_sedez = id_sedez;
            this.cenaVstopnice = cenaVstopnice;
            this.obiskovalec = obiskovalec;
        }
    }
}
