using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Sita.ParcelDelivery.Domain.Interface.Repository.Base
{
    public interface ISqlBaseRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        TEntity Get(long id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
