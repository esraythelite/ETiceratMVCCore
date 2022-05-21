﻿using ETicaretCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretCore.DataAccess.EntityFramework
{
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        IEnumerable<T> GetAll();
        T? GetById(int? id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
