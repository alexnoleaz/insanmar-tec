using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Domain.Roles
{
    public interface IRoleRepository : ITransientDependency
    {
        Task<Role> CreateAsync(Role role);
        Task DeleteAsync(int id);
        Task<Role> GetAsync(int id);
        Task<IEnumerable<Role>> GetAllAsync();
        Task<Role> UpdateAsync(Role role);
    }
}
