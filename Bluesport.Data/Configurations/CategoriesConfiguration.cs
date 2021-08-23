using System.Collections.Generic;
using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.id);
            builder.Property(x => x.level);
            builder.Property(x => x.name);
            builder.Property(x => x.slug);
            builder.Property(x => x.parentId);

        }
    }
}