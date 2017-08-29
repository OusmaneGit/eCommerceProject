using System.Collections.Generic;
using eCommerceProject.Entities.Concrete;

namespace eCommerceProject.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}