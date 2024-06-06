using System.ComponentModel.DataAnnotations;

namespace Task13
{
    public class Author
    {
        [StringLength(200, ErrorMessage = "First name cannot be more than 200 characters in length")]
        public string FirstName { get; set; }
        [StringLength(200, ErrorMessage = "Last name cannot be more than 200 characters in length")]
        public string LastName { get; set; }
        public DateOnly? BirthDate { get; set; }

        public Author()
        {

        }

        public Author(string firstName, string lastName, DateOnly? birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
