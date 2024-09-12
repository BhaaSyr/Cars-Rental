using Microsoft.AspNetCore.Mvc;

namespace Cars_rental.Areas.Users.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult blog()
        {
            return View();
        }
        public IActionResult blog_single()
        {
            return View();
        }
    }
}
