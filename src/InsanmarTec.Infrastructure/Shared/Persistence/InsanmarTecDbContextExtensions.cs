using System.Linq.Expressions;
using InsanmarTec.Domain.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public static class InsanmarTecDbContextExtensions
    {
        public static ModelBuilder ApplyFilterByIsDeleted(this ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
                {
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var body = Expression.Not(Expression.Property(parameter, "IsDeleted"));
                    var lambda = Expression.Lambda(body, parameter);

                    modelBuilder.Entity(entityType.ClrType).HasQueryFilter(lambda);
                }
            }

            return modelBuilder;
        }
    }
}
