using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Infrastructure.Shared.Repositories
{
    public abstract class AsyncCrudRepository<TEntity, TPrimaryKey>
        : IAsyncCrudRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly IDatasource<TEntity, TPrimaryKey> _datasource;

        public AsyncCrudRepository(IDatasource<TEntity, TPrimaryKey> datasource) =>
            _datasource = datasource;

        public async Task<TEntity> CreateAsync(TEntity entity) =>
            await _datasource.InsertAsync(entity);

        public async Task DeleteAsync(TPrimaryKey id) => await _datasource.DeleteAsync(id);

        public async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await _datasource.GetAllListAsync();

        public async Task<TEntity> GetAsync(TPrimaryKey id) => await _datasource.GetAsync(id);

        public async Task<TEntity> UpdateAsync(TEntity entity) =>
            await _datasource.UpdateAsync(entity);
    }
}
