using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    public class Phone : Product
    {
        public string Screen {  get; set; }
        public string Connectivity { get; set; }

        public Phone(string name, double price, string screen, string connectivity) : base(name,price)//llamar constructor de "Product"
        {
            Screen = screen;
            Connectivity = connectivity;
        }
    }
}