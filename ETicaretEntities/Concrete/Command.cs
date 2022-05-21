using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class Command:BaseEntity, IEntity
    {
        public string CommandHeading { get; set; } = default!;
        public string CommandContent { get; set; } = default!;
        public DateTime CommandDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = default!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = default!;
    }
}
