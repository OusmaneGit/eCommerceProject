using eCommerceProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceProject.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
