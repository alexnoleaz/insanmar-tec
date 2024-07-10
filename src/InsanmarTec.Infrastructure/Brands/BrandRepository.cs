using System.Linq.Expressions;
using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Infrastructure.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Brands
{
    public class BrandRepository : AsyncCrudRepository<Brand>, IBrandRepository
    {
        private readonly IDatasource<Brand> _brandRepository;

        public BrandRepository(IDatasource<Brand> brandDatasource)
            : base(brandDatasource) => _brandRepository = brandDatasource;

        public async Task Activate(int id) => await ActivateOrDeactivate(id, true);

        public async Task Deactivate(int id) => await ActivateOrDeactivate(id, false);

        public async Task<Brand> Get(Expression<Func<Brand, bool>> predicate)
        {
            return await _brandRepository.FirstOrDefaultAsync(predicate)
                ?? throw new EntityNotFoundException("Brand not found.");
        }

        private async Task ActivateOrDeactivate(int id, bool isActive)
        {
            var brandDb = await GetAsync(id);
            brandDb.IsActive = isActive;
            await UpdateAsync(brandDb);
        }
    }
}
