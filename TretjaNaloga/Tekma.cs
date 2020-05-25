using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    interface Prodajni
    {
        void ProdajKarto(Tribuna tribuna, Obiskovalec obiskovalec);
        void PrekliciKarto(Tribuna tribuna, Obiskovalec obiskovalec);
        //bool MestoProsto(Tribuna tribuna);
        //double IzracunajCeno(Obiskovalec obiskovalec);
    }
    class Tekma : Prodajni
    {
        public List<Igralec> domaci = new List<Igralec>();
        public List<Igralec> gosti = new List<Igralec>();
        private string imeStadiona;
        private DateTime datum;
        private int rezultat1;
        private int rezultat2;
        public Karta podatkiKarte { get; set; }
        public string ImeStadiona
        {
            get { return imeStadiona; }
            set { imeStadiona = value; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        public int Result1
        {
            get { return rezultat1; }
            set { rezultat1 = value; }
        }
        public int Result2
        {
            get { return rezultat2; }
            set { rezultat2 = value; }
        }
        public Tekma() { }
        public Tekma(List<Igralec> domaci, List<Igralec> gosti, string imeStadiona, DateTime datum, int rezultat1, int rezultat2)
        {
            this.domaci = domaci;
            this.gosti = gosti;
            this.imeStadiona = imeStadiona;
            this.datum = datum;
            this.rezultat1 = rezultat1;
            this.rezultat2 = rezultat2;
        }
        public void ProdajKarto(Tribuna tribuna, Obiskovalec obiskovalec)
        {
            tribuna.obisk.Add(obiskovalec.Email, obiskovalec);
        }
        public void PrekliciKarto(Tribuna tribuna, Obiskovalec obiskovalec)
        {
            tribuna.obisk.Remove(obiskovalec.Email);
        }
        public void NajdiObiskovalca(Stadion tribuna, Obiskovalec obiskovalec)
        {
            Obiskovalec trenuten;
            for (int i = 0; i < tribuna.nova.Length; i++)
            {
                if (tribuna.nova[i].obisk.ContainsKey(obiskovalec.Email))
                {
                    tribuna.nova[i].obisk.TryGetValue(obiskovalec.Email, out trenuten);
                    Console.WriteLine(trenuten.ime);
                }
                if (tribuna.nova[i] == tribuna.nova[0])
                {
                    Console.WriteLine("jug");
                    break;
                }
                else if (tribuna.nova[i] == tribuna.nova[1])
                {
                    Console.WriteLine("sever");
                    break;
                }
                else if (tribuna.nova[i] == tribuna.nova[2])
                {
                    Console.WriteLine("vzhod");
                    break;
                }
                else if (tribuna.nova[i] == tribuna.nova[3])
                {
                    Console.WriteLine("zahod");
                    break;
                }
            }
        }
        /*
        public bool MestoProsto(Tribuna tribuna)
        {
            for (int i = 0; i < tribuna.posameznaTribuna.Length; i++)
            {
                if (tribuna.posameznaTribuna[i] == null)
                {
                    return true;
                }
            }
            return false;
        }
        */
        /*
        public double IzracunajCeno(Obiskovalec obiskovalec)
        {
            if (obiskovalec.status == Obiskovalec.Status.upokojenec)
            {
                return podatkiKarte.cenaVstopnice - (podatkiKarte.cenaVstopnice * 0.1);
            }
            else if (obiskovalec.status == Obiskovalec.Status.student)
            {
                return podatkiKarte.cenaVstopnice - (podatkiKarte.cenaVstopnice * 0.15);
            }
            else
            {
                return podatkiKarte.cenaVstopnice;
            }
        }
        */
        public void DodajIgralca(Igralec igralec, List<Igralec> ekipa)
        {
            ekipa.Add(igralec);
        }
        public void OdstraniIgralca(Igralec igralec, List<Igralec> ekipa)
        {
            ekipa.Remove(igralec);
        }
        public Igralec VrneZadnjegaDodanegaIgralcaEkipi(List<Igralec> ekipa)
        {
            if (ekipa.Count > 0)
            {
                return ekipa[ekipa.Count - 1];
            }
            else
            {
                return null;
            }
        }
    }
}
