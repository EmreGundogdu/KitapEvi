using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi.Model.Models
{
    public class BookType
    {
        public int BookTypeId { get; set; }
        public string TypeName { get; set; }
        public int Views { get; set; }
    }
}
