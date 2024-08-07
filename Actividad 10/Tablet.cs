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
        public static void AddTablet(List<Product> productList)
        {
            Console.WriteLine("Ingresa el nombre del producto.");
            string name= Console.ReadLine();
            Console.WriteLine("Ingresa el precio del producto.");
            double price= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tipo de pantalla del producto.");
            string screen= Console.ReadLine();
            Console.WriteLine("Ingresa el tipo de conectividad que tiene el producto.");
            string connectivity= Console.ReadLine();
            Tablet tablet= new Tablet (name, price, screen, connectivity);
            productList.Add(tablet);
        }
    }
}
