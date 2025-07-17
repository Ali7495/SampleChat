using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity, CancellationToken cancellationToken);
        void Add(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
        void AddRange(IEnumerable<TEntity> entities);

        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken CancellationToken);
        IEnumerable<TEntity> GetAll();
        Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        TEntity GetById(Guid id);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken CancellationToken);

        Task UppdateAsync(TEntity entity);
        void Update(TEntity entity);
        Task UpdateRangeAsync(IEnumerable<TEntity> entities);
        void UpdateRange(IEnumerable<TEntity?> entities);

        Task DeleteAsync(TEntity entity);
        void Delete(TEntity entity);
        Task DeleteRangeAsync(IEnumerable<TEntity> entities);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
