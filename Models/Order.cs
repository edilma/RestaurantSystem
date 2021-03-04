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

        [Display(Name = "Order Date/Time")]
        public DateTime OrderReceivedDate { get; set; }
        
        [Range(1, 100, ErrorMessage = "Tip must be between $1 and $100")]
        [Display(Name = "Enter Tip Amount")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal OrderTipAmount { get; set; }
        public  List<OrderState> OrderState { get; set; }
        public  List<Product> Products { get; set; }
        public Order() { }
        

    }
}
