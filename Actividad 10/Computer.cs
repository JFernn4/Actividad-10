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
        public int Battery { get; set; }
        public string Screen {  get; set; }
        public string Connectivity { get; set; }
    }
}
