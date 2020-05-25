using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Zdravstveni_karton
    {
        private double visina;
        private int starost;
        private double teza;

        //Get and set metode
        public double Visina
        {
            get { return visina; }
            set { visina = value; }
        }
        public int Starost
        {
            get { return starost; }
            set { starost = value; }
        }
        public double Teza
        {
            get { return teza; }
            set { teza = value; }
        }
        public Zdravstveni_karton() { }  //Privzeti konstrukor, ki nima nobenih parametrov.
        public Zdravstveni_karton(double visina, int teza)
        {
            Visina = visina;
            Teza = teza;
        }
        public Zdravstveni_karton(double visina, int teza, int starost) : this(visina, teza)
        {
            Starost = starost;
        }
        public override string ToString()
        {
            return "Starost: " + starost + "let" + "\r\n" + "Teza: " + teza + "kg" + "\r\n" + "Visina: " + visina + "cm";

        }
    }
}
