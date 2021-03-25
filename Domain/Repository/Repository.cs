using Domain.Entities.Common;
using Domain.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbContext dbContext;
        private DbSet<T> entities;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<T> Tables => Entities.AsQueryable<T>();

        private DbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = dbContext.Set<T>();
                }
                return entities;
            }

        }
        #region Synchronize
        public virtual void Add(T entity) => Entities.Add(entity);

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Async
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        #endregion
    
    }
}
