using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vpisani podatki za odigrane tekme
            Odigrane_tekme tekma = new Odigrane_tekme(new DateTime(2019, 5, 12), new TimeSpan(1, 23, 20), Odigrane_tekme.Kartoni.Dvojni_rumeni, Odigrane_tekme.Dogodki.IZREDNA);
            Odigrane_tekme tekma2 = new Odigrane_tekme(new DateTime(2020, 3, 10), new TimeSpan(0, 33, 11), Odigrane_tekme.Kartoni.rdeci, Odigrane_tekme.Dogodki.LIGA);
            Odigrane_tekme tekma3 = new Odigrane_tekme(new DateTime(2019, 5, 3), new TimeSpan(0, 22, 40), Odigrane_tekme.Kartoni.rumeni, Odigrane_tekme.Dogodki.ODPOVEDANA);
            //Dodajanje tekem in casov...
            List<Odigrane_tekme> dodajTekmo = new List<Odigrane_tekme>();
            dodajTekmo.Add(tekma);
            dodajTekmo.Add(tekma2);
            dodajTekmo.Add(tekma3);

            Igralec igralec1 = new Vratar("Jan", "Oblak", 3, 10);
            Igralec igralec2 = new ObrambniIgralec("Sergio", "Ramos", ObrambniIgralec.Polozaj.centralni);
            Igralec igralec4 = new Napadalec("Robert", "Lewandowski", dodajTekmo, 0, 1);
            /*
            igralec1.Izpis();
            Console.WriteLine();
            igralec2.Izpis();
            Console.WriteLine();
            igralec4.Izpis();
            */

            Vratar vratar = new Vratar("Marko", "Novak", 10, 20);
            vratar.Ime = igralec1.Ime;
            ObrambniIgralec obrambni = new ObrambniIgralec("Gustav", "Podsledik", ObrambniIgralec.Polozaj.desni);
            Vezist vezist = new Vezist("Jure", "Mackonja", 20, 9);
            Napadalec napadalec = new Napadalec("Tine", "Podgorevc", dodajTekmo, 2, 10);
            /*
            vratar.Izpis();
            Console.WriteLine();
            obrambni.Izpis();
            Console.WriteLine();
            vezist.Izpis();
            Console.WriteLine();
            napadalec.Izpis();
            */

            List<Igralec> domaci = new List<Igralec>();
            List<Igralec> gosti = new List<Igralec>();
            domaci.Add(obrambni);
            domaci.Add(napadalec);
            gosti.Add(igralec2);
            gosti.Add(igralec4);

            //Tribuna jug = new Tribuna(200);
            //Tribuna sever = new Tribuna(200);
            //Tribuna vzhod = new Tribuna(200);
            //Tribuna zahod = new Tribuna(200);
            //Stadion stadion = new Stadion(jug, sever, vzhod, zahod);

            Tekma prvaTekma = new Tekma(domaci, gosti, "Camp Nou", new DateTime(2020, 4, 17), 2, 0);
            Tekma drugaTekma = new Tekma(domaci, gosti, "Camp Nou", new DateTime(2021, 3, 7), 1, 0);

            Obiskovalec hrvat = new Obiskovalec("Jure", "Dipsy", Obiskovalec.Spol.M, Obiskovalec.Status.Zaposlen, new DateTime(2000, 3, 4), "jozeg@gmail.com");
            Obiskovalec slovenec = new Obiskovalec("Marko", "Novcic", Obiskovalec.Spol.M, Obiskovalec.Status.Zaposlen, new DateTime(1990, 12, 25), "marko.novcic@gmail.com");
            Obiskovalec nemec = new Obiskovalec("Ana", "Babic", Obiskovalec.Spol.Z, Obiskovalec.Status.Zaposlen, new DateTime(1992, 10, 23), "ana.babic@gmail.com");
            Obiskovalec nemec1 = new Obiskovalec("Ana", "Babic", Obiskovalec.Spol.Z, Obiskovalec.Status.Zaposlen, new DateTime(1992, 10, 23), "ana1.babic@gmail.com");


            Karta prva = new Karta(20, 20.33, hrvat);

            prvaTekma.DodajIgralca(obrambni, domaci);
            prvaTekma.VrneZadnjegaDodanegaIgralcaEkipi(domaci);
            //prvaTekma.NajdiObiskovalca(stadion, hrvat);

            Dictionary<string, Obiskovalec> dodajIgralca = new Dictionary<string, Obiskovalec>();
            dodajIgralca.Add(hrvat.Email, hrvat);

            //prvaTekma.ProdajKarto(jug, hrvat);
            //prvaTekma.ProdajKarto(jug, hrvat);
            //prvaTekma.PrekliciKarto(jug, hrvat);
            //prvaTekma.ProdajKarto(jug, hrvat);
            //prvaTekma.IzracunajCeno(hrvat);

            //----------------------------------------------------------------------------------------------
            /*

            PrijavaObiskovalcev prijava = new PrijavaObiskovalcev();
            prijava.Preberi("seznamA.csv");
            prijava.Preberi("seznamB.csv");
            prijava.Povprasevanje();
            //prijava.DodajNovegaObiskovalca(hrvat);
            prijava.DodajNovegaObiskovalca(slovenec);
            prijava.DodajNovegaObiskovalca(nemec);
            prijava.DodajNovegaObiskovalca(nemec1);
            try
            {
                prijava.OdstraniObiskovalca(hrvat);
            }
            catch (ObiskovalecNeObstajaException posebna)
            {
                prijava.DodajiIzjemeFile1("izjeme.txt", posebna);
            }

            prijava.Izpisi("seznamObiskovalcevIzhod.csv", prijava.RazvrstiObiskovalce());

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Imena in priimki oseb, ki so se rodile meseca maja: ");
            Console.WriteLine();
            prijava.OsebeRojeneMesecaMaja();
            Console.WriteLine("----------------------------------------------------------");
            prijava.SteviloOsebMoskegaSpola();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Osebe, katerim pripada status studenta: ");
            Console.WriteLine();
            prijava.OsebeStatusStudenta();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Ime in priimek najmlajsega studenta: ");
            Console.WriteLine();
            prijava.NajmlajsiStudent();
            Console.WriteLine("----------------------------------------------------------");
            */


            Referat feri = new Referat("Feri");
            Referat fri = new Referat("Fri");

            Zaposleni zaposlen1 = new Zaposleni("Stanko", "Mravljincar", "Elektricar");
            Zaposleni zaposlen2 = new Zaposleni("Tilen", "Potocnik", "Sadjar");

            Student student = new Student("Janko", "Macjak", 203123);

            zaposlen1.PrijaviSeNaObvestilo(feri);
            zaposlen2.PrijaviSeNaObvestilo(feri);
            student.PrijaviSeNaObvestilo(fri);

            feri.Izpis(feri.naziv, "Pripravljamo vam nov ucni nacrt!");
            fri.Izpis(fri.naziv, "Kulturni dogodki bodo preklicani, zaradi bolezni!");
        }
    }
}