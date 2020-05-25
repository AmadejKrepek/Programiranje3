using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Tribuna
    {
        public Dictionary<string, Obiskovalec> obisk { get; set; }
        private int capacity { get; set; }
        public Tribuna(int capacity)
        {
            obisk = new Dictionary<string, Obiskovalec>();
            this.capacity = capacity;
        }
        public void PreveriObiskovalce()
        {
            try
            {
                if (obisk.Count >= capacity)
                {
                    throw new TribunaPolnaException();
                }
            }
            catch (TribunaPolnaException ex)
            {
                DodajiIzjemeFile("izjeme.txt", ex);
            }
            
        }
        public void DodajiIzjemeFile(string path, Exception izjema)
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
