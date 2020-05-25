using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class PrijavaObiskovalcev
    {
        private List<Obiskovalec> obisk { get; set; }
        public PrijavaObiskovalcev() { obisk = new List<Obiskovalec>(); }

        public void Preberi(string path)
        {
            string[] podatki = File.ReadAllLines(path);
            foreach (var line in podatki.Skip<string>(1))
            {
                string[] vrstica = line.Split(',', ';');
                Enum.TryParse(vrstica[3], out Obiskovalec.Status status);
                Enum.TryParse(vrstica[2], out Obiskovalec.Spol spol);

                obisk.Add(new Obiskovalec(vrstica[0], vrstica[1], spol, status, DateTime.Parse(vrstica[4]), vrstica[5]));
            }
        }
        public void Povprasevanje()
        {
            List<Obiskovalec> rezultat = obisk.FindAll(o => (o.priimek == "Knez"));
            foreach (var item in rezultat)
            {
                //Console.WriteLine(item.ime);
                obisk.Remove(item);
            }

            DateTime min = obisk.Min(o => o.datumRojstva);

            rezultat = obisk.FindAll(o => (o.datumRojstva == min));
            foreach (var item in rezultat)
            {
                //Console.WriteLine(item.ime);
                obisk.Remove(item);
            }
        }
        public Stadion RazvrstiObiskovalce()
        {
            Tribuna jug = new Tribuna(2);
            Tribuna sever = new Tribuna(5);
            Tribuna vzhod = new Tribuna(5);
            Tribuna zahod = new Tribuna(2);
            //Sortiranje po priimkih
            var order = from s in obisk
                        orderby s.priimek
                        select s;
            //stadion, list, status...zanka cez obiske, nad vsakim preveris obiskovalec.status ali je moski, zaposlen itd.
            //na katero tribuno mora iti zaposleni, pogledas kje mas na stadionu severno tribuno...
            int stevec = 0;
            foreach (var item in order)
            {
                if (Obiskovalec.Status.Otrok == item.status)
                {
                    vzhod.obisk.Add(item.Email, item); //6
                }
                if (Obiskovalec.Status.Student == item.status)
                {
                    sever.obisk.Add(item.Email, item); //9
                }
                if (Obiskovalec.Status.Upokojenec == item.status)
                {
                    zahod.obisk.Add(item.Email, item); //3
                }
                if (Obiskovalec.Status.Zaposlen == item.status)
                {
                    jug.PreveriObiskovalce();
                    jug.obisk.Add(item.Email, item); //3
                    stevec++;
                }
            }
            Console.WriteLine(stevec);
            Stadion stadion1 = new Stadion(jug, sever, vzhod, zahod);
            return stadion1;
        }
        public void DodajNovegaObiskovalca(Obiskovalec novi)
        {
            obisk.Add(novi);
        }
        public void OdstraniObiskovalca(Obiskovalec obiskovalec)
        {
            if (!obisk.Remove(obiskovalec))
            {
                throw new ObiskovalecNeObstajaException();
            }
        }
        public void Izpisi(string path, Stadion stadion1)
        {
            string[] jug = stadion1.nova[0].obisk.Select(kvp => "Jug" + "\r\n" + kvp.Value.ime + "," + kvp.Value.priimek + "," + kvp.Value.spol + "," + 
                kvp.Value.status + "," + kvp.Value.datumRojstva + "," + kvp.Value.Email).ToArray();
            string[] sever = stadion1.nova[1].obisk.Select(kvp => "Sever" + "\r\n" + kvp.Value.ime + "," + kvp.Value.priimek + "," + kvp.Value.spol + "," +
                kvp.Value.status + "," + kvp.Value.datumRojstva + " " + kvp.Value.Email).ToArray();
            string[] vzhod = stadion1.nova[2].obisk.Select(kvp => "Vzhod" + "\r\n" + kvp.Value.ime + "," + kvp.Value.priimek + "," + kvp.Value.spol + "," +
                kvp.Value.status + "," + kvp.Value.datumRojstva + " " + kvp.Value.Email).ToArray();
            string[] zahod = stadion1.nova[3].obisk.Select(kvp => "Zahod" + "\r\n" + kvp.Value.ime + "," + kvp.Value.priimek + "," + kvp.Value.spol + "," +
                kvp.Value.status + "," + kvp.Value.datumRojstva + "," + kvp.Value.Email).ToArray();
            File.AppendAllLines(path, jug);
            File.AppendAllLines(path, sever);
            File.AppendAllLines(path, vzhod);
            File.AppendAllLines(path, zahod);

        }
        public void OsebeRojeneMesecaMaja()
        {
            List<Obiskovalec> neke = new List<Obiskovalec>();

            //Lambda funkcija
            neke = obisk.FindAll(o => (o.datumRojstva.Month == 5));

            foreach (var item in neke)
            {
                Console.WriteLine(item.ime + " " + item.priimek);
            }
        }
        public void SteviloOsebMoskegaSpola()
        {
            //Lambda funkcija
            int neke = obisk.FindAll(o => (o.spol == Obiskovalec.Spol.M)).Count;
            Console.WriteLine("Stevilo oseb moskega spola: " + neke);
        }
        public void OsebeStatusStudenta()
        {
            List<Obiskovalec> neke = new List<Obiskovalec>();
            //Lambda funkcija
            neke = obisk.FindAll(o => (o.status == Obiskovalec.Status.Student));

            //Sortiranje po imenu in priimku
            var order = from s in neke
                        orderby s.priimek, s.ime
                        select s;

            foreach (var item in order)
            {
                Console.WriteLine(item.ime + " " + item.priimek + " " + item.status + " " + item.datumRojstva);
            }
        }
        public void NajmlajsiStudent()
        {
            List<Obiskovalec> neke = new List<Obiskovalec>();

            //Lambda funkcija
            neke = obisk.FindAll(o => (o.status == Obiskovalec.Status.Student));
            DateTime max = neke.Max(o => o.datumRojstva);
            Obiskovalec ob = neke.Find(o => o.datumRojstva == max);


            Console.WriteLine(ob.ime + " " + ob.priimek + " " + ob.status + " " + ob.datumRojstva);
        }
        public void DodajiIzjemeFile1(string path, Exception izjema)
        {
            using (StreamWriter zapisovalnik = new StreamWriter(path, true))
            {
                zapisovalnik.WriteLine("---------------------------------------------------------");
                zapisovalnik.WriteLine("Datum in čas dogodka: " + DateTime.Now.ToString());
                zapisovalnik.WriteLine();

                while (izjema != null)
                {
                    zapisovalnik.WriteLine("Tip dogodka : " + izjema.GetType().Name);
                    zapisovalnik.WriteLine("Sporocilo izjeme : " + izjema.Message);

                    izjema = izjema.InnerException;
                }
            }
        }
    }
}
