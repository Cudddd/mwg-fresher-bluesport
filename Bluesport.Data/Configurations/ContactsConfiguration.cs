using Bluesport.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluesport.Data.Configurations
{
    public class ContactsConfiguration : IEntityTypeConfiguration<Contacts>
    {
        public void Configure(EntityTypeBuilder<Contacts> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.id);
            builder.Property(x => x.content);
            builder.Property(x => x.title);
            builder.Property(x => x.cusEmail);
            builder.Property(x => x.cusName);
            builder.Property(x => x.cusPhone);

            builder.HasOne(x => x.topic).WithMany(x => x.contacts)
                .HasForeignKey(x => x.topicId);
        }
    }
}