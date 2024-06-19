using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Infrastructure.Shared.Repositories
{
    public abstract class AsyncCrudRepository<TEntity>
        : AsyncCrudRepository<TEntity, int>,
            IAsyncCrudRepository<TEntity>
        where TEntity : class, IEntity<int>
    {
        public AsyncCrudRepository(IDatasource<TEntity> datasource)
            : base(datasource) { }
    }
}
