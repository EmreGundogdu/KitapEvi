namespace KitapEvi.Model.Models
{
    public class FluentApi_BookWriter
    {
        public int BookId { get; set; }
        public int WriterId { get; set; }
        public FluentApi_Book FluentApi_Book { get; set; }
        public FluentApi_Writer FluentApi_Writer { get; set; }
    }
}
