using InsanmarTec.Domain.Shared.Entities;

namespace InsanmarTec.Domain.Shared.Datasources
{
    /// <summary>
    /// A shortcut of <see cref="IDatasource{TEntity, TPrimaryKey}"/> for most used primary key type (<see cref="int"/>).
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public interface IDatasource<TEntity> : IDatasource<TEntity, int> where TEntity : class, IEntity<int> { }
}
