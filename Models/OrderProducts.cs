using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class OrderProducts
    {
        public int OrderProductsID { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Products Products { get; set; }
        public int ProductId { get; set; }

        public OrderProducts() { }
    }
}
