using KPIdomain.Common;
using System.Linq.Expressions;

namespace KPIinfrastructure.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> predicate);

        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();

        Task<int> AddIntAsync(TEntity entity);

        IEnumerable<TEntity> GetAllAsEnumurable();

        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> DeleteAsync(TEntity entity);
    }
}
