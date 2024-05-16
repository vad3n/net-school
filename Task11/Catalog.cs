using System.Text.RegularExpressions;

namespace Task11
{
    public class Catalog
    {
        private IDictionary<string, Book> _books;

        private bool isValidISBN(string isbn)
        {
            return (isbn.Length == 17&& Regex.IsMatch(isbn, @"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}")) || (isbn.Length == 13 && Regex.IsMatch(isbn, @"\d{13}"));
        }

        public Catalog()
        {
            _books = new Dictionary<string, Book>();
        }

        public void AddBook(string isbn, Book book)
        {
            if (!isValidISBN(isbn))
            {
                throw new ArgumentException("Invalid format for ISBN.");
            }

            if (_books.ContainsKey(isbn))
            {
                throw new ArgumentException("Book with ISBN already exists.");
            }

            _books.Add(isbn, book);
        }

        public Book GetBook(string isbn)
        {
            if (!isValidISBN(isbn))
            {
                throw new ArgumentException("Invalid format for ISBN.");
            }

            return _books[isbn];
        }

        public ISet<Book> GetSortedBooks()
        {
            return _books.Values.OrderBy(b => b.Title).ToHashSet();
        }

        public ISet<Book> GetBooksByAuthor(string author)
        {
            return _books.Values.Where(b => b.Authors.Contains(author)).OrderBy(b => b.PublicationDate).ToHashSet();
        }

        public (string, int) GetAuthorBooksCount(string author)
        {
            return (author, _books.Values.Where(b => b.Authors.Contains(author)).Count());
        }
    }
}
