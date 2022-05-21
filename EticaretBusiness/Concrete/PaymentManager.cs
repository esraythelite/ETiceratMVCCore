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
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal paymentDal;
        public PaymentManager(IPaymentDal _paymentDal)
        {
            paymentDal = _paymentDal;
        }

        public void Add(Payment entity)
        {
            paymentDal.Add(entity);
        }

        public void Delete(Payment entity)
        {
            paymentDal.Delete(entity);
        }

        public Payment? Get(int? entityId)
        {
            return paymentDal.GetById(entityId);
        }

        public IEnumerable<Payment> GetAll()
        {
            return paymentDal.GetAll();
        }

        public void Update(Payment entity)
        {
            paymentDal.Update(entity);  
        }
    }
}
