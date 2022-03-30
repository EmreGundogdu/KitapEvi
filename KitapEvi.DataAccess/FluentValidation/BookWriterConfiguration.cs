using KitapEvi.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitapEvi.DataAccess.FluentValidation
{
    public class BookWriterConfiguration : IEntityTypeConfiguration<FluentApi_BookWriter>
    {
        public void Configure(EntityTypeBuilder<FluentApi_BookWriter> builder)
        {
            builder.HasKey(x => new { x.WriterId, x.BookId });
            builder.HasOne(x => x.FluentApi_Book).WithMany(x => x.FluentApi_BookWriters).HasForeignKey(x => x.BookId);
            builder.HasOne(x => x.FluentApi_Writer).WithMany(x => x.FluentApi_BookWriters).HasForeignKey(x => x.WriterId);
        }
    }
}
