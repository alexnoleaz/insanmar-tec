using InsanmarTec.Domain.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Roles
{
    public class RoleScheme : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(r => r.Name).HasMaxLength(RoleConsts.MaxNameLength);
            builder.Property(r => r.Description).HasMaxLength(RoleConsts.MaxDescriptionLength);

            builder.HasIndex(r => r.Name).IsUnique();
        }
    }
}
