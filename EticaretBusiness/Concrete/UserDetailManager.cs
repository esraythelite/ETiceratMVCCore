using ETicaretBusiness.Abstract;
using ETicaretDataAccessLayer.Abstract;
using ETicaretEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBusiness.Concrete
{
    public class UserDetailManager : IUserdetailService
    {
        private IUserDetailDal userDetailDal;
        public UserDetailManager(IUserDetailDal _userDetailDal)
        {
            userDetailDal = _userDetailDal;
        }
        public void Add(UserDetail entity)
        {
            userDetailDal.Add(entity);
        }

        public void Delete(UserDetail entity)
        {
            userDetailDal.Delete(entity);
        }

        public UserDetail? Get(int? entityId)
        {
            return userDetailDal.GetById(entityId); 
        }

        public IEnumerable<UserDetail> GetAll()
        {
            return userDetailDal.GetAll();
        }

        public void Update(UserDetail entity)
        {
            userDetailDal.Update(entity);
        }
    }
}
