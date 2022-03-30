using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi.Model.Models
{
    public class Writer
    {
        public int Id { get; set; }
        [Required]
        public string WriterName { get; set; }
        [Required]
        public string WriterSurname { get; set; }
        [Required]
        public string Location { get; set; }
        public DateTime Birthday { get; set; }
        [NotMapped]
        public string NameSurname { get => $"{WriterName}+{WriterName}"; }
    }
}
