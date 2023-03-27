using Microsoft.EntityFrameworkCore;
using SplashOrders.Domain.Models;

namespace SplashOrders.Domain
{
    public class DataContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
    }
}
