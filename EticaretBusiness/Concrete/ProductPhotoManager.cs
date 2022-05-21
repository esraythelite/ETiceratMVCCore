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
    public class ProductPhotoManager : IProductPhotoService
    {
        private IProductPhotoDal productPhotoDal;
        public ProductPhotoManager(IProductPhotoDal _productPhotoDal)
        {
            productPhotoDal = _productPhotoDal;
        }
        public void Add(ProductPhoto entity)
        {
            productPhotoDal.Add(entity);
        }

        public void Delete(ProductPhoto entity)
        {
            productPhotoDal.Delete(entity);
        }

        public ProductPhoto? Get(int? entityId)
        {
            return productPhotoDal.GetById(entityId);
        }

        public IEnumerable<ProductPhoto> GetAll()
        {
            return productPhotoDal.GetAll();    
        }

        public void Update(ProductPhoto entity)
        {
            productPhotoDal.Update(entity);
        }
    }
}
