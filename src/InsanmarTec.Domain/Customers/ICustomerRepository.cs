using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Domain.Customers
{
    public interface ICustomerRepository : IAsyncCrudRepository<Customer>
    {
        Task Deactivate(int id);
        Task Activate(int id);
    }
}
