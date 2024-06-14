using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Domain.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Shared.Persistence.Datasources
{
    public class Datasource<TEntity> : Datasource<TEntity, int>, IDatasource<TEntity>
        where TEntity : class, IEntity<int>
    {
        public Datasource(InsanmarTecDbContext context)
            : base(context) { }
    }
}
