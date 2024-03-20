using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList{ get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;
            foreach (Car c in CarList)
            {
                totalCost += c.Price;
            }

            ShoppingList.Clear();
            return totalCost;

        }

    }
}
