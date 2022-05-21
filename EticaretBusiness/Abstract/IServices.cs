using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretBusiness.Abstract
{
    public interface IServices<T> where T : class, IEntity, new()
    {
        IEnumerable<T> GetAll();
        T? Get(int? entityId);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
