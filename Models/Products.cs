using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PizzaType { get; set; }
        public int PizzaSize { get; set; }
        public double  Price { get; set; }
        public DateTime CookingTimeMinutes { get; set; }
        public double ProductCost { get; set; }

        public Products() { }
        public Products(string aName, string aPizzaType, double aPrice , DateTime aCookingTimeMinutes , double aProductCost)
        {
            Name = aName;
            PizzaType = aPizzaType;
            PizzaSize = 14;
            Price = aPrice;
            CookingTimeMinutes = aCookingTimeMinutes;
            ProductCost = aProductCost;


        }


    }
}
