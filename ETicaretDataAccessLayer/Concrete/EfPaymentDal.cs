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
    public class EfPaymentDal : EFEntityRepositoryBase<Payment, ApplicationDbContext>, IPaymentDal
    {
    }
}
