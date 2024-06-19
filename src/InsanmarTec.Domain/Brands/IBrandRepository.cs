using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Domain.Brands
{
    public interface IBrandRepository : IAsyncCrudRepository<Brand>
    {
        Task Deactivate(int id);
        Task Activate(int id);
    }
}
