using InsanmarTec.Domain.PaymentMethods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.PaymentMethods
{
    public class PaymentMethodScheme : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(PaymentMethodConsts.MaxNameLength);
        }
    }
}
