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
    public class OrderManager : IOrderService
    {
        private IOrderDal orderDal;
        public OrderManager(IOrderDal _orderDal)
        {
            orderDal = _orderDal;
        }

        public void Add(Order entity)
        {
            orderDal.Add(entity);  
        }

        public void Delete(Order entity)
        {
            orderDal.Delete(entity);
        }

        public Order? Get(int? entityId)
        {
            return orderDal.GetById(entityId);
        }

        public IEnumerable<Order> GetAll()
        {
            return orderDal.GetAll();
        }

        public void Update(Order entity)
        {
            orderDal.Update(entity);
        }
    }
}
