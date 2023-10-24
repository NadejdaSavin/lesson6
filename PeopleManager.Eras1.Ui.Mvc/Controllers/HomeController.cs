using Microsoft.AspNetCore.Mvc;
using PeopleManager.Eras1.Ui.Mvc.Models;
using System.Diagnostics;
using PeopleManager.Eras1.Ui.Mvc.Core;

namespace PeopleManager.Eras1.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly Database _database;

        public HomeController(Database database)
        {
            _database = database;
        }


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FirstName = "Bavo";

            var people = _database.People;

            return View(people);
        }

        public IActionResult Details(int id)
        {
            var person = _database.People
                .FirstOrDefault(p => p.Id == id);
            return View(person);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}