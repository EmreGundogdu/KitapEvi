using KitapEvi.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitapEvi.DataAccess.FluentValidation
{
    public class WriterConfiguration : IEntityTypeConfiguration<FluentApi_Writer>
    {
        public void Configure(EntityTypeBuilder<FluentApi_Writer> builder)
        {
            builder.HasKey(x => x.WriterId);
            builder.Property(x => x.WriterName).IsRequired();
            builder.Property(x => x.WriterSurname).IsRequired();
            builder.Ignore(x => x.NameSurname);
        }
    }
}
