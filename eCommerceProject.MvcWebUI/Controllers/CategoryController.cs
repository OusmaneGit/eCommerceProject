using eCommerceProject.Business.Abstract;
using eCommerceProject.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerceProject.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categorieService;
        public CategoryController(ICategoryService categorieService)
        {
            _categorieService = categorieService;
        }
        // GET: Category
        public PartialViewResult List(int? categoryId)
        {
            return PartialView( new CategoryListViewModel{
                Categories=_categorieService.GetAll(),
                CurrentCategory=categoryId
            });
        }
    }
}