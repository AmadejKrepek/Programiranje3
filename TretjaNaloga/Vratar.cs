using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{

    //vratarja, ki mu v  nogometne podatke dodate število prejetih golov in število obranjenih strelov
    class Vratar : Igralec
    {
        public int steviloPrejetihGolov { get; set; }
        public int steviloObranjenihStrelov { get; set; }
        public Vratar() : base()
        {

        }
        public Vratar(string ime, string priimek, int PrejetiGoli, int ObranjeniStreli) : base(ime, priimek)
        {
            steviloPrejetihGolov = PrejetiGoli;
            steviloObranjenihStrelov = ObranjeniStreli;
        }
        //Vratarjeva učinkovitost se izračuna glede na število obranjenih strelov, deljeno s številom vseh strelov
        public override double izracunajUcinkovitostIgralca()
        {
            return steviloObranjenihStrelov / (double)(steviloPrejetihGolov + steviloObranjenihStrelov);
        }
        public override void Izpis()
        {
            Console.WriteLine("Igralec: " + base.Ime + " " + base.Priimek + "\r\n" + "Ucinkovitost vratarja: " + izracunajUcinkovitostIgralca());
        }
    }
}
