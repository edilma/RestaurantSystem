using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.ViewModel
{
    public class AddCustomerViewModel
    {
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^[0-9]{10}$",
        ErrorMessage = "Only NUMBERS are allowed")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address or Walk-in Customer", Prompt = "Walk-in Customer")]
        public string Address { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(5)]
        public string ZipCode { get; set; }
        
        public AddCustomerViewModel() { }
    }
}
