using InsanmarTec.Domain.Brands;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Brands
{
    public class BrandScheme : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(BrandConsts.MaxNameLength);
            builder.Property(b => b.Description).HasMaxLength(BrandConsts.MaxDescriptionLength);
            builder.Property(b => b.Category).HasMaxLength(BrandConsts.MaxCategoryLength);

            builder.HasIndex(b => b.Name).IsUnique();
        }
    }
}
