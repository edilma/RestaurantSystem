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
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "ZipCode is required")]
        [StringLength(5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Social Security Number is required")]
        [StringLength(9)]
        [Display(Name = "Social Security Number")]
        public string SocialSecurityNumber { get; set; }

        [Display(Name = "Check Box If Employee is Active")]
        public bool EmploymentStatus { get; set; }

        [Display(Name = "Hourly Pay")]
        public decimal EmployeePayRateAmount { get; set; }

        public List<Order> EmployeeOrders { get; set; }

        public List <HoursWork> EmployeeHoursWork { get; set; }


        public Employee() { }
      



            }
}
