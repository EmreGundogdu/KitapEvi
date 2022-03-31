using KitapEvi.DataAccess.Data;
using KitapEvi.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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
