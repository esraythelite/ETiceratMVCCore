using ETicaretCore.DataAccess.EntityFramework;
using ETicaretDataAccessLayer.Abstract;
using ETicaretEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretDataAccessLayer.Concrete
{
    public class EfProductDal : EFEntityRepositoryBase<Product, ApplicationDbContext>, IProductDal
    {
    }
}
