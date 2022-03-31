using KitapEvi.DataAccess.Data;
using KitapEvi.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public IActionResult UpdateInsert(int? id)
        {
            Category category = new();
            if (id == null)
            {
                return View(category);
            }
            category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateInser(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.CategoryId == 0)
                {
                    _context.Categories.Add(category);
                }
                else
                {
                    _context.Categories.Update(category);
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddMany3()
        {
            List<Category> categories = new List<Category>();
            for (int i = 1; i <= 3; i++)
            {
                categories.Add(new Category
                {
                    CategoryName = Guid.NewGuid().ToString()
                });
            }
            _context.Categories.AddRange(categories);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddMany10()
        {
            List<Category> categories = new List<Category>();
            for (int i = 1; i <= 10; i++)
            {
                categories.Add(new Category
                {
                    CategoryName = Guid.NewGuid().ToString()
                });
            }
            _context.Categories.AddRange(categories);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult DeleteMany3()
        {
            IEnumerable<Category> categories = _context.Categories.OrderByDescending(x => x.CategoryId).Take(3).ToList();

            _context.Categories.RemoveRange(categories);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult DeleteMany10()
        {
            IEnumerable<Category> categories = _context.Categories.OrderByDescending(x => x.CategoryId).Take(10).ToList();

            _context.Categories.RemoveRange(categories);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
