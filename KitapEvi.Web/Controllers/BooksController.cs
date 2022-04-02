using KitapEvi.DataAccess.Data;
using KitapEvi.Model.Models;
using KitapEvi.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            List<Book> books = _context.Books.ToList();
            foreach (var obj in books)
            {
                //Uygulunabilir ama server açısından verimli değildir
                //obj.Publisher = _context.Publishers.FirstOrDefault(x => x.PublisherId == obj.PublisherId);

                //Uygulanabilir ve server açısından verimlidir.
                _context.Entry(obj).Reference(x => x.Publisher).Load();
            }
            return View(books);
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
        public IActionResult UpdateInsert(BookViewModel bookVm)
        {
            if (bookVm.Book.BookId == 0)
            {
                _context.Books.Add(bookVm.Book);
            }
            else
            {
                _context.Books.Update(bookVm.Book);
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.BookId == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int? id)
        {
            BookViewModel book = new();

            if (id == null)
            {
                return View(book);
            }

            book.Book = _context.Books.Include(x => x.BookDetail).FirstOrDefault(x => x.BookId == id);
            //book.Book.BookDetail = _context.BookDetails.FirstOrDefault(x => x.BookDetailId == book.Book.BookId);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(BookViewModel bookVm)
        {
            if (bookVm.Book.BookDetailId == 0)
            {
                _context.BookDetails.Add(bookVm.Book.BookDetail);
                _context.SaveChanges();
                var bookData = _context.Books.FirstOrDefault(x => x.BookDetailId == bookVm.Book.BookId);
                bookData.BookDetailId = bookVm.Book.BookDetailId;
                _context.SaveChanges();
            }
            else
            {
                _context.BookDetails.Update(bookVm.Book.BookDetail);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult ABD()
        {
            IEnumerable<Book> bookList = _context.Books;
            var filtreleme1 = bookList.Where(a => a.Price > 25);

            IQueryable<Book> bookList2 = _context.Books;
            var filtreleme2 = bookList.Where(a => a.Price > 25);

            return RedirectToAction(nameof(Index))
        }
    }
}
