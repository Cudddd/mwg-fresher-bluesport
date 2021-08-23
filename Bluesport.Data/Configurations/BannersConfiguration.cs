using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class BannersConfiguration : IEntityTypeConfiguration<Banners>
    {
        public void Configure(EntityTypeBuilder<Banners> builder)
        {
            builder.ToTable("Banners");
            builder.HasKey(x => x.id);
            builder.Property(x => x.alt);
            builder.Property(x => x.image);
            builder.Property(x => x.name);
            builder.Property(x => x.text);

            builder.HasOne(x => x.bannerType).WithMany(x => x.banners)
                .HasForeignKey(x => x.typeId);
        }
    }
}