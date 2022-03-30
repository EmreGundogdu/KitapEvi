using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi.Model.Models
{
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required, MaxLength(13)]
        public string ISBN { get; set; }
        [NotMapped]
        public int DiscountedPrice { get; set; }
    }
}
