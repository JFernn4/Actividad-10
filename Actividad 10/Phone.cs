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
                    Console.WriteLine("Ingresa el tipo de conectividad del producto.");
                    string connectivity = Console.ReadLine();
                    Phone phone = new Phone(name, price, screen, connectivity);//añade un telefono a la lista de productos
                    productList.Add(phone);
                    Console.WriteLine("El producto se ha registrado.");
                    trycatch = false;
                    Console.ReadKey();
                }
                catch (Exception ex) { Console.Clear();  Console.WriteLine("Debe ingresar números. "+ex.Message);}
            }
        }
    }
}