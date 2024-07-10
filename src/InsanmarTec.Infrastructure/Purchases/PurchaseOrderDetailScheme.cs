using InsanmarTec.Domain.Purchases.PurchaseOrders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Purchases
{
    public class PurchaseOrderDetailScheme : IEntityTypeConfiguration<PurchaseOrderDetail>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrderDetail> builder)
        {
            builder.Property(p => p.UnitPrice).HasColumnType("money");
        }
    }
}
