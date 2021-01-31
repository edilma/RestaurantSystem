using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class Order
    {
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeID { get; set; }
        public OrderProducts OrderProducts { get; set; }
        public DateTime OrderReceivedDate { get; set; }
        public double OrderTipAmount { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order() { }
        public Order(Customer aCustomer, Employee anEmployee, OrderStatus aStatus, OrderProducts anOrderProducts)
        {
            OrderReceivedDate = DateTime.Now;
            Customer = aCustomer;
            Employee = anEmployee;
            OrderStatus = aStatus;
            OrderProducts = anOrderProducts;
            OrderTipAmount = 0;

        }

    }
}
