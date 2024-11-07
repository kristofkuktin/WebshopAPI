using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using WebshopAPI.Entities;

namespace WebshopAPI.Context
{
    public class WebshopContext : DbContext
    {
        public WebshopContext(DbContextOptions<WebshopContext> options) : base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
