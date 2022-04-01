using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KitapEvi.Model.Models
{
    public class Writer
    {
        public int WriterId { get; set; }
        [Required]
        public string WriterName { get; set; }
        [Required]
        public string WriterSurname { get; set; }
        [Required]
        public string Location { get; set; }
        public DateTime Birthday { get; set; }
        [NotMapped]
        public string NameSurname { get => $"{WriterName} {WriterSurname}"; }
        public ICollection<BookWriter> BookWriters { get; set; }
    }
}
