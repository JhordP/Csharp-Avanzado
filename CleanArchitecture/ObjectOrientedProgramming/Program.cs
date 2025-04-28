using ObjectOrientedProgramming.Business;
using System.Diagnostics;
using System.Xml.Linq;



var delirium = new ExpiringBeer("Delirium", 100, 8, new DateTime(2025, 12, 28));
Console.WriteLine(delirium.GetInfo());

#region Codigo(Antes del NameSpace Business)

//var erdingerBeer = new Beer() //Error porque debes indicarle los parametros en el constructor
//{
//    Name = "Erdinger",
//    Price = 299.99m //Decimal requiere el sufijo M
//};//Si el objeto no requiriera parametros, esto crearia un objeto con el nombre y precio especificados entre las llaves.

//Asume el nombre
//var erdingerBeer2 = new Beer("Erdinger", 299.99m) //Aqui se colocan correctamente los parametros
//{
//Name = "Erdinger",
//Price = 299.99m //Decimal requiere el sufijo M
//};


//var coronaBeer = new Beer("Corona", 160);
//coronaBeer.Name = "Corona";
//coronaBeer.Price = 160;


//Console.WriteLine($"{erdingerBeer2.Name}\n{erdingerBeer2.Price}");
//Console.WriteLine(coronaBeer.GetInfo()); //Lo mismo de arriba pero con el metodo.

//Console.ReadKey();

//public class Beer
//{
//    private decimal _alcohol; //Practica estandar: Si es privado, el campo debe tener un guion bajo, de lo contrario no.
//    public string Name { get; set; } //Practica estandar: Las propiedades inician con mayuscula
//    public decimal Price { get; set; }
//    public decimal Alcohol //Propiedad creada para manejar la variable privada
//    {
//        get { return _alcohol; }
//        set
//        {
//            if (value < 0)
//            {
//                value = 0;
//            }
//            _alcohol = value;
//        } //Configurar la propiedad: Si se le coloca un valor menor que cero, asume el cero y asigna el valor a la variable.
//    }      //Esto es para evitar que la variable sea asignada de manera incorrecta. Por ejemplo, un valor negativo.

//    //Se puede modificar la manera en la que se adquiere la info
//    public string sAlcohol {
//        get { return $"Alcohol: {_alcohol.ToString()}"; }
//    } //De esta manera no se puede modificiar esta propiedad, solo obtener

//    //Metodo constructor, obligando a pasarle los parametros necesarios correspondientes
//    public Beer(string name, decimal price)
//    {
//        this.Name = name;
//        this.Price = price;
//    }

//    public string GetInfo()
//    {
//        return $"Nombre: {Name}, Precio: {Price}, Alcohol: {Alcohol}";
//    }
//}
#endregion