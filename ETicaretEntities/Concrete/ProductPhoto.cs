using ETicaretCore.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class ProductPhoto:BaseEntity, IEntity
    {
        public string ProductImagePath { get; set; } = default!;
        public IFormFile ProdudctImage { get; set; } = default!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = default!;
    }
}
