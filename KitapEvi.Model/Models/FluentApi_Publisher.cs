using System.Collections.Generic;

namespace KitapEvi.Model.Models
{
    public class FluentApi_Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string Location { get; set; }
        public List<FluentApi_Book> FluentApi_Book { get; set; }
    }
}
