using InsanmarTec.Domain.Sales;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Notes.ExitNotes
{
    public class ExitNote : FullAuditedEntity
    {
        public int SaleId { get; set; }
        public Sale Sale { get; set; } = null!;
    }
}
