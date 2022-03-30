using KitapEvi.DataAccess.Data;
using KitapEvi.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KitapEvi.Web.Controllers
{
    public class CategoriesController : Controller
    {
        readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
    }
}
