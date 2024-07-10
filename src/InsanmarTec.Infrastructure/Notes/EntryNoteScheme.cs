using InsanmarTec.Domain.Notes.EntryNotes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Notes
{
    public class EntryNoteScheme : IEntityTypeConfiguration<EntryNote>
    {
        public void Configure(EntityTypeBuilder<EntryNote> builder) =>
            builder.Property(e => e.Id).UseIdentityColumn(seed: 100000);
    }
}
