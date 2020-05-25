using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Stadion
    {
        public Tribuna[] nova { get; set; }
        public Stadion(Tribuna jug, Tribuna sever, Tribuna vzhod, Tribuna zahod)
        {
            nova = new Tribuna[] { jug, sever, vzhod, zahod };
        }
    }
}
