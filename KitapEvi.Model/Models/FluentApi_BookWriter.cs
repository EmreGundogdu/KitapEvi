using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi.Model.Models
{
    public class FluentApi_BookWriter
    {
        public int BookId { get; set; }
        public int WriterId { get; set; }
    }
}
