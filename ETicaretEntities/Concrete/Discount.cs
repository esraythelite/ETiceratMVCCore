using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class Discount:BaseEntity, IEntity
    {
        public Discount()
        {
            Products = new HashSet<Product>();
        }
        public double DiscountRate { get; set; }
        public DateTime DiscountDate { get; set; }
        public string DiscountDescription { get; set; } = default!;
        public ICollection<Product> Products { get; set; }
    }
}
