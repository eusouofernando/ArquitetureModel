using Microsoft.EntityFrameworkCore;
using Sita.ParcelDelivery.Data.Context;
using Sita.ParcelDelivery.Domain.Interface.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Sita.ParcelDelivery.Data.Repository.Base
{
    public class SqlBaseRepository<TEntity> : ISqlBaseRepository<TEntity> where TEntity : class
    {

        protected SqlServerDbCotext _dbContext { get; set; }
        internal DbSet<TEntity> dbSet;

        public SqlBaseRepository(SqlServerDbCotext dbContext)
        {
            _dbContext = dbContext;
            this.dbSet = _dbContext.Set<TEntity>();
        }

        public TEntity Get(long id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public TEntity Get(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            try
            {
                _dbContext.Set<TEntity>().Add(entity);
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro tente novamente");
            }

        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
        }


    }
}
