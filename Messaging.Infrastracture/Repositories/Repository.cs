using Messaging.Domain.Repositories;
using Messaging.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Infrastracture.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly UserManagementDbContext _dbContext;
        internal DbSet<TEntity> Entities;

        public Repository(UserManagementDbContext userManagementDbContext)
        {
            _dbContext = userManagementDbContext;
            Entities = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await Entities.AddAsync(entity, cancellationToken);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Entities.AddRange(entities);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        {
            await Entities.AddRangeAsync(entities, cancellationToken);
        }

        public void Delete(TEntity entity)
        {
            Entities.Remove(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                Entities.Remove(entity);
            });
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            Entities.RemoveRange(entities);
        }

        public async Task DeleteRangeAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() =>
            {
                Entities.RemoveRange(entities);
            });
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken CancellationToken)
        {
            return await Entities.AsNoTracking().Where(predicate).ToListAsync(CancellationToken);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities.AsNoTracking().ToList();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken CancellationToken)
        {
            return await Entities.AsNoTracking().ToListAsync(CancellationToken);
        }

        public TEntity GetById(Guid id)
        {
            return Entities.Find(id);
        }

        public async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await Entities.FindAsync(id,cancellationToken);
        }

        public void Update(TEntity entity)
        {
            Entities.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity?> entities)
        {
            Entities.UpdateRange(entities);
        }

        public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            Entities.UpdateRange(entities);
            await Task.CompletedTask;
        }

        public async Task UppdateAsync(TEntity entity)
        {
            Entities.UpdateRange(entity);
            await Task.CompletedTask;
        }
    }
}
