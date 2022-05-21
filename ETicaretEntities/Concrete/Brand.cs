using ETicaretCore.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETicaretEntities.Concrete
{
    public class Brand:BaseEntity,IEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();  
        }
        public string BrandName { get; set; } = default!;
        public string BrandDescription { get; set; } = default!;
        public string BrandPhone { get; set; } = default!;
        public string BrandAdress { get; set; } = default!;
        public string BrandPhotoPath { get; set; } = default!;
        public IFormFile BrandPhoto { get; set; } = default!;
        public ICollection<Product> Products { get; set; }
    }
}
