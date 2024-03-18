using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public decimal Price{ get; set; }

        public Car()
        {
            this.Make = "Volkswagen";
            this.Model = "Polo";
            this.Price = 10000M;
        }

        public Car(string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }
    }
}
