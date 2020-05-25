using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Napadalec : Igralec
    {
        public int steviloGolov { get; set; }
        public int steviloAsistenc { get; set; }
        public Napadalec() : base()
        {

        }
        public Napadalec(string ime, string priimek, List<Odigrane_tekme> podatkiTekme, int numberOfGoals, int numberOfAssistence) : base(ime, priimek, podatkiTekme)
        {
            steviloGolov = numberOfGoals;
            steviloAsistenc = numberOfAssistence;
        }
        //Učinkovitost napadalca se računa glede na seštevek števila asistenc in golov ulomljeno s številom odigranih tekem,
        //pri čemer vse vrednosti nad 1 zaokrožite na 1.
        public override double izracunajUcinkovitostIgralca()
        {
            double vsota = (steviloAsistenc + steviloGolov) / (double)podatkiTekme.Count; //je .count okej?
            if (vsota >= 1)
            {
                return 1;
            }
            return vsota;
        }
        public override void Izpis()
        {
            Console.WriteLine("Igralec: " + base.Ime + " " + base.Priimek + "\r\n" + "Ucinkovitost napadalca: " + izracunajUcinkovitostIgralca());
        }
    }
}
