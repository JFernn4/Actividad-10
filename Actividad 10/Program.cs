using Actividad_10;

bool menu= true;
int option;
List<Product> productList= new List<Product>(); //lista de tipo productos
while (menu)
{
    Console.Clear();
    ShowMenu();
    try
    {
        option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                bool addProductsMenu = true;
                int optionAddProductsMenu;
                Console.Clear();
                while (addProductsMenu)
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione el tipo de producto que desea añadir.");
                    Console.WriteLine("1. Teléfono.");
                    Console.WriteLine("2. Tablet.");
                    Console.WriteLine("3. Computadora.");
                    Console.WriteLine("4. Salir.");
                    try
                    {
                        optionAddProductsMenu = Convert.ToInt32(Console.ReadLine());
                        switch (optionAddProductsMenu)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Phone.AddPhone(productList);
                                    break;
                                }
                            case 2:
                                {
                                    Console.Clear();
                                    Tablet.AddTablet(productList);
                                    break;
                                }
                            case 3:
                                {
                                    Console.Clear();
                                    Computer.AddComputer(productList);
                                    break;
                                }
                            case 4:
                                {
                                    Console.Clear();
                                    addProductsMenu = false;
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ingresa un número del 1 al 4. " +ex.Message);
                        Console.ReadKey();
                    }
                }
                break;
            case 2:
                {
                    Console.Clear();
                    Product.ShowAllProducts(productList);
                    break;
                }
            case 3:
                {
                    Console.Clear();
                    if (productList.Count != 0)
                    {
                        Product.SearchProduct(productList);
                    }
                    else
                    {
                        Console.WriteLine("La lista de productos está vacía.");
                        Console.ReadKey();
                    }
                    break;
                }
            case 4:
                {
                    Console.Clear();
                    menu = false;
                    break;
                }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ingresa un número del 1 al 4. "+ex.Message);
        Console.ReadKey();
    }
}
static void ShowMenu()
{
    Console.WriteLine("1. Agregar productos.");
    Console.WriteLine("2. Listar productos registrados.");
    Console.WriteLine("3. Buscar productos por nombre.");
    Console.WriteLine("4. Salir.");
}