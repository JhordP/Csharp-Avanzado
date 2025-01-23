using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    class Beer
    {
        private decimal _alcohol;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Alcohol
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

        //Metodo constructor
        public Beer(string name, decimal price, decimal alcohol)
        {
            this.Name = name;
            this.Price = price;
            this.Alcohol = alcohol;
        }

        public string GetInfo()
        {
            return $"Nombre: {Name}, Precio: {Price}, Alcohol: {Alcohol}%";
        }
    }
}
