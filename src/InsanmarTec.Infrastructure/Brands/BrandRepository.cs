using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Infrastructure.Shared.Repositories;

namespace InsanmarTec.Infrastructure.Brands
{
    public class BrandRepository : AsyncCrudRepository<Brand>, IBrandRepository
    {
        public BrandRepository(IDatasource<Brand> brandDatasource)
            : base(brandDatasource) { }

        public async Task Activate(int id) => await ActivateOrDeactivate(id, true);

        public async Task Deactivate(int id) => await ActivateOrDeactivate(id, false);

        private async Task ActivateOrDeactivate(int id, bool isActive)
        {
            var brandDb = await GetAsync(id);
            brandDb.IsActive = isActive;
            await UpdateAsync(brandDb);
        }
    }
}
