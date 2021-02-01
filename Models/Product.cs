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
        [MaxLength(50)]
        [Display(Name = "Pizza Type")]
        public string PizzaType { get; set; }

        [Required(ErrorMessage = "Pizza Size is required")]
        [StringLength(2)]
        [Display(Name = "Pizza Size")]
        public int PizzaSize { get; set; }
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        public decimal  Price { get; set; }
        
        [Required(ErrorMessage = "Pizza Size is required")]
        [StringLength(2)]
        [Display(Name = "Estimated Cooking Time in Minutes")]
        public int CookingTimeMinutes { get; set; }
       
        [Range(1, 100, ErrorMessage = "Price must be between $1 and $100")]
        [Display(Name = "Production Cost")]
        public decimal ProductCost { get; set; }
        
        public Product() { }
       


    }
}
