using eCommerceProject.DataAccess.Abstract;
using eCommerceProject.DataAccess.Concrete.EntityFramework.Contexts;
using eCommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceProject.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, eCommerceContext>, ICategoryDal
    {

    }
}
