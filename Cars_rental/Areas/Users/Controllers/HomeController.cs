using Cars_rental.Data;
using Cars_rental.Models.VModels;
using Cars_rental.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Cars_rental.Areas.Users.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICar _car;
        public HomeController( ICar car )
        {
            _car = car;
        }
        public IActionResult Index()
        {

            Console.WriteLine("ggggggggg im hereeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
            CarsListViweModel ViweModel = new()
            {

                Cars = _car.GetAllCars(),
            };

            return View(ViweModel);
        }

        public IActionResult Add()
        {
        


            return View();
        }
        public IActionResult Privacy()
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
