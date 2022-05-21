using ETicaretCore.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class ProductCategory:BaseEntity, IEntity
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        public string CategoryName { get; set; } = default!;
        public string CategoryDescription { get; set; } = default!;
        public string CategoryPhotoPath { get; set; } = default!;
        public IFormFile CategoryPhoto { get; set; } = default!;
        public ICollection<Product> Products { get; set; }
    }
}
