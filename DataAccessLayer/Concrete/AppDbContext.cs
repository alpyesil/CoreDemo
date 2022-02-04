using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class AppDbContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=CoreBlogDb; Integrated Security=SSPI;";

            builder.UseSqlServer(connectionString);
        }

    }
}
