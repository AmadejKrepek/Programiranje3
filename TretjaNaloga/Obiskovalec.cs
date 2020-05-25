using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Obiskovalec
    {
        public string ime { get; set; }
        public string priimek { get; set; }
        public enum Spol { M, Z };
        public Spol spol { get; set; }
        public DateTime datumRojstva { get; set; }
        public string Email { get; set; }
        public enum Status { Student, Upokojenec, Zaposlen, Otrok };
        public Status status { get; set; }
        public Obiskovalec() { }
        public Obiskovalec(string ime, string priimek, Spol spol, Status status, DateTime datumRojstva, string Email)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.spol = spol;
            this.datumRojstva = datumRojstva;
            this.Email = Email;
            this.status = status;
        }
    }
}
