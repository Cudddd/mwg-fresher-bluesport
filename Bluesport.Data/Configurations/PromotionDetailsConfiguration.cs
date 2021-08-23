using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class PromotionDetailsConfiguration : IEntityTypeConfiguration<PromotionDetails>
    {
        public void Configure(EntityTypeBuilder<PromotionDetails> builder)
        {
            builder.ToTable("PromotionDetails");
            builder.HasKey(x => x.id);
            builder.Property(x => x.info);
            builder.Property(x => x.more);
            builder.Property(x => x.online);

            builder.HasOne(x => x.promotion).WithMany(x => x.promotionDetails)
                .HasForeignKey(x => x.promotionId);
        }
    }
}