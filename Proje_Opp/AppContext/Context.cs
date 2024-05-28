using Microsoft.EntityFrameworkCore;
using Proje_Opp.Entity;

namespace Proje_Opp.AppContext
{
    public class Context : DbContext
    {


       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HJS8A4F;Database=OppDb;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
