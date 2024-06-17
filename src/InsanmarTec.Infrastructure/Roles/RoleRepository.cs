using InsanmarTec.Domain.Roles;
using InsanmarTec.Domain.Shared.Datasources;

namespace InsanmarTec.Infrastructure.Roles
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IDatasource<Role> _roleDatasource;

        public RoleRepository(IDatasource<Role> roleDatasource) => _roleDatasource = roleDatasource;

        public async Task<Role> CreateAsync(Role role) => await _roleDatasource.InsertAsync(role);

        public async Task DeleteAsync(int id) => await _roleDatasource.DeleteAsync(id);

        public async Task<Role> GetAsync(int id) => await _roleDatasource.GetAsync(id);

        public async Task<IEnumerable<Role>> GetAllAsync() =>
            await _roleDatasource.GetAllListAsync();

        public async Task<Role> UpdateAsync(Role role) => await _roleDatasource.UpdateAsync(role);
    }
}
