using System.Collections.Generic;

namespace KitapEvi.Model.Models
{
    public class FluentApi_Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public string ISBN { get; set; }
        public int BookDetailId { get; set; }
        public FluentApi_BookDetail FluentApi_BookDetail { get; set; }
        public int PublisherId { get; set; }
        public FluentApi_Publisher FluentApi_Publisher { get; set; }
        public ICollection<FluentApi_BookWriter> FluentApi_BookWriters { get; set; }
    }
}
