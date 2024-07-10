using InsanmarTec.Domain.Purchases.PurchaseOrders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Purchases
{
    public class PurchaseOrderScheme : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> builder) =>
            builder.Property(p => p.Id).UseIdentityColumn(seed: 100000);
    }
}
