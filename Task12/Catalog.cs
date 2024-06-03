using System.Text;
using System.Text.RegularExpressions;

namespace Task12
{
    public class Catalog
    {
        public List<BookEntity> Books { get; set; }

        private bool IsValidISBN(string isbn)
        {
            return (isbn.Length == 17 && Regex.IsMatch(isbn, @"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}")) || (isbn.Length == 13 && Regex.IsMatch(isbn, @"\d{13}"));
        }

        public Catalog()
        {
            Books = new List<BookEntity>();
        }

        public Book this[string isbn]
        {
            get
            {
                if (!IsValidISBN(isbn))
                {
                    throw new ArgumentException("Invalid format for ISBN.");
                }

                if (isbn.Length != 13)
                {
                    isbn = isbn.Replace("-", string.Empty);
                }

                return Books.First(t => t.ISBN.Equals(isbn)).Book;
            }

            set
            {
                if (!IsValidISBN(isbn))
                {
                    throw new ArgumentException("Invalid format for ISBN.");
                }

                if (isbn.Length != 13)
                {
                    isbn = isbn.Replace("-", string.Empty);
                }

                if (Books.Any(t => t.ISBN.Equals(isbn)))
                {
                    throw new ArgumentException("Book with ISBN already exists.");
                }

                Books.Add(new BookEntity(isbn, value));
            }
        }
    }
}
