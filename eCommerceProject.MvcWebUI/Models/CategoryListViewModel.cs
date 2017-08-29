using System.Collections.Generic;
using eCommerceProject.Entities.Concrete;

namespace eCommerceProject.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int? CurrentCategory { get; set; }
    }
}