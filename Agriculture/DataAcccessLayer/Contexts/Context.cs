using Entitylayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options) { }

        

        public DbSet<Adress> Adress { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Announcement> Announcements { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Team> Teams { get; set; }

    }
}
