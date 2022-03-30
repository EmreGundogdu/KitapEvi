using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KitapEvi.Model.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        [Required]
        public string PublisherName { get; set; }
        [Required]
        public string Location { get; set; }
        public List<Book> Book { get; set; }
    }
}
