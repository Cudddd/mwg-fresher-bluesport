using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class ProductMapSizeConfiguration : IEntityTypeConfiguration<ProductMapSize>
    {
        public void Configure(EntityTypeBuilder<ProductMapSize> builder)
        {
            builder.ToTable("ProductMapSize");
            builder.HasKey(x => new {x.productId, x.sizeId});

            builder.HasOne(x => x.product).WithMany(x => x.productMapsizes)
                .HasForeignKey(x => x.productId);
            builder.HasOne(x => x.size).WithMany(x => x.productMapSizes)
                .HasForeignKey(x => x.sizeId);
        }
    }
}