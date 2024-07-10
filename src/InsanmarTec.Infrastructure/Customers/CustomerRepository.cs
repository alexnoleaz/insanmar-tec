using InsanmarTec.Domain.Customers;
using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Infrastructure.Shared.Repositories;

namespace InsanmarTec.Infrastructure.Customers
{
    public class CustomerRepository : AsyncCrudRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDatasource<Customer> customerDatasource)
            : base(customerDatasource) { }

        public async Task Activate(int id) => await ActivateOrDeactivate(id, true);

        public async Task Deactivate(int id) => await ActivateOrDeactivate(id, false);

        private async Task ActivateOrDeactivate(int id, bool isActive)
        {
            var customerDb = await GetAsync(id);
            customerDb.IsActive = isActive;
            await UpdateAsync(customerDb);
        }
    }
}
