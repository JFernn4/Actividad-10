using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public static void ShowAllProducts(List<Product> productList)
        {
            Console.WriteLine("Lista de productos:");
            foreach (var product in productList)
            {
                if (product is Phone phone)
                {
                    Console.WriteLine($"Nombre: {phone.Name}, Precio: Q.{phone.Price}, Pantalla: {phone.Screen}, Conectividad: {phone.Connectivity}.");
                }
                else if (product is Tablet tablet)
                {
                    Console.WriteLine($"Nombre: {tablet.Name}, Precio: Q.{tablet.Price}, Pantalla: {tablet.Screen}, Conectividad: {tablet.Connectivity}.");
                }
                else if (product is Computer computer)
                {
                    Console.WriteLine($"Nombre: {computer.Name}, Precio: Q.{computer.Price}, Procesador: {computer.Processor}, GPU: {computer.GPU}.");
                }
            }
            Console.ReadKey();
        }
    }

}
