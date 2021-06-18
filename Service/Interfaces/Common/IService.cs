using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Repository.Interfaces;

namespace Service.Interfaces.Common
{
    public interface IService<TEntity, in TFilter>
        where TEntity : class, IEntity
        where TFilter : class
    {
        IRepository<TEntity> Repository { get; set; }
        bool ThrowExceptions { get; set; }

        IQueryable<TEntity> GetAll(TFilter filter = null);
        Task<TEntity> FindAsync(int id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<bool> RemoveAsync(int id);
        Task<TEntity> UpdateAsync(int id, TEntity entity);

        IQueryable<TEntity> QueryableFiltered(IQueryable<TEntity> q, TFilter filter);
    }
}