using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Domain.Auth.Users
{
    public interface IUserRepository : IAsyncCrudRepository<User>
    {
        Task<User> Get(string username);
        Task Deactivate(int id);
        Task Activate(int id);
        Task<User> ChangePassword(int id, string password);
    }
}
