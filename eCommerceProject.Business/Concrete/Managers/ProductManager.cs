using eCommerceProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceProject.Entities.ComplexTypes;
using eCommerceProject.Entities.Concrete;
using eCommerceProject.DataAccess.Abstract;
using eCommerceProject.Business.ValidationRules.FluentValidation;

namespace eCommerceProject.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            FluentValidatorTools.Validate(new ProductValidator(), product);
            ProductNameCheck(product);
            _productDal.Add(product);
        }

        private void ProductNameCheck(Product product)
        {
            bool isThereAnyProductNameWithSameName =
                _productDal.GetList(p => p.ProductName == product.ProductName).Any();
            if (isThereAnyProductNameWithSameName)
            {
                throw new Exception("There is already product with same name ");
            }
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll(ProductFilter productFilter)
        {
            int? categoryId = productFilter.CategoryId;
            if (categoryId != null)
            {
                return _productDal.GetList(
                    filter:product=>product.CategoryId==categoryId,
                    orderBy: o=>o.OrderBy(product=>product.Id),
                    page:productFilter.Page,
                    pageSize:productFilter.PageSize
                    );
            }
            else
            {
                return _productDal.GetList(
                   
                    orderBy: o => o.OrderBy(product => product.Id),
                    page: productFilter.Page,
                    pageSize: productFilter.PageSize
                    );
            }
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public List<Product> GetByProductName(string productName)
        {
            return _productDal.GetList(p => p.ProductName.Contains(productName));
        }

        public int GetProductsCountByCategory(int? categoryId)
        {
            return _productDal.GetProductsCountByCategory(categoryId);
        }

        public void Update(Product product)
        {
            FluentValidatorTools.Validate(new ProductValidator(), product);
            //ProductNameCheck(product);
            _productDal.Update(product);
        }
    }
}
