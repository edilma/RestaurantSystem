using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class HoursWork
    {
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Date { get; set; }
        public int HoursWorkAmount { get; set; }

        public HoursWork() { }
        public HoursWork(Employee anEmployee, int anHoursWorkAmount)
        {
            Employee = anEmployee;
            Date = DateTime.Today;
            HoursWorkAmount = anHoursWorkAmount;

        }

    }
}
