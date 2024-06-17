using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Domain.Brands
{
    public interface IBrandRepository : ITransientDependency
    {
        Task<Brand> CreateAsync(Brand brand);
        Task DisableAsync(int id);
        Task<Brand> GetAsync(int id);
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand> UpdateAsync(Brand brand);
    }
}
