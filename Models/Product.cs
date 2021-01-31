using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PizzaType { get; set; }
        public int PizzaSize { get; set; }
        public double  Price { get; set; }
        public int CookingTimeMinutes { get; set; }
        public double ProductCost { get; set; }

        public Product() { }
        public Product(string aName, string aPizzaType, int aPizzaSize, double aPrice , int aCookingTimeMinutes , double aProductCost)
        {
            Name = aName;
            PizzaType = aPizzaType;
            PizzaSize = aPizzaSize ;
            Price = aPrice;
            CookingTimeMinutes = aCookingTimeMinutes;
            ProductCost = aProductCost;


        }


    }
}
