using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi.Model.Models
{
    public class FluentApi_Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string Location { get; set; }
    }
}
