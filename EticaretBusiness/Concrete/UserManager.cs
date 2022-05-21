using ETicaretBusiness.Abstract;
using ETicaretCore.DataAccess.EntityFramework;
using ETicaretDataAccessLayer.Abstract;
using ETicaretEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBusiness.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal userDal;
        public UserManager(IUserDal _userDal)
        {
            userDal = _userDal;
        }
        public void Add(User entity)
        {
            userDal.Add(entity);
        }

        public void Delete(User entity)
        {
            userDal.Delete(entity);
        }

        public User? Get(int? entityId)
        {
            return userDal.GetById(entityId);
        }

        public IEnumerable<User> GetAll()
        {
            return userDal.GetAll();
        }

        public void Update(User entity)
        {
            userDal.Update(entity);
        }
 

        public User GetByUserNameAndPassword(string UserName, string Password)
        {
         //   return userDal
        }
    }
}
