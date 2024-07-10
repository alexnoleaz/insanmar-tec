using System.Linq.Expressions;
using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Domain.Brands
{
    public interface IBrandRepository : IAsyncCrudRepository<Brand>
    {
        Task Deactivate(int id);
        Task Activate(int id);
        Task<Brand> Get(Expression<Func<Brand, bool>> predicate);
    }
}
