using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class BrandsConfiguration : IEntityTypeConfiguration<Brands>
    {
        public void Configure(EntityTypeBuilder<Brands> builder)
        {
            builder.ToTable("Brands");
            builder.HasKey(x => x.id);
            builder.Property(x => x.image);
            builder.Property(x => x.info);
            builder.Property(x => x.name);
        }
    }
}