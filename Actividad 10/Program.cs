bool menu= true;
int option;
while (menu)
{
    Console.Clear();
    ShowMenu();
    option=Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 0:
            break;
    }
}
static void ShowMenu()
{
    Console.WriteLine("1. Agregar productos.");
    Console.WriteLine("2. Listar productos registrados.");
    Console.WriteLine("3. Buscar productos por nombre.");
    Console.WriteLine("4. Salir.");
}