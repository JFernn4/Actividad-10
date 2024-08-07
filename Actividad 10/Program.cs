using Actividad_10;

bool menu= true;
int option;
List<Product> productList= new List<Product>(); //lista de tipo productos
while (menu)
{
    Console.Clear();
    ShowMenu();
    option=Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 0:
            break;
        case 4:
            {
                Console.Clear ();
                menu = false;
                break;
            }
    }
}
static void ShowMenu()
{
    Console.WriteLine("1. Agregar productos.");
    Console.WriteLine("2. Listar productos registrados.");
    Console.WriteLine("3. Buscar productos por nombre.");
    Console.WriteLine("4. Salir.");
}