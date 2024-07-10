using InsanmarTec.Domain.Notes.ExitNotes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Notes
{
    public class ExitNoteScheme : IEntityTypeConfiguration<ExitNote>
    {
        public void Configure(EntityTypeBuilder<ExitNote> builder) =>
            builder.Property(e => e.Id).UseIdentityColumn(seed: 100000);
    }
}
