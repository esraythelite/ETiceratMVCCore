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
    public class ProductCategoryManager : IProductCategoryService
    {
        private IProductCategoryDal productCategoryDal;
        public ProductCategoryManager(IProductCategoryDal _productCategory)
        {
            productCategoryDal = _productCategory;
        }
        public void Add(ProductCategory entity)
        {
            productCategoryDal.Add(entity);
        }

        public void Delete(ProductCategory entity)
        {
            productCategoryDal.Delete(entity);  
        }

        public ProductCategory? Get(int? entityId)
        {
            return productCategoryDal.GetById(entityId);
       }

        public IEnumerable<ProductCategory> GetAll()
        {
            return productCategoryDal.GetAll();
        }

        public void Update(ProductCategory entity)
        {
            productCategoryDal.Update(entity);
        }
    }
}
