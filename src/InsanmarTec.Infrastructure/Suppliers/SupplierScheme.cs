using InsanmarTec.Domain.Suppliers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Suppliers
{
    public class SupplierScheme : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(SupplierConsts.MaxNameLength);
            builder.Property(s => s.Address).HasMaxLength(SupplierConsts.MaxAddressLength);
            builder.Property(s => s.Phone).HasMaxLength(SupplierConsts.MaxPhoneLength);
            builder.Property(s => s.Email).HasMaxLength(SupplierConsts.MaxEmailLength);
        }
    }
}
