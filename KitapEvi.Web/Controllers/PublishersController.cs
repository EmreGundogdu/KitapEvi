using KitapEvi.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace KitapEvi.Web.Controllers
{
    public class PublishersController : Controller
    {
        readonly ApplicationDbContext _context;

        public PublishersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpdateInsert(int? id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateInsert()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
