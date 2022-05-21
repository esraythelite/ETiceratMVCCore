using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class Product:BaseEntity, IEntity
    {
        public Product()
        {
            ProductPhotos = new HashSet<ProductPhoto>();
            Commands = new HashSet<Command>();
            Orders = new HashSet<Order>();
        }
        public string ProductName { get; set; } = default!;
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = default!;
        public int ProductPropertyId { get; set; }
        public ProductProperty ProductProperty { get; set; } = default!;
        public int DiscountId { get; set; }
        public Discount Discount { get; set; } = default!;
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = default!;
        public ICollection<ProductPhoto> ProductPhotos { get; set; } 
        public ICollection<Command> Commands { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
