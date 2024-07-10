using System.Linq.Expressions;
using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Domain.Suppliers
{
    public interface ISuppliersRepository : IAsyncCrudRepository<Supplier>
    {
        Task Deactivate(int id);
        Task Activate(int id);
        Task<Supplier> Get(Expression<Func<Supplier, bool>> predicate);
    }
}
