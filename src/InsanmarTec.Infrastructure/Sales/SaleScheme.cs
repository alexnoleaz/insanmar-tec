using InsanmarTec.Domain.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Sales
{
    public class SaleScheme : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder) =>
            builder.Property(s => s.Id).UseIdentityColumn(seed: 100000);
    }
}
