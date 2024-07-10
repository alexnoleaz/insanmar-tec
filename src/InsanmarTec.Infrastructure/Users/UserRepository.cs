using System.Linq.Expressions;
using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Shared.Datasources;
using InsanmarTec.Domain.Shared.Entities;
using InsanmarTec.Infrastructure.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Users
{
    public class UserRepository : AsyncCrudRepository<User>, IUserRepository
    {
        private readonly IDatasource<User> _userRepository;

        public UserRepository(IDatasource<User> userRepository)
            : base(userRepository) => _userRepository = userRepository;

        public async Task<User> Get(Expression<Func<User, bool>> predicate)
        {
            var query = await _userRepository.GetAllReadonlyIncludingAsync(u => u.Roles);
            return await query.FirstOrDefaultAsync(predicate)
                ?? throw new EntityNotFoundException("User not found.");
        }

        public async Task<User> ChangePassword(int id, string password)
        {
            var userDb = await GetAsync(id);
            userDb.Password = password;
            return await UpdateAsync(userDb);
        }

        public async Task Activate(int id) => await ActivateOrDeactivate(id, true);

        public async Task Deactivate(int id) => await ActivateOrDeactivate(id, false);

        private async Task ActivateOrDeactivate(int id, bool isActive)
        {
            var userDb = await GetAsync(id);
            userDb.IsActive = isActive;
            await UpdateAsync(userDb);
        }
    }
}
