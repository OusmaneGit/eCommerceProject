using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceProject.Business.Abstract;
using eCommerceProject.Business.Concrete.Managers;
using eCommerceProject.Entities.ComplexTypes;
using eCommerceProject.MvcWebUI.Models;
using eCommerceProject.DataAccess.Concrete.EntityFramework;
using eCommerceProject.Entities.Concrete;

namespace eCommerceProject.MvcWebUI.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private IProductService _productService;//=new ProductManager(new EfProductDal());
        private ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public int PageSize = 10;
        // GET: Product
        [AllowAnonymous]
        public ActionResult Index(int? categoryId, int page=1)
        {
            int productCount = _productService.GetProductsCountByCategory(categoryId);
            var products = _productService.GetAll(new ProductFilter
            {
                CategoryId = categoryId,
                Page = page,
                PageSize = PageSize
            });
            return View(new ProductListViewModel
            {
                Products = products
                    ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    Currentcategory = categoryId,
                    TotalPageCount = (int)Math.Ceiling((decimal)productCount / PageSize),
                    BaseUrl =String.Format("Product/Index/?categoryId={0}&page=",categoryId)
                }
            });
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View( new ProductAddViewModel
            {
                Product = new Product { UnitPrice = 50 },
                Categories=_categoryService.GetAll().Select(item=> new SelectListItem()
                { Text =item.CategoryName,Value=item.Id.ToString()}).ToList()
            });
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            _productService.Add(product);
            TempData.Add("Message", "The product was added");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(new ProductAddViewModel
            {
                Product = _productService.GetById(id),
                Categories = _categoryService.GetAll().Select(item => new SelectListItem()
                { Text = item.CategoryName, Value = item.Id.ToString() }).ToList()
            });
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            _productService.Update(product);
            TempData.Add("Message", "The product was udpaded");
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            _productService.Delete(new Product { Id = id });
            TempData.Add("Message", "The product was deleted");
            return RedirectToAction("Index");
        }
    }
}