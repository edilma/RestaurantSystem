using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(128)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(128)]
        [Display(Name = "Pizza Type")]
        public string PizzaType { get; set; }

        [Required(ErrorMessage = "Pizza Size is required")]
        [Range(10, 30)]
        [Display(Name = "Pizza Size")]
        public int PizzaSize { get; set; }

        [Required(ErrorMessage = "Price must be between $1 and $100")]
        [Range(10, 30)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal  Price { get; set; }
        
        [Required(ErrorMessage = "Estimated Cooking Time in Minutes is required")]
        [Display(Name = "Cooking Time (Minutes)")]
        [Range(1, 50)]

        public int CookingTimeMinutes { get; set; }
       
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        [Display(Name = "Production Cost")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ProductCost { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

        
       


    }
}
