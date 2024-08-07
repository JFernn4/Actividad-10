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
        public static void AddPhone(List<Product> productList)
        {
            Console.WriteLine("Ingresa el nombre del producto.");
            string name= Console.ReadLine();
            Console.WriteLine("Ingresa el precio del producto.");
            double price= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tipo de pantalla del producto.");
            string screen= Console.ReadLine();
            Console.WriteLine("Ingresa el tipo de conectividad del producto.");
            string connectivity= Console.ReadLine();
            Phone phone= new Phone (name,price,screen,connectivity);//añade un telefono a la lista de productos
            productList.Add(phone);
            Console.WriteLine("El producto se ha registrado.");
            Console.ReadKey();
        }
    }
}