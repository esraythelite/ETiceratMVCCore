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
    public class BrandManager : IBrandService
    {
        private IBrandDal brandDal;
        public BrandManager(IBrandDal _brandDal)
        {
            brandDal = _brandDal;
        }

        public void Add(Brand entity)
        {
            brandDal.Add(entity);
        }

        public void Delete(Brand entity)
        {
            brandDal.Delete(entity);
        }

        public Brand? Get(int? entityId)
        {
            return brandDal.GetById(entityId);
        }

        public IEnumerable<Brand> GetAll()
        {
            return brandDal.GetAll();
        }

        public void Update(Brand entity)
        {
            brandDal.Update(entity);
        }
    }
}
