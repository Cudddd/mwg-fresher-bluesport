using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x=>x.id);
            builder.Property(x => x.description);
            builder.Property(x => x.installment);
            builder.Property(x => x.name);
            builder.Property(x => x.slug);
            builder.Property(x => x.priceCurrent);
            builder.Property(x => x.priceOld);
            builder.Property(x => x.saleOff);
            builder.Property(x => x.soldOut);

            builder.HasOne(x => x.brand).WithMany(x => x.products)
                .HasForeignKey(x=>x.brandId);
        }
    }
}