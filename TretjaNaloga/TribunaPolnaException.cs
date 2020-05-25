using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class TribunaPolnaException : Exception
    {
        public Obiskovalec obiskovalec;
        public TribunaPolnaException()
        {
            Console.WriteLine("Tribuna je polna!");
        }
    }
}
