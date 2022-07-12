using Microsoft.EntityFrameworkCore;
using OrdersServiceDAL.Models;

namespace OrdersServiceDAL.Database
{
    public class ShippingContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public ShippingContext(DbContextOptions<ShippingContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
    }
}