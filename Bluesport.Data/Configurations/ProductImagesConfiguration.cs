using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class ProductImagesConfiguration : IEntityTypeConfiguration<ProductImages>
    {
        public void Configure(EntityTypeBuilder<ProductImages> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(x => x.id);
            builder.Property(x => x.alt);
            builder.Property(x => x.avatar);
            builder.Property(x => x.path);

            builder.HasOne(x => x.product).WithMany(x => x.productImgaes)
                .HasForeignKey(x => x.productId);
        }
    }
}