using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Student
    {
        public string ime { get; set; }
        public string priimek { get; set; }
        public int vpisna { get; set; }
        public Student(string ime, string priimek, int vpisna)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.vpisna = vpisna;
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
