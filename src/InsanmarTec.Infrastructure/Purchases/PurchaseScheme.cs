using InsanmarTec.Domain.Purchases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Purchases
{
    public class PurchaseScheme : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder) =>
            builder.Property(p => p.Id).UseIdentityColumn(seed: 100000);
    }
}
