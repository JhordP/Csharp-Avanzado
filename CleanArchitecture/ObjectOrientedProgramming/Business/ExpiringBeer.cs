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
        public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expiration) : base(name, price, alcohol)
        {
            this.Expiration = expiration;
        }

        public string GetInfo()
        {
            return $"{new Beer(this.Name, this.Price, this.Alcohol).GetInfo()} Expiracion: {this.Expiration}"; //Format string con objeto
        }
        

    }
}
