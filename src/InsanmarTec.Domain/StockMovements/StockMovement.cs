using InsanmarTec.Domain.Products;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.StockMovements
{
    public class StockMovement : AuditedEntity
    {
        public int QuantityChange { get; set; }
        public TransactionType TransactionType { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
