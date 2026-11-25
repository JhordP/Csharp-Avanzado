using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    //Herencia
    public class ExpiringBeer : Beer
    {
        public DateTime Expiration { get; set; }
        public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expiration, int quantity) : base(name, price, alcohol, quantity)
        {
            this.Expiration = expiration;
        }

        //Arrow function, retorna lo que esta en la flecha
        public override string GetInfo() => $"{base.GetInfo()} Expiracion: {this.Expiration}"; //Format string con objeto


    }
}
