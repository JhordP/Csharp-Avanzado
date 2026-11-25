using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    public abstract class Drink //Clase Abstracta
    {
        public int Quantity { get; set; }

        public Drink(int quantity) => this.Quantity = quantity; //Expresion arrowfunc para constructor

        public string GetQuantity() { return this.Quantity.ToString() + " ml"; } //Retornar la cantidad en milimetros

        public abstract string GetCategory(); //Esto indica que quien herede de esta clase debe definir/implementar este metodo


    }
}
