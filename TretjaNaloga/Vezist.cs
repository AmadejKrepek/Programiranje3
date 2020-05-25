using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Vezist : Igralec
    {
        public int podajeNaprej { get; set; }
        public int podajeNazaj { get; set; }
        public Vezist() : base()
        {

        }
        public Vezist(string ime, string priimek, int podajaN, int podajaR) : base(ime, priimek)
        {
            podajeNaprej = podajaN;
            podajeNazaj = podajaR;
        }
        //Učinkovitost vezista se računa glede na število podaj naprej, deljeno s številom vseh podaj
        public override double izracunajUcinkovitostIgralca()
        {
            return podajeNaprej / (double)(podajeNaprej + podajeNazaj);
        }
        public override void Izpis()
        {
            Console.WriteLine("Igralec: " + base.Ime + " " + base.Priimek + "\r\n" + "Ucinkovitost vezista: " + izracunajUcinkovitostIgralca());
        }
    }
    //napadalca, ki mu med nogometne podatke dodate število golov in asistenc
}
