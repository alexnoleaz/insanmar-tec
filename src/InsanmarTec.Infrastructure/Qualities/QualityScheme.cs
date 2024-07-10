using InsanmarTec.Domain.Qualities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Qualities
{
    public class QualityScheme : IEntityTypeConfiguration<Quality>
    {
        public void Configure(EntityTypeBuilder<Quality> builder)
        {
            builder.Property(q => q.Name).HasMaxLength(QualityConsts.MaxNameLength);
            builder.Property(q => q.Description).HasMaxLength(QualityConsts.MaxDescriptionLength);
        }
    }
}
