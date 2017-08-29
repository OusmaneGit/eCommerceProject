using eCommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceProject.DataAccess.Concrete.EntityFramework.Mappping
{
    public  class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(t => t.Id);

            Property(t => t.UserName).IsRequired();
            Property(t => t.UserName).IsRequired();

            ToTable("Users");

            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.UserName).HasColumnName("UserName");
            Property(t => t.Password).HasColumnName("Password");
        }
    }
}
