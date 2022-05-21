using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class ProductProperty:BaseEntity, IEntity
    {
        public Color ProductColor { get; set; }
        public decimal ProductMass { get; set; }
        public decimal ProductSize { get; set; }
        public double ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductDescription { get; set; } = default!;
        public Product Product { get; set; } = default!;
    }
}
