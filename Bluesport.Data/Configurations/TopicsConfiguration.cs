using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class TopicsConfiguration : IEntityTypeConfiguration<Topics>
    {
        public void Configure(EntityTypeBuilder<Topics> builder)
        {
            builder.ToTable("Topic");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name);
        }
    }
}