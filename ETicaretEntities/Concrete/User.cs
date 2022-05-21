using ETicaretCore.Entities;
using ETicaretEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretEntities.Concrete
{
    public class User:BaseEntity, IEntity
    {
        public User()
        {
            Passwords = new HashSet<Password>();
            Orders = new HashSet<Order>();
            Commands = new HashSet<Command>();
        }
        public string UserName { get; set; } = default!;
        public string UserEMail { get; set; } = default!;
        public UserRole UserRole { get; set; }
        public int UserDetailId { get; set; }
        public UserDetail UserDetail { get; set; } = default!;
        public ICollection<Password> Passwords { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Command> Commands { get; set; }
    }
}
