using Microsoft.EntityFrameworkCore;
using Proje_Opp.Entity;

namespace Proje_Opp.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HJS8A4F;Database=OppDb;Trusted_Connection=True;integratedsecurity=true");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
