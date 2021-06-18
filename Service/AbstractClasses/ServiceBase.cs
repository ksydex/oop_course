using System;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Service.Interfaces.Common;

namespace Service.AbstractClasses
{
    public abstract class ServiceBase<T, TFilter> : IService<T, TFilter>
        where T : class, IEntity
        where TFilter: class
    {
        protected readonly DbContext DbContext;
        public IRepository<T> Repository { get; set; }
        
        public virtual bool ThrowExceptions { get; set; } = false;

        public ServiceBase(IRepository<T> repository, DbContext dbContext)
        {
            Repository = repository;
            DbContext = dbContext;
        }

        public virtual T SecureCreate(T entity) => entity;
        public virtual T SecureUpdate(T cur, T upd) => upd;
        public virtual T SecureRemove(T entity) => entity;
        

        public virtual IQueryable<T> GetAll(TFilter filter = null)
            => filter == null ? Repository.GetAll() : QueryableFiltered(Repository.GetAll(), filter);
        
        public virtual IQueryable<T> QueryableFiltered(IQueryable<T> q, TFilter filter)
            => q;

        public Task<T> FindAsync(int id)
            => GetAll().FirstOrDefaultAsync(x => x.Id == id);

        
        
        public virtual async Task<T> CreateAsync(T entity)
        {
            entity = SecureCreate(entity);
            if (entity == null) throw new UnauthorizedAccessException();
            
            try
            {
                var result = await Repository.CreateAsync(entity);
                return result;
            }
            catch (Exception)
            {
                if (ThrowExceptions) throw;
                return null;
            }
        }
        
        public virtual async Task<T> UpdateAsync(int id, T entity)
        {
            var e = await FindAsync(id);
            if (e == null || entity == null) return null;
            
            entity = SecureUpdate(e, entity);
            if (entity == null) throw new UnauthorizedAccessException();
            
            try
            {
                DbContext.Entry(e).State = EntityState.Detached;
                await Repository.UpdateAsync(id, entity);
                return entity;
            }
            catch (Exception)
            {
                if (ThrowExceptions) throw;
                return null;
            }
        }
        
                

        public virtual async Task<bool> RemoveAsync(int id)
        {
            var e = await FindAsync(id);
            if (e == null) return false;

            
            if (SecureRemove(e) == null) throw new UnauthorizedAccessException();
            
            try
            {
                await Repository.RemoveAsync(e.Id);
                return true;
            }
            catch (Exception)
            {
                if (ThrowExceptions) throw;
                return false;
            }
        }
    }
}