using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class SizeMapColorConfiguration : IEntityTypeConfiguration<SizeMapColor>
    {
        public void Configure(EntityTypeBuilder<SizeMapColor> builder)
        {
            builder.ToTable("SizeMapColor");
            builder.HasKey(x => new {x.sizeId, x.colorId});
            builder.Property(x => x.quantity);

            builder.HasOne(x => x.size).WithMany(x => x.sizeMapColors)
                .HasForeignKey(x => x.sizeId);
            builder.HasOne(x => x.color).WithMany(x => x.sizeMapColors)
                .HasForeignKey(x => x.colorId);
        }
    }
}