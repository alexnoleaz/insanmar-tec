using InsanmarTec.Domain.Auth.Roles;
using InsanmarTec.Domain.Auth.Users;
using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public class InitialSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher();
            var role = new Role
            {
                Id = 1,
                Name = "Administrador",
                Description = "Role con acceso al programa completo",
            };

            modelBuilder.Entity<Role>().HasData(role);

            var user = new User
            {
                Id = 1,
                FirstName = "Administrador",
                LastName = "Administrador",
                Username = "admin",
                Email = "administrador@gmail.com",
                Password = passwordHasher.Hash("admin"),
            };
            modelBuilder.Entity<User>().HasData(user);

            // Many to many
            var roleUserTable = "RoleUser";
            var userProperty = "UsersId";
            var roleProperty = "RolesId";

            modelBuilder
                .Entity(roleUserTable)
                .HasData(
                    new Dictionary<string, object>
                    {
                        [userProperty] = user.Id,
                        [roleProperty] = role.Id
                    }
                );
        }
    }
}
