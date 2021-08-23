using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class ProductMapCateConfiguration : IEntityTypeConfiguration<ProductMapCate>
    {
        public void Configure(EntityTypeBuilder<ProductMapCate> builder)
        {
            builder.ToTable("ProductMapCate");
            builder.HasKey(x => new {x.productId, x.cateId});

            builder.HasOne(x => x.product).WithMany(x => x.productMapCates)
                .HasForeignKey(x => x.productId);
            builder.HasOne(x => x.category).WithMany(x => x.productMapCates)
                .HasForeignKey(x => x.cateId);
        }
    }
}