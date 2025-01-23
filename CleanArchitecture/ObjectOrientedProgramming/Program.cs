// See https://aka.ms/new-console-template for more information

//Asume el nombre 
var erdingerBeer = new Beer() //Error porque debes indicarle los parametros en el constructor
{
    Name = "Erdinger",
    Price = 299.99m //Decimal requiere el sufijo M
};

var coronaBeer = new Beer("Corona", 160);
//coronaBeer.Name = "Corona";
//coronaBeer.Price = 160;


Console.WriteLine($"{erdingerBeer.Name}\n{erdingerBeer.Price}");
Console.WriteLine(coronaBeer.GetInfo()); //Lo mismo de arriba pero con el metodo.

public class Beer
{
    private decimal _alcohol;
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Alcohol 
    {
        get { return _alcohol; }
        set { if (value < 0)
            {
                value = 0;
            } _alcohol = value;
        } //Configurar la propiedad: Si se le coloca un valor menor que cero, asume el cero y asigna el valor a la variable.
    }      //Esto es para evitar que la variable sea asignada de manera incorrecta.

    //Se puede modificar la manera en la que se adquiere la info
    public string sAlcohol { get { return $"Alcohol: {_alcohol.ToString()}"; } } //De esta manera no se puede modificiar esta propiedad, solo obtener

    //Metodo constructor
    public Beer(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public string GetInfo()
    {
        return $"Nombre: {Name}, Precio: {Price}, Alcohol: {Alcohol}";
    }
}