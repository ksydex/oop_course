using System;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;

namespace Repository.AbstractClasses
{
    public class RepositoryBase<TEntity> : IRepository<TEntity>
    where TEntity: class, IEntity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        
        public bool UseAsNoTracking { get; set; }

        public RepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
            => UseAsNoTracking ? _dbSet.AsNoTracking() : _dbSet;

        public async Task<TEntity> FindAsync(int? id)
            => await GetAll().FirstOrDefaultAsync(x => x.Id == id);

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            
            if (entity is IWithId x) x.Id = 0;
            
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            
            _dbSet.Attach(entity);
            
            return entity;
            
        }

        public async Task<TEntity> UpdateAsync(int id, TEntity entity)
        {
            if (id == 0) throw new ArgumentOutOfRangeException(nameof(id));
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task RemoveAsync(int id)
        {
            if (id == 0) throw new ArgumentOutOfRangeException(nameof(id));
            var entity = await FindAsync(id);

            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}