using KitapEvi.DataAccess.FluentValidation;
using KitapEvi.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace KitapEvi.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }
        public DbSet<FluentApi_BookDetail> FluentApi_BookDetails { get; set; }
        public DbSet<FluentApi_Book> FluentApi_Books { get; set; }
        public DbSet<FluentApi_Writer> FluentApi_Writers { get; set; }
        public DbSet<FluentApi_Publisher> FluentApi_Publishers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookWriter>().HasKey(x => new { x.WriterId, x.BookId });

            modelBuilder.ApplyConfiguration(new BookConfiugration());
            modelBuilder.ApplyConfiguration(new BookDetailConfiguration());
            modelBuilder.ApplyConfiguration(new BookWriterConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
            modelBuilder.ApplyConfiguration(new WriterConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
