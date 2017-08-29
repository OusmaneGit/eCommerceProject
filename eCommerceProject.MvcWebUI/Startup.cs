using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCommerceProject.MvcWebUI.Startup))]
namespace eCommerceProject.MvcWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
        }
    }
}
