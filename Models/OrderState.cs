using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class OrderState
    {
        public int ID { get; set; }
        public string State  { get; set; }
        public Order Order { get; set; }
        public int OrderID { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeID { get; set; }
        public DateTime  ChangeOrderStateTime { get; set; }

    }
}
