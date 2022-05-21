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
    public class ProductManager : IProductService
    {
        private IProductDal productDal;
        public ProductManager(IProductDal _productDal)
        {
            productDal = _productDal;
        }
        public void Add(Product entity)
        {
            productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            productDal.Delete(entity);
        }

        public Product? Get(int? entityId)
        {
            return productDal.GetById(entityId);    
        }

        public IEnumerable<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public void Update(Product entity)
        {
            productDal.Update(entity);
        }
    }
}
