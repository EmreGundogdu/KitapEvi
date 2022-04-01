using KitapEvi.DataAccess.Data;
using KitapEvi.Model.Models;
using KitapEvi.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace KitapEvi.Web.Controllers
{
    public class BooksController : Controller
    {
        readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Book> writers = _context.Books.ToList();
            return View(writers);
        }
        public IActionResult UpdateInsert(int? id)
        {
            BookViewModel book = new();
            book.ListOfPublishers = _context.Publishers.Select(x => new SelectListItem
            {
                Text = x.PublisherName,
                Value = x.PublisherId.ToString()
            });
            if (id == null)
            {
                return View(book);
            }

            book.Book = _context.Books.FirstOrDefault(x => x.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
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
