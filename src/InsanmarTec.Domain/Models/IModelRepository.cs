using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Domain.Models
{
    public interface IModelRepository : IAsyncCrudRepository<Model>
    {
        Task Deactivate(int id);
        Task Activate(int id);
    }
}
