using Microsoft.AspNetCore.Mvc;

namespace KitapEvi.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
