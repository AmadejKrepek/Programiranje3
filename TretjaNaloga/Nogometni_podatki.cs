using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Nogometni_podatki
    {
        public enum Pozicija
        {
            NAPAD, SREDINA, OBRAMBA, GOLMAN
        }
        //Get and set metodi
        public Pozicija pozicija
        {
            get { return pozicija; }
            set { pozicija = value; }
        }
        public Nogometni_podatki() { } //Privzeti konstrukor, ki nima nobenih parametrov.
        public Nogometni_podatki(Pozicija mestoIgre)
        {
            pozicija = mestoIgre;
        }
        public Nogometni_podatki(Pozicija mestoIgre, Pozicija playGround) : this(mestoIgre)
        {
            pozicija = playGround;
        }
        public override string ToString()
        {
            return "Pozicija: " + pozicija;

        }
    }
}
