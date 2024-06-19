using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Domain.Shared.Repositories
{
    public interface IAsyncCrudRepository<TEntity, TPrimaryKey> : IAsyncCrudRepository
        where TEntity : class, IEntity<TPrimaryKey>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task DeleteAsync(TPrimaryKey id);
        Task<TEntity> GetAsync(TPrimaryKey id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
