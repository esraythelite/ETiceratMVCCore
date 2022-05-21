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
    public class PasswordManager : IPasswordService
    {
        private IPasswordDal passwordDal;
        public PasswordManager(IPasswordDal _passwordDal)
        {
            passwordDal = _passwordDal;
        }

        public void Add(Password entity)
        {
            passwordDal.Add(entity);
        }

        public void Delete(Password entity)
        {
            passwordDal.Delete(entity); 
        }

        public Password? Get(int? entityId)
        {
            return passwordDal.GetById(entityId);
        }

        public IEnumerable<Password> GetAll()
        {
            return passwordDal.GetAll();
        }

        public void Update(Password entity)
        {
            passwordDal.Update(entity);
        }
    }
}
