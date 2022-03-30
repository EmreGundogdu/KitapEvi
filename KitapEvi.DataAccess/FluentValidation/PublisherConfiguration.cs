using KitapEvi.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitapEvi.DataAccess.FluentValidation
{
    public class PublisherConfiguration : IEntityTypeConfiguration<FluentApi_Publisher>
    {
        public void Configure(EntityTypeBuilder<FluentApi_Publisher> builder)
        {
            builder.HasKey(x => x.PublisherId);
            builder.Property(x => x.PublisherName).IsRequired();
            builder.Property(x => x.Location).IsRequired();
        }
    }
}
