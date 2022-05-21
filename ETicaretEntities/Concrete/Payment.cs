using ETicaretCore.Entities;
using ETicaretEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class Payment:BaseEntity, IEntity
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }
        public DateTime PaymentDate { get; set; }
        public PaymentOption PaymentOption { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
