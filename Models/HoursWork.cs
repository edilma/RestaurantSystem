using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class HoursWork
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime WorkDate { get; set; }
        public int HoursWorkAmount { get; set; }

        public HoursWork() { }
        public HoursWork(int anEmployeeId, DateTime aWorkDate , int anHoursWorkAmount)
        {
            EmployeeID = anEmployeeId;
            WorkDate = aWorkDate;
            HoursWorkAmount = anHoursWorkAmount;

        }

    }
}
