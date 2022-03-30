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
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }
        public DbSet<FluentApi_BookDetail> FluentApi_BookDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composite Key Oluşturma
            modelBuilder.Entity<BookWriter>().HasKey(x => new { x.WriterId, x.BookId });


            modelBuilder.Entity<FluentApi_BookDetail>().HasKey(x => x.BookDetailId);
            modelBuilder.Entity<FluentApi_BookDetail>().Property(x => x.NumberOfEpisodes).IsRequired();
            base.OnModelCreating(modelBuilder);
        }

    }
}
