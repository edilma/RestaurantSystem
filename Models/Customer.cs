using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "ZipCode is required")]
        [StringLength(5)]
        public string ZipCode { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public Customer() { }
      
    }
}
