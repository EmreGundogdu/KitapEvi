using KitapEvi.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitapEvi.DataAccess.FluentValidation
{
    public class BookConfiugration : IEntityTypeConfiguration<FluentApi_Book>
    {
        public void Configure(EntityTypeBuilder<FluentApi_Book> builder)
        {
            builder.HasKey(x => x.BookId);
            builder.Property(x => x.BookName).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.ISBN).IsRequired().HasMaxLength(13);

            builder.HasOne(x => x.FluentApi_BookDetail).WithOne(x => x.FluentApi_Book).HasForeignKey<FluentApi_Book>("BookDetailId");
            builder.HasOne(x => x.FluentApi_Publisher).WithMany(x => x.FluentApi_Book).HasForeignKey(x => x.PublisherId);
        }
    }
}
