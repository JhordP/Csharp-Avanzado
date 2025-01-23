using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    //Herencia
    class ExpiringBeer : Beer
    {
        public DateTime Expiration { get; set; }
        public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expiration) : base(name, price, alcohol)
        {
            this.Expiration.Equals(expiration);
        }

    }
}
