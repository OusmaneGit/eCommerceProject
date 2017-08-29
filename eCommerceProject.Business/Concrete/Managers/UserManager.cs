using eCommerceProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceProject.Entities.Concrete;
using eCommerceProject.DataAccess.Abstract;

namespace eCommerceProject.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetByUserNameAndPassword(User user)
        {
            return _userDal.Get(u => u.UserName == user.UserName && u.Password == user.Password);
        }
    }
}
