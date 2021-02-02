using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.ViewModel
{
    public class AddOrderViewModel
    {
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Display(Name = "Order Date/Time")]
        public DateTime OrderReceivedDate { get; set; }

        [Range(1, 100, ErrorMessage = "Tip must be between $1 and $100")]
        [Display(Name = "Enter Tip Amount")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal OrderTipAmount { get; set; }
        public List<Product> Products { get; set; }

        public int ProductID { get; set; }
        public List<string> CustomerSelectedProduct { get; set; }


        public AddOrderViewModel()
        { }
        
        
    }
}
