using System.Linq.Expressions;
using InsanmarTec.Domain.Shared.Repositories;

namespace InsanmarTec.Domain.Auth.Users
{
    public interface IUserRepository : IAsyncCrudRepository<User>
    {
        Task<User> Get(Expression<Func<User, bool>> predicate);
        Task Deactivate(int id);
        Task Activate(int id);
        Task<User> ChangePassword(int id, string password);
    }
}
