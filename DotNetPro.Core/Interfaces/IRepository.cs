using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.Core.Entities.Abstractions;

namespace DotNetPro.Core.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : IEntity
    {

        Task AddAsync(TEntity entity);
        Task AddRangeAsync(List<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(List<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(List<TEntity> entities);
        Task<TEntity> GetAsync(long id);
        Task<IQueryable<TEntity>> GetAllAsync();
        Task SaveChangesAsync();
    }
}
