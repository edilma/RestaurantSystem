using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Models;

namespace RestaurantSystem.Data
{
    public class RestaurantSystemContext : DbContext
    {
        public RestaurantSystemContext (DbContextOptions<RestaurantSystemContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantSystem.Models.Employee> Employee { get; set; }

        public DbSet<RestaurantSystem.Models.Customer> Customer { get; set; }
    }
}
