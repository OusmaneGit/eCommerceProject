using eCommerceProject.Business.ValidationRules.FluentValidation;
using eCommerceProject.Entities.Concrete;

using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceProject.MvcWebUI.DependencyResolver
{
    /*public class FluentValidatorFactory : ValidatorFactoryBase
    {
        private IKernel _kernel;
        public FluentValidatorFactory()
        {
            _kernel = new StandardKernel();
            //_kernel.Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
        public override IValidator CreateInstance(Type validatorType)
        {
            return (validatorType == null) ? null : (IValidator)_kernel.TryGet(validatorType);
        }
    }*/
}