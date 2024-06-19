using InsanmarTec.Domain.Auth.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Users
{
    public class UserScheme : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(UserConsts.MaxFirstNameLength);
            builder.Property(u => u.LastName).HasMaxLength(UserConsts.MaxLastNameLength);
            builder.Property(u => u.Username).HasMaxLength(UserConsts.MaxUsernameLength);
            builder.Property(u => u.Email).HasMaxLength(UserConsts.MaxEmailLength);
            builder.Property(u => u.Password).HasMaxLength(100);

            builder.HasIndex(u => u.Username).IsUnique();
            builder.HasIndex(u => u.Email).IsUnique();
        }
    }
}
