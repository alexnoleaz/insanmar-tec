using InsanmarTec.Domain.Purchases;
using InsanmarTec.Domain.Shared.Entities.Auditing;

namespace InsanmarTec.Domain.Notes.EntryNotes
{
    public class EntryNote : CreationAuditedEntity
    {
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; } = null!;
    }
}
