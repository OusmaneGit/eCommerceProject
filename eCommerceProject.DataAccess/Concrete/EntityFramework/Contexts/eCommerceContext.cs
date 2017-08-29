using eCommerceProject.DataAccess.Concrete.EntityFramework.Mappping;
using eCommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceProject.DataAccess.Concrete.EntityFramework.Contexts
{
    public class eCommerceContext:DbContext
    {
        public eCommerceContext():base("Name=eCommerceContext")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
        }

    }
}
