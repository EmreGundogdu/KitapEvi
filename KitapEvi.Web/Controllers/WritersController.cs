using KitapEvi.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace KitapEvi.Web.Controllers
{
    public class WritersController : Controller
    {
        readonly ApplicationDbContext _context;

        public WritersController(ApplicationDbContext context)
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
