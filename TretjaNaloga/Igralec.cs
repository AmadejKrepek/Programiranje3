using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    abstract class Igralec
    {
        private string ime;
        private string priimek;
        private string naslov;
        private bool status_tujca;
        private Nogometni_podatki podatkiFuzbal;
        private Zdravstveni_karton podatkiKartoni;
        public List<Odigrane_tekme> podatkiTekme = new List<Odigrane_tekme>();
        public Nogometni_podatki PodatkiFuzbal
        {
            get { return podatkiFuzbal; }
            set { podatkiFuzbal = value; }
        }
        public Zdravstveni_karton PodatkiKartoni
        {
            get { return podatkiKartoni; }
            set { podatkiKartoni = value; }
        }
        //Get and set metodi
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Priimek
        {
            get { return priimek; }
            set { priimek = value; }
        }
        public string Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }
        public bool Status_tujca
        {
            get { return status_tujca; }
            set { status_tujca = value; }
        }
        public Igralec() { } //Privzeti konstruktor, ki nima nobenih parametrov.
        public Igralec(string ime, string priimek) //Konstruktor, ki prejme nekaj parametrov
        {
            Ime = ime;
            Priimek = priimek;
        }
        public Igralec(string ime, string priimek, List<Odigrane_tekme> podatkiTekme) //Konstruktor, ki prejme nekaj parametrov
        {
            Ime = ime;
            Priimek = priimek;
            this.podatkiTekme = podatkiTekme;
        }
        public Igralec(string ime, string priimek, string naslov, bool status_tujca, Nogometni_podatki podatkiFuzbal, Zdravstveni_karton podatkiKartoni, List<Odigrane_tekme> podatkiTekme) : this(ime, priimek)
        {
            Naslov = naslov;
            Status_tujca = status_tujca;
            PodatkiFuzbal = podatkiFuzbal;
            PodatkiKartoni = podatkiKartoni;
            this.podatkiTekme = podatkiTekme;
        }
        public void IzpisMinut(DateTime terminZacetek, DateTime terminKonec, Igralec igralec)
        {
            TimeSpan vsota = new TimeSpan();
            List<Odigrane_tekme> testTekme = new List<Odigrane_tekme>(igralec.podatkiTekme);
            foreach (Odigrane_tekme datumi in testTekme)
            {
                if (datumi.Datum_tekme >= terminZacetek && datumi.Datum_tekme <= terminKonec)
                {
                    vsota = vsota + datumi.Igranje_time;
                }
            }
            Console.WriteLine(vsota);
        }
        public void IzpisMinut(DateTime terminZacetek, DateTime terminKonec, Igralec igralec, int dnevi)
        {
            TimeSpan vsota = new TimeSpan();
            List<Odigrane_tekme> testTekme = new List<Odigrane_tekme>(igralec.podatkiTekme);
            foreach (Odigrane_tekme datumi in testTekme)
            {
                if (datumi.Datum_tekme >= terminZacetek && datumi.Datum_tekme <= terminKonec && (int)datumi.Datum_tekme.DayOfWeek == dnevi)
                {
                    vsota = vsota + datumi.Igranje_time;
                }
            }
            Console.WriteLine(vsota);
        }
        //Razredu igralca dodajte abstraktno metodo izračunajUčinkovitostIgralca, ki naj vrača decimalno vrednost med 0-1.
        public abstract double izracunajUcinkovitostIgralca();
        //Sem dodal virtual, prej je bilo brez virtual...
        public virtual void Izpis()
        {
            Console.WriteLine("----- Osnovni podatki o igralcu ------");
            Console.WriteLine();
            Console.WriteLine("Ime: {0}", ime);
            Console.WriteLine("Priimek: {0}", priimek);
            Console.WriteLine("Naslov: {0}", naslov);
            Console.WriteLine("Tujec: {0}", status_tujca);
            Console.WriteLine();
            Console.WriteLine("----- Pozicija igralca ------");
            Console.WriteLine(podatkiFuzbal.ToString());
            Console.WriteLine();
            Console.WriteLine("----- Zdravstveni karton ------");
            Console.WriteLine(podatkiKartoni.ToString());
            Console.WriteLine();
            Console.WriteLine("----- Odigrane tekme ------");
        }
    }
}
