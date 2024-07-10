using InsanmarTec.Domain.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Sales
{
    public class SaleDetailScheme : IEntityTypeConfiguration<SaleDetail>
    {
        public void Configure(EntityTypeBuilder<SaleDetail> builder) =>
            builder.Property(s => s.UnitPrice).HasColumnType("money");
    }
}
