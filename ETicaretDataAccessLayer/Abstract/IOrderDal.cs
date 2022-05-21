using ETicaretCore.DataAccess.EntityFramework;
using ETicaretEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretDataAccessLayer.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
    }
}
