using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repositories.Abstract
{
    public interface IGenericService<T> where T:class,new()
    {
        List<T> GetByDefault(Expression<Func<T, bool>> filter = null);
        List<T> GetActive();
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(Guid id);
    }
}
