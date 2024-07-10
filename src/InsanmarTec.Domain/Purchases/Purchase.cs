using InsanmarTec.Domain.Purchases.PurchaseOrders;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Purchases
{
    public class Purchase : FullAuditedEntity
    {
        public PurchaseStatus Status { get; set; }

        public int PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; } = null!;
    }
}
