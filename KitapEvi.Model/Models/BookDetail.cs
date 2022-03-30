using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
