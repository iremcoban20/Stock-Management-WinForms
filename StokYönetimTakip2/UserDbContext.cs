using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StokYönetimTakip2
{
    
    internal class UserDbContext:DbContext
    {
        public UserDbContext() : base("name=UserDbContext")
        {

        }
        public DbSet<Users> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductUser> ProductUsers { get; set; }
    }
}
