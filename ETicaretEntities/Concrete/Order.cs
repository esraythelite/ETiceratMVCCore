using ETicaretCore.Entities;
using ETicaretEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class Order:BaseEntity, IEntity
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OptimumOrderDeliveryTime { get; set; }
        public OrderState OrderState { get; set; } 
        public int UserId { get; set; }
        public User User { get; set; } = default!;
        public int PaymentId { get; set; }
        public Payment Payment { get; set; } = default!;
        public ICollection<Product> Products { get; set; }
        public int CargoCompanyId { get; set; }
        public CargoCompany CargoCompany { get; set; } = default!;
    }
}
