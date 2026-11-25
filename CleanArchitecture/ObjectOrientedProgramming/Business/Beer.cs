using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    public class Beer : Drink
    {
        private const string Category = "Cerveza";

        private decimal _alcohol; //Practica estandar: Si es privado, el campo debe tener un guion bajo, de lo contrario no.
        public string Name { get; set; } //Practica estandar: Las propiedades inician con mayuscula
        public decimal Price { get; set; }
        public decimal Alcohol //Propiedad creada para manejar la variable privada
        {
            get { return _alcohol; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _alcohol = value;
            } //Configurar la propiedad: Si se le coloca un valor menor que cero, asume el cero y asigna el valor a la variable.
        }      //Esto es para evitar que la variable sea asignada de manera incorrecta.

        //Se puede modificar la manera en la que se adquiere la info
        public string sAlcohol { get { return $"Alcohol: {_alcohol.ToString()}"; } } //De esta manera no se puede modificiar esta propiedad, solo obtener

        //Metodo constructor obligando a pasarle los parametros necesarios correspondientes
        public Beer(string name, decimal price, decimal alcohol, int quantity) : base (quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Alcohol = alcohol;
        }

        public virtual string GetInfo() //Virtual permite la sobreescritura del metodo desde las clases hijas
        {
            return $"Nombre: {Name}, Precio: {Price}, Alcohol: {Alcohol}%";
        }

        //Sobrecarga de metodos
        public string GetInfo(string message)
        {
            return $"{message} {GetInfo()}";
        }

        public string GetInfo(int number)
        {
            return $"{number}.- {GetInfo()}";
        }

        public override string GetCategory() => Category; //Metodo implementado de la clase abstracta que solo la define.
        
    }
}
