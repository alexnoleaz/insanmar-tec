using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Domain.Shared.Repositories
{
    public interface IAsyncCrudRepository<TEntity> : IAsyncCrudRepository<TEntity, int>
        where TEntity : class, IEntity<int> { }
}
