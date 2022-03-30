using System.ComponentModel.DataAnnotations;

namespace KitapEvi.Model.Models
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        [Required]
        public int NumberOfEpisodes { get; set; }
        public int BookPage { get; set; }
        public double Weight { get; set; }
        public Book Book { get; set; }
    }
}
