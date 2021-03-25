using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Tables { get; }

        #region Synchronize
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        T Get(object id);
        #endregion

        #region Asynchronous
        Task AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task UpdateAsync(T entity);

        Task<T> GetAsync(object id);

        #endregion
    }

}
