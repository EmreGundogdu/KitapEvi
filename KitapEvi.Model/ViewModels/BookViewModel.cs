using KitapEvi.Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi.Model.ViewModels
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<SelectListItem> ListOfPublishers { get; set; }
    }
}
