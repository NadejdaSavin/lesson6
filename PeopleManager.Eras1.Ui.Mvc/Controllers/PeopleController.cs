using Microsoft.AspNetCore.Mvc;
using PeopleManager.Eras1.Ui.Mvc.Core;
using PeopleManager.Eras1.Ui.Mvc.Models;

namespace PeopleManager.Eras1.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly Database _database;
        public PeopleController(Database database)
        {
            _database = database;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var people = _database.People;
            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            _database.People.Add(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = _database.People
                .FirstOrDefault(p => p.Id == id);

            if (person is null)
            {
                return RedirectToAction("Index");
            }

            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute]int id, [FromForm]Person person)
        {
            var dbPerson = _database.People
                .FirstOrDefault(p => p.Id == id);

            if (dbPerson is null)
            {
                return RedirectToAction("Index");
            }

            dbPerson.FirstName = person.FirstName;
            dbPerson.LastName = person.LastName;
            dbPerson.Email = person.Email;

            return RedirectToAction("Index");
        }
    }
}
