using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Avam.DigiCura.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Private Fields
        protected DbContext _dbContext;
        #endregion

        #region ctors
        protected Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region IRepository<T>

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FetchAll()
        {
            return _dbContext.Set<T>();
        }

        public T FindById<TInput>(TInput id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public bool Save(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public bool Save(T entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; 
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
