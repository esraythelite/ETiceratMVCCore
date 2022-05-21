using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class Password:BaseEntity, IEntity
    {
        public string PasswordContent { get; set; } = default!;
        public DateTime PasswordDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
