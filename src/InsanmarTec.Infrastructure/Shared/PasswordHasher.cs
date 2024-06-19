using InsanmarTec.Domain.Shared;

namespace InsanmarTec.Infrastructure.Shared
{
    public class PasswordHasher : IPasswordHasher
    {
        public bool Compare(string hashedPassword, string plainPassword) =>
            BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);

        public string Hash(string plainPassword) => BCrypt.Net.BCrypt.HashPassword(plainPassword);
    }
}
