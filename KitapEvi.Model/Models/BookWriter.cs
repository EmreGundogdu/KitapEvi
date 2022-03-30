using System.ComponentModel.DataAnnotations.Schema;

namespace KitapEvi.Model.Models
{
    public class BookWriter
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Writer")]
        public int WriterId { get; set; }
        public Book Book { get; set; }
        public Writer Writer { get; set; }
    }
}
