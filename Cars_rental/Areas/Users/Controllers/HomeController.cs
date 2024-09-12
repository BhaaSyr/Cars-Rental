using Microsoft.AspNetCore.Mvc;

namespace Cars_rental.Areas.Users.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult services()
        {
            return View();
        }

    }
}
