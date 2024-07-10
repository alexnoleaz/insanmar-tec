using InsanmarTec.Domain.Customers;
using InsanmarTec.Domain.PaymentMethods;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Sales
{
    public class Sale : FullAuditedEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = null!;
        public HashSet<SaleDetail> SaleDetails { get; set; }

        public Sale() => SaleDetails = new HashSet<SaleDetail>();
    }
}
