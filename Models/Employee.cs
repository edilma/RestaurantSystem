using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public bool EmploymentStatus { get; set; }
        public double EmployeePayRateAmount { get; set; }


        public Employee() { }
        public Employee (string aName, string aLastName, string aSocialSecurityNumber, double aEmployeePayRateAmount, bool aEmploymentStatus)
        {
            Name = aName;
            LastName = aLastName;
            SocialSecurityNumber = aSocialSecurityNumber;
            EmploymentStatus = aEmploymentStatus;
            EmployeePayRateAmount = aEmployeePayRateAmount;
            

        }




            }
}
