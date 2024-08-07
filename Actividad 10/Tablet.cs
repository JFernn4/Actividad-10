using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    internal class Tablet : Product
    {
        public string Screen {  get; set; }
        public string Connectivity { get; set; }

        public Tablet(string name, double price, string screen, string connectivity) : base(name, price)
        {
            Screen = screen;
            Connectivity = connectivity;
        }
    }
}
