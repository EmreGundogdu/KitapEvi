using KitapEvi.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
