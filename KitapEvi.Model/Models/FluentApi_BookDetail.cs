namespace KitapEvi.Model.Models
{
    public class FluentApi_BookDetail
    {
        public int BookDetailId { get; set; }
        public int NumberOfEpisodes { get; set; }
        public int BookPage { get; set; }
        public double Weight { get; set; }
        public FluentApi_Book FluentApi_Book { get; set; }
    }
}
