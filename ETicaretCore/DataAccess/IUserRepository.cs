using ETicaretCore.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETicaretCore.DataAccess
{
    public class IUserRepository
    {
        public interface IUserRepository : IEntityRepository<User>
        {
            User GetByUserNameAndPasswordContent(string UserName, string Password);
        }
    }
}
