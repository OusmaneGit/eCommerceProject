using eCommerceProject.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceProject.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(t => t.ProductName).NotEmpty();
            RuleFor(t => t.CategoryId).NotEmpty();
            RuleFor(t => t.QuantityPerUnit).NotEmpty().When(t => t.CategoryId == 1);
            RuleFor(t => t.UnitPrice).GreaterThan(0);
            RuleFor(t => t.ProductName).Must(YourOwnRule);
        }

        private bool YourOwnRule(string arg)
        {
            return true;
        }
    }
}
