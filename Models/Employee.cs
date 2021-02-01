using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Models
{
    public class Employee
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(128)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(128)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "ZipCode is required")]
        [StringLength(9)]
        public string SocialSecurityNumber { get; set; }
        public bool EmploymentStatus { get; set; }
        public decimal EmployeePayRateAmount { get; set; }
        public virtual ICollection<Order> Orders { get; set; }


        public Employee() { }
      



            }
}
