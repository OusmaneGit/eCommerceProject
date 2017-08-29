using eCommerceProject.Business.Abstract;
using eCommerceProject.Business.Concrete.Managers;
using eCommerceProject.DataAccess.Abstract;
using eCommerceProject.DataAccess.Concrete.EntityFramework;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eCommerceProject.MvcWebUI.DependencyResolver
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IProductService>().To<ProductManager>().InSingletonScope();
            _kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            _kernel.Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            _kernel.Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            _kernel.Bind<IUserService>().To<UserManager>().InSingletonScope();
            _kernel.Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
        }
        protected override IController GetControllerInstance(RequestContext requestContext ,Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}