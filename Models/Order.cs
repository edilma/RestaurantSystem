using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Models
{
    public class Order
    {
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderReceivedDate { get; set; }
        
        [Range(1, 100, ErrorMessage = "Tip must be between $1 and $100")]
        public decimal OrderTipAmount { get; set; }
        public ICollection<OrderStatus> States { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public Order() { }
        

    }
}
