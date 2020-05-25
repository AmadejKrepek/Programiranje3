using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class ObiskovalecNeObstajaException : Exception
    {
        public ObiskovalecNeObstajaException()
        {
            Console.WriteLine("Obiskovalec ne obstaja!");
        }
    }
}
