using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Odigrane_tekme
    {
        private DateTime datum_tekme;
        private TimeSpan igranje_time;

        public enum Kartoni { rumeni, Dvojni_rumeni, rdeci }

        //Ustvarite naštevalni tip (enum) dogodkov in ga zamenjajte, pri atributu, ki opisuje tip dogodka
        public enum Dogodki
        {
            PRIJATELJSKA, ODPOVEDANA, LIGA, IZREDNA
        }
        public Dogodki dogodki { get; set; }
        //Get and set metode
        public DateTime Datum_tekme
        {
            get { return datum_tekme; }
            set { datum_tekme = value; }
        }
        public TimeSpan Igranje_time
        {
            get { return igranje_time; }
            set { igranje_time = value; }
        }
        public Kartoni karton { get; set; }

        public Odigrane_tekme() { } //Privzeti konstruktor, ki nima parametrov.
        public Odigrane_tekme(DateTime datum_tekme, TimeSpan igranje_time)
        {
            this.datum_tekme = datum_tekme;
            this.igranje_time = igranje_time;
        }
        public Odigrane_tekme(DateTime datum_tekme, TimeSpan igranje_time, Kartoni karton, Dogodki dogodki) : this(datum_tekme, igranje_time)
        {
            this.karton = karton;
            this.dogodki = dogodki;
        }
        //Pri razredu seznama odigranih tekem poskrbite, da metode za izpis ne bo mogoče več predefinirati. 
        //ali seal override ???? //ali je virtual?
        public sealed override string ToString()
        {
            return "Datum tekme: " + datum_tekme + "\r\n" + "Cas tekme: " + igranje_time + "\r\n" + "Karton: " + karton + "\r\n" + "Dogodki: " + dogodki;
        }
    }
}
