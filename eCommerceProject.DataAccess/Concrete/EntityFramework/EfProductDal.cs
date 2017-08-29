using eCommerceProject.DataAccess.Abstract;
using eCommerceProject.DataAccess.Concrete.EntityFramework.Contexts;
using eCommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceProject.Entities.ComplexTypes;

namespace eCommerceProject.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, eCommerceContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            throw new NotImplementedException();
        }

      

        public int GetProductsCountByCategory(int? categoryId)
        {
            using (var context = new eCommerceContext())
            {
                if(categoryId==null)
                {
                    return context.Products.Count();
                }
                return context.Products.Count(p => p.CategoryId == categoryId);
            }
        }
    }
}
