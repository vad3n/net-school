using System.Text;
using System.Text.RegularExpressions;

namespace Task12
{
    public class Catalog
    {
        public List<BookTuple> Books { get; set; }

        private bool IsValidISBN(string isbn)
        {
            return (isbn.Length == 17 && Regex.IsMatch(isbn, @"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}")) || (isbn.Length == 13 && Regex.IsMatch(isbn, @"\d{13}"));
        }

        private string TransformISBN(string isbn)
        {
            StringBuilder newISBN = new StringBuilder();
            newISBN.Append(isbn.Substring(0, 3));
            newISBN.Append('-');
            newISBN.Append(isbn.Substring(3, 1));
            newISBN.Append('-');
            newISBN.Append(isbn.Substring(4, 2));
            newISBN.Append('-');
            newISBN.Append(isbn.Substring(6, 6));
            newISBN.Append('-');
            newISBN.Append(isbn.Substring(12, 1));

            return newISBN.ToString();
        }

        public Catalog()
        {
            Books = new List<BookTuple>();
        }

        public Book this[string isbn]
        {
            get
            {
                if (!IsValidISBN(isbn))
                {
                    throw new ArgumentException("Invalid format for ISBN.");
                }

                if (isbn.Length == 13)
                {
                    isbn = TransformISBN(isbn);
                }

                return Books.First(t => t.ISBN.Equals(isbn)).Book;
            }

            set
            {
                if (!IsValidISBN(isbn))
                {
                    throw new ArgumentException("Invalid format for ISBN.");
                }

                if (isbn.Length == 13)
                {
                    isbn = TransformISBN(isbn);
                }

                if (Books.Any(t => t.ISBN.Equals(isbn)))
                {
                    throw new ArgumentException("Book with ISBN already exists.");
                }

                Books.Add(new BookTuple(isbn, value));
            }
        }
    }
}
