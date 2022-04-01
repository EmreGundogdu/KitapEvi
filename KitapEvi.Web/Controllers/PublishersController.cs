using KitapEvi.DataAccess.Data;
using KitapEvi.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
            List<Publisher> categories = _context.Publishers.ToList();
            return View(categories);
        }
        public IActionResult UpdateInsert(int? id)
        {
            Publisher publisher = new();
            if (id == null)
            {
                return View(publisher);
            }
            publisher = _context.Publishers.FirstOrDefault(x => x.PublisherId == id);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateInsert(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                if (publisher.PublisherId == 0)
                {
                    _context.Publishers.Add(publisher);
                }
                else
                {
                    _context.Publishers.Update(publisher);
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }
        public IActionResult Delete(int id)
        {
            var publisher = _context.Publishers.FirstOrDefault(x => x.PublisherId == id);
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
