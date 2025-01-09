// See https://aka.ms/new-console-template for more information

//Programacion Estructurada: Programa de ejemplo


int limit = 10; //Variable guardando valor limite.
var beers = new string[limit]; //Declaracion de arreglo "cerveza"
int iBeers = 0; //Iterador

int op = 0; //Opciones de usuario

do //Menu Do While
{
    Console.Clear(); //Limpiar la consola
    ShowMenu();
    op = int.Parse(Console.ReadLine());

    switch (op) //Opciones del menu
    {
        case 1:
            if (iBeers < limit) //Si el iterador sigue siendo menor que el limite del array...
            {
                //...Limpia la consola y asigna el valor de la variable a una posicion del array 
                Console.Clear();
                Console.WriteLine("Escribe el nombre de la cerveza.");
                String beer = Console.ReadLine();
                beers[iBeers] = beer;
                iBeers++;
            }
            else
            {
                Console.WriteLine("Ya no caben cervezas.");
            }
            break;
        case 2:
            ShowBeers(beers, iBeers);
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Bye bye!");
            break;
        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }
}
while (op != 3); //Mientras la opcion no sea 3, sigue yendo a las opciones

void ShowMenu()
{
    Console.WriteLine("1. Agregar nombre");
    Console.WriteLine("2. Mostrar nombres");
    Console.WriteLine("3. Salir");
}

void ShowBeers(string[] beers, int iBeers)
{
    Console.Clear();
    Console.WriteLine("-----Cervezas-----");
    for (int i = 0; i <= iBeers; i++)
    {
        Console.WriteLine(beers[i]);
    } //Muestra cada una de las cervezas
    Console.WriteLine("Presiona una tecla para continuar.");
    Console.ReadKey(); //Pausa para evitar que vaya automaticamente a iniciar el menu
}

