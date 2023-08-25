using Microsoft.EntityFrameworkCore;

namespace NorthwindWebAPI.Models
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base() 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString: @"server=(localdb)\mssqllocaldb;database=northwind;integrated security=sspi");
        }

        public DbSet<Product> Products { get; set; }
    }
}
