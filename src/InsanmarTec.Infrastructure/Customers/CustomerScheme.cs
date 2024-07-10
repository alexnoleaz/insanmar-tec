using InsanmarTec.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Customers
{
    public class CustomerScheme : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.FirstName).HasMaxLength(CustomerConsts.MaxFirstNameLength);
            builder.Property(c => c.LastName).HasMaxLength(CustomerConsts.MaxLastNameLength);
            builder.Property(c => c.Address).HasMaxLength(CustomerConsts.MaxAddressLength);
            builder.Property(c => c.Phone).HasMaxLength(CustomerConsts.MaxPhoneLength);
            builder.Property(c => c.Email).HasMaxLength(CustomerConsts.MaxEmailLength);
            builder.Property(c => c.Dni).HasMaxLength(CustomerConsts.MaxDniLength);

            builder.HasIndex(c => c.Dni).IsUnique();
        }
    }
}
