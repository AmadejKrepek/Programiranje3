using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Zaposleni
    {
        public string ime { get; set; }
        public string priimek { get; set; }
        public string delovnoMesto { get; set; }
        public Zaposleni(string ime, string priimek, string delovnoMesto)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.delovnoMesto = delovnoMesto;
        }
        public void PrijaviSeNaObvestilo(Referat sporoci)
        {
            sporoci.obvestiloDelegat += (IzpisiObvestilo);
        }
        public void IzpisiObvestilo(string a, string b)
        {
            Console.WriteLine(a + " " + b + " Prejemnik: {0} {1}", ime, priimek);
            Console.WriteLine("====================================================================================================");
        }
    }
}
