using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get { return Make; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Make = value;
                } else
                {
                    throw new ArgumentException("Make cannot be empty!");
                }
            }
            
        }
        public string Model { get { return Model; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Model = value;
                } else
                {
                    throw new ArgumentException("Model cannot be empty!");
                }
            }
        }

        public decimal Price{ get; set; }

        public Car()
        {
            Make = Make;
            Model = Model;
            Price = Price;
        }

        public Car(string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }

        override public String ToString()
        {
            return $"Your Car {Make} {Model} is added into the inventory and cost price is {Price} ";
        }
    }
}
