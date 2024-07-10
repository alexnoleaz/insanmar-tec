using InsanmarTec.Domain.Shared.Entities.Auditing;
using InsanmarTec.Domain.Suppliers;

namespace InsanmarTec.Domain.Purchases.PurchaseOrders
{
    public class PurchaseOrder : FullAuditedEntity
    {
        public PurchaseOrderStatus Status { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } = null!;
        public HashSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        public PurchaseOrder() => PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
    }
}
