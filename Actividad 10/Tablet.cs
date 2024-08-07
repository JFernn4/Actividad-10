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
            string name = "empty";
            double price = 0;
            bool trycatch = true;
            while (trycatch)
            {
                try
                {
                    if (name == "empty")
                    {
                        Console.WriteLine("Ingresa el nombre del producto.");
                        name = Console.ReadLine();
                    }
                    if (price == 0)
                    {
                        Console.WriteLine("Ingresa el precio del producto.");
                        price = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingresa el tipo de pantalla del producto.");
                    string screen = Console.ReadLine();
                    Console.WriteLine("Ingresa el tipo de conectividad que tiene el producto.");
                    string connectivity = Console.ReadLine();
                    Tablet tablet = new Tablet(name, price, screen, connectivity);
                    productList.Add(tablet);
                    Console.WriteLine("El producto se ha registrado.");
                    trycatch=false; 
                    Console.ReadKey();
                }
                    catch (Exception ex) { Console.Clear(); Console.WriteLine("Debes ingresar un número. " + ex.Message); }
            }
        }
    }
}
