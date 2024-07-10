using InsanmarTec.Domain.Models;
using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Infrastructure.Shared.Repositories;

namespace InsanmarTec.Infrastructure.Models
{
    public class ModelRepository : AsyncCrudRepository<Model>, IModelRepository
    {
        public ModelRepository(IDatasource<Model> modelDatasource) : base(modelDatasource) { }

        public async Task Activate(int id) => await ActivateOrDeactivate(id, true);

        public async Task Deactivate(int id) => await ActivateOrDeactivate(id, false);

        private async Task ActivateOrDeactivate(int id, bool isActive)
        {
            var modelDb = await GetAsync(id);
            modelDb.IsActive = isActive;
            await UpdateAsync(modelDb);
        }
    }
}
