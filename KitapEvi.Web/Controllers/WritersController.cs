using KitapEvi.DataAccess.Data;
using KitapEvi.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
            List<Writer> writers = _context.Writers.ToList();
            return View(writers);
        }
        public IActionResult UpdateInsert(int? id)
        {
            Writer writer = new();
            if (id == null)
            {
                return View(writer);
            }
            writer = _context.Writers.FirstOrDefault(x => x.WriterId == id);
            if (writer == null)
            {
                return NotFound();
            }
            return View(writer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateInsert(Writer writer)
        {
            if (ModelState.IsValid)
            {
                if (writer.WriterId == 0)
                {
                    _context.Writers.Add(writer);
                }
                else
                {
                    _context.Writers.Update(writer);
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(writer);
        }
        public IActionResult Delete(int id)
        {
            var writer = _context.Writers.FirstOrDefault(x => x.WriterId == id);
            _context.Writers.Remove(writer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
