﻿using InsanmarTec.Domain.Products;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Purchases.PurchaseOrders
{
    public class PurchaseOrderDetail : AuditedEntity
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public int PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
