using EntitiyLayer.Concrete;
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
        public DbSet<About> Abouts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Content> Contents { get; set; }

        public DbSet<Heading> Headings { get; set; }

        public DbSet<Writer> Writers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=BlogDb5;Trusted_Connection=True;MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }

       


    }



}

    


 

