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
        case 1:
            bool addProductsMenu= true;
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
                optionAddProductsMenu = Convert.ToInt32(Console.ReadLine());
                switch (optionAddProductsMenu)
                {
                    case 1:
                        {
                            Console.Clear ();
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
                Product.SearchProduct(productList);
                break;
            }
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