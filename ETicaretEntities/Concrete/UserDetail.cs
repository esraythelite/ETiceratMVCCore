using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class UserDetail:BaseEntity, IEntity
    {
        public string UserFirstName { get; set; } = default!;
        public string UserLastName { get; set; } = default!;
        public DateTime UserBirthDate { get; set; }
        public byte UserGender { get; set; }
        public string UserPhone { get; set; } = default!;
        public string UserAddress { get; set; } = default!;
        public User User { get; set; } = default!;
    }
}
