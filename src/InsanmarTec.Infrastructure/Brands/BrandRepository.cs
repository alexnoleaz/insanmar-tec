using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared.Datasources;

namespace InsanmarTec.Infrastructure.Brands
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IDatasource<Brand> _brandDatasource;

        public BrandRepository(IDatasource<Brand> brandDatasource) =>
            _brandDatasource = brandDatasource;

        public async Task<Brand> CreateAsync(Brand brand) =>
            await _brandDatasource.InsertAsync(brand);

        public async Task DisableAsync(int id)
        {
            var brandDb = await _brandDatasource.GetAsync(id);
            brandDb.IsActive = false;
            await _brandDatasource.UpdateAsync(brandDb);
        }

        public async Task<Brand> GetAsync(int id) => await _brandDatasource.GetAsync(id);

        public async Task<IEnumerable<Brand>> GetAllAsync() =>
            await _brandDatasource.GetAllListAsync();

        public async Task<Brand> UpdateAsync(Brand brand) =>
            await _brandDatasource.UpdateAsync(brand);
    }
}
