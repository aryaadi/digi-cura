using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Avam.DigiCura.Data.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> FetchAll();
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T FindById<TInput>(TInput id);
        bool Save(T entity);
        bool Save(IEnumerable<T> entities);
        bool Delete(T entity);
    }
}
