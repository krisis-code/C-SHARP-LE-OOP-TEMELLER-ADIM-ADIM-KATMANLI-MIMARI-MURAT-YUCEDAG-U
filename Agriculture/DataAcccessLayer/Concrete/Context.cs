using Entitylayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        

        public DbSet<Adress> Adress { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Team> Teams { get; set; }

    }
}
