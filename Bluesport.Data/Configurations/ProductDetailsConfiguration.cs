using System.Collections.Generic;
using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace Bluesport.Data.Configurations
{
    public class ProductDetailsConfiguration : IEntityTypeConfiguration<ProductDetails>
    {
        public void Configure(EntityTypeBuilder<ProductDetails> builder)
        {
            builder.ToTable("ProductDetails");
            builder.HasKey(x => x.id);
            builder.Property(x => x.detail)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<Dictionary<string, string>>(v));;

            builder.HasOne(x => x.product).WithMany(x => x.productDetails)
                .HasForeignKey(x => x.productId);
        }
    }
}