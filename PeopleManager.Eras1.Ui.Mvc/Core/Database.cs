using PeopleManager.Eras1.Ui.Mvc.Models;

namespace PeopleManager.Eras1.Ui.Mvc.Core
{
    public class Database
    {
        public IList<Person> People { get; set; } = new List<Person>();

        public void Seed()
        {
            People = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com"
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = null
                },
                new Person
                {
                    Id = 4,
                    FirstName = "Bob",
                    LastName = "Williams",
                    Email = "bob.williams@example.com"
                },
                new Person
                {
                    Id = 5,
                    FirstName = "Eva",
                    LastName = "Davis",
                    Email = "eva.davis@example.com"
                },
                new Person
                {
                    Id = 6,
                    FirstName = "Michael",
                    LastName = "Brown",
                    Email = null
                },
                new Person
                {
                    Id = 7,
                    FirstName = "Sarah",
                    LastName = "Miller",
                    Email = "sarah.miller@example.com"
                },
                new Person
                {
                    Id = 8,
                    FirstName = "David",
                    LastName = "Lee",
                    Email = "david.lee@example.com"
                },
                new Person
                {
                    Id = 9,
                    FirstName = "Emily",
                    LastName = "Wilson",
                    Email = null
                },
                new Person
                {
                    Id = 10,
                    FirstName = "James",
                    LastName = "Clark",
                    Email = "james.clark@example.com"
                }
            };
        }
    }
}
