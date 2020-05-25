using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    //obrambnega igralca, ki mu v nogometne podatke dodate stran položaja (centralni, levi, desni) 
    class ObrambniIgralec : Igralec
    {
        public enum Polozaj
        {
            centralni, levi, desni
        }
        public Polozaj polozaj { get; set; }
        public ObrambniIgralec() : base()
        {

        }
        public ObrambniIgralec(string ime, string priimek, Polozaj pozicija) : base(ime, priimek)
        {
            polozaj = pozicija;
        }
        //Učinkovitost obrambnega igralca vrača, fiksno vrednost, ki jo določite sami
        public override double izracunajUcinkovitostIgralca()
        {
            return 0.55;
        }
        public override void Izpis()
        {
            Console.WriteLine("Igralec: " + base.Ime + " " + base.Priimek + "\r\n" + "Ucinkovitost obrambnega igralca: " + izracunajUcinkovitostIgralca());
        }
    }
    //vezista, ki mu med nogometne podatke dodate število podaj naprej in število podaj nazaj
}
