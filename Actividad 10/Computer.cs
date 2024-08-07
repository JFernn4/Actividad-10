using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    internal class Computer : Product
    {
        public string Processor { get; set; }
        public double GPU { get; set; }
       public Computer(string name, double price, string processor, double gPU):base (name,price)
        {
            Processor = processor;
            GPU = gPU;
        }
    }
}
