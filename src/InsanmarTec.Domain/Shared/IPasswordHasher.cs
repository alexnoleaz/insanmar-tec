using InsanmarTec.Domain.Shared.Dependency;

namespace InsanmarTec.Domain.Shared
{
    public interface IPasswordHasher : ISingletonDependency
    {
        public string Hash(string plainPassword);
        public bool Compare(string hashedPassword, string plainPassword);
    }
}
