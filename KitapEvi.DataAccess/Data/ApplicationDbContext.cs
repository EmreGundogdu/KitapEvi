using KitapEvi.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Composite Key Oluşturma
            modelBuilder.Entity<BookWriter>().HasKey(x => new { x.WriterId, x.BookId });


            modelBuilder.Entity<FluentApi_BookDetail>().HasKey(x => x.BookDetailId);
            modelBuilder.Entity<FluentApi_BookDetail>().Property(x => x.NumberOfEpisodes).IsRequired();

            modelBuilder.Entity<FluentApi_Book>().HasKey(x => x.BookId);
            modelBuilder.Entity<FluentApi_Book>().Property(x => x.BookName).IsRequired();
            modelBuilder.Entity<FluentApi_Book>().Property(x => x.Price).IsRequired();
            modelBuilder.Entity<FluentApi_Book>().Property(x => x.ISBN).IsRequired().HasMaxLength(13);

            modelBuilder.Entity<FluentApi_Writer>().HasKey(x => x.WriterId);
            modelBuilder.Entity<FluentApi_Writer>().Property(x => x.WriterName).IsRequired();
            modelBuilder.Entity<FluentApi_Writer>().Property(x => x.WriterSurname).IsRequired();
            modelBuilder.Entity<FluentApi_Writer>().Ignore(x => x.NameSurname);

            modelBuilder.Entity<FluentApi_Publisher>().HasKey(x => x.PublisherId);
            modelBuilder.Entity<FluentApi_Publisher>().Property(x => x.PublisherName).IsRequired();
            modelBuilder.Entity<FluentApi_Publisher>().Property(x => x.Location).IsRequired();


            base.OnModelCreating(modelBuilder);
        }

    }
}
