using System.ComponentModel.DataAnnotations;

namespace PeopleManager.Eras1.Ui.Mvc.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
