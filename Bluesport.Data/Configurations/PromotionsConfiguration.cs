using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class PromotionsConfiguration : IEntityTypeConfiguration<Promotions>
    {
        public void Configure(EntityTypeBuilder<Promotions> builder)
        {
            builder.ToTable("Promotions");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name);

            builder.HasOne(x => x.product).WithMany(x => x.promotions)
                .HasForeignKey(x => x.productId);
        }
    }
}