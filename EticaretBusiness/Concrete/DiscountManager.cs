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
    public class DiscountManager : IDiscountService
    {
        private IDiscountDal discountDal;
        public DiscountManager(IDiscountDal _discountDal)
        {
            discountDal = _discountDal;
        }

        public void Add(Discount entity)
        {
            discountDal.Add(entity);
        }

        public void Delete(Discount entity)
        {
            discountDal.Delete(entity);
        }

        public Discount? Get(int? entityId)
        {
            return discountDal.GetById(entityId);
        }

        public IEnumerable<Discount> GetAll()
        {
            return discountDal.GetAll();
        }

        public void Update(Discount entity)
        {
            discountDal.Update(entity);
        }
    }
}
