﻿using InsanmarTec.Domain.Products;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Sales
{
    public class SaleDetail : AuditedEntity
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public int SaleId { get; set; }
        public Sale Sale { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
