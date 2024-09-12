using Microsoft.AspNetCore.Mvc;

namespace Cars_rental.Areas.Users.Controllers
{
    public class CarController : Controller
    {
        public IActionResult car()
        {
            return View();
        }
        public IActionResult car_single()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
    }
}
