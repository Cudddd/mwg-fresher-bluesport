using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class BannerTypesConfiguration : IEntityTypeConfiguration<BannerTypes>
    {
        public void Configure(EntityTypeBuilder<BannerTypes> builder)
        {
            builder.ToTable("BannerTypes");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name);
        }
    }
}