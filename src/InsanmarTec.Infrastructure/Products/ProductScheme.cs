using InsanmarTec.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanmarTec.Infrastructure.Products
{
    public class ProductScheme : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(ProductConsts.MaxNameLength);
            builder.Property(p => p.Description).HasMaxLength(ProductConsts.MaxDescriptionLength);
            builder.Property(p => p.Id).UseIdentityColumn(seed: 100000);

            builder.Property(p => p.Price).HasColumnType("money");
        }
    }
}
