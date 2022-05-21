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
    public class ProductPropertyManager : IProductPropertyService
    {
        private IProductPropertyDal productPropertyDal;
        public ProductPropertyManager(IProductPropertyDal  _productPropertyDal)
        {
            productPropertyDal = _productPropertyDal;
        }
        public void Add(ProductProperty entity)
        {
            productPropertyDal.Add(entity);
        }

        public void Delete(ProductProperty entity)
        {
            productPropertyDal.Delete(entity);
        }

        public ProductProperty? Get(int? entityId)
        {
            return productPropertyDal.GetById(entityId);
        }

        public IEnumerable<ProductProperty> GetAll()
        {
            return productPropertyDal.GetAll();
        }

        public void Update(ProductProperty entity)
        {
            productPropertyDal.Update(entity);
        }
    }
}
