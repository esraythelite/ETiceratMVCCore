using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class CargoCompany:BaseEntity, IEntity
    {
        public CargoCompany()
        {
            Orders = new HashSet<Order>();  
        }
        public string CompanyName { get; set; } = default!;
        public string CompanyDescription { get; set; } = default!;
        public string CompanyPhone { get; set; } = default!;
        public string CompanyAdress { get; set; } = default!;
        public ICollection<Order> Orders { get; set; }

    }
}
