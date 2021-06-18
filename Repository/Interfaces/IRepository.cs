using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
namespace Repository.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class, IEntity
    {
        bool UseAsNoTracking { get; set; }
        IQueryable<TEntity> GetAll();
        
        Task<TEntity> FindAsync(int? id);

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(int id, TEntity entity);

        Task RemoveAsync(int id);
    }
}