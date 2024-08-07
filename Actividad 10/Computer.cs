using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    internal class Computer : Product
    {
        public string Processor { get; set; }
        public string GPU { get; set; }
       public Computer(string name, double price, string processor, string gPU):base (name,price)
        {
            Processor = processor;
            GPU = gPU;
        }
        public static void AddComputer(List<Product> productList)
        {
            Console.WriteLine("Ingresa el nombre del producto.");
            string name= Console.ReadLine();
            Console.WriteLine("Ingresa el precio del producto.");
            double price= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el procesador del producto.");
            string processor= Console.ReadLine();
            Console.WriteLine("Ingresa el GPU del producto.");
            string gPU= Console.ReadLine();
            Computer computer= new Computer(name, price, processor, gPU);
            productList.Add(computer);
            Console.WriteLine("El producto se ha registrado.");
            Console.ReadKey();
        }
    }
}
