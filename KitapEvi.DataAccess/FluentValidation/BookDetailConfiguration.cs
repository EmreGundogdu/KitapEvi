using KitapEvi.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitapEvi.DataAccess.FluentValidation
{
    public class BookDetailConfiguration : IEntityTypeConfiguration<FluentApi_BookDetail>
    {
        public void Configure(EntityTypeBuilder<FluentApi_BookDetail> builder)
        {
            builder.HasKey(x => x.BookDetailId);
            builder.Property(x => x.NumberOfEpisodes).IsRequired();
        }
    }
}
