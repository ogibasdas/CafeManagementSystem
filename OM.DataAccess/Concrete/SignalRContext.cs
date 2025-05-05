using Microsoft.EntityFrameworkCore;
using OM.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.DataAccess.Concrete
{
    public class SignalRContext: DbContext
    {

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=OGUZ\\SQLEXPRESS;Initial Catalog=SignalRDb;Integrated Security=True;TrustServerCertificate=True;");


        }

        public  DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Reference> References { get; set; }  



    }
}
