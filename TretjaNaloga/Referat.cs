using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Referat
    {
        public string naziv { get; set; }

        public delegate void Obvestilo(string x, string y);

        public event Obvestilo obvestiloDelegat;
        public Referat(string naziv)
        {
            this.naziv = naziv;
        }

        public void Izpis(string naziv, string b)
        {
            obvestiloDelegat(naziv, b);
        }
    }
}
