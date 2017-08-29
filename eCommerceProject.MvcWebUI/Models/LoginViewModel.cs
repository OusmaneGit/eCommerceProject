using eCommerceProject.Entities.Concrete;

namespace eCommerceProject.MvcWebUI.Models
{
    public class LoginViewModel
    {
        public User User { get; set; }
        public bool RememberMe { get; set; }
    }
}