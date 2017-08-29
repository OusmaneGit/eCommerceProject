using System.Collections.Generic;
using System.Web.Mvc;
using eCommerceProject.Entities.Concrete;

namespace eCommerceProject.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public List<SelectListItem> Categories { get; set; }
        public Product Product { get; set; }
    }
}