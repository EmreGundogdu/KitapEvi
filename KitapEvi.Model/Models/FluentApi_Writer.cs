using System;
using System.Collections.Generic;

namespace KitapEvi.Model.Models
{
    public class FluentApi_Writer
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string Location { get; set; }
        public DateTime Birthday { get; set; }
        public string NameSurname { get => $"{WriterName} + {WriterName}"; }
        public ICollection<FluentApi_BookWriter> FluentApi_BookWriters { get; set; }
    }
}
