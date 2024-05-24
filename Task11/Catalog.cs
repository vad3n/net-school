using System.Collections;
using System.Text.RegularExpressions;

namespace Task11
{
    public class Catalog : IEnumerable
    {
        private IList<Tuple<string, Book>> _books;

        private bool isValidISBN(string isbn)
        {
            return (isbn.Length == 17 && Regex.IsMatch(isbn, @"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}")) || (isbn.Length == 13 && Regex.IsMatch(isbn, @"\d{13}"));
        }

        public Catalog()
        {
            _books = new List<Tuple<string, Book>>();
        }

        public Book this[string isbn]
        {
            get
            {
                if (!isValidISBN(isbn))
                {
                    throw new ArgumentException("Invalid format for ISBN.");
                }

                return _books.First(t => t.Item1.Equals(isbn)).Item2;
            }

            set
            {
                if (!isValidISBN(isbn))
                {
                    throw new ArgumentException("Invalid format for ISBN.");
                }

                if (_books.Any(t => t.Item1.Equals(isbn)))
                {
                    throw new ArgumentException("Book with ISBN already exists.");
                }

                _books.Add(Tuple.Create(isbn, value));
            }
        }

        public ISet<Book> GetSortedBooks()
        {
            return _books.Select(t => t.Item2).OrderBy(b => b.Title).ToHashSet();
        }

        public ISet<Book> GetBooksByAuthor(string author)
        {
            return _books.Select(t => t.Item2).Where(b => b.Authors.Contains(author)).OrderBy(b => b.PublicationDate).ToHashSet();
        }

        public ISet<Tuple<string, int>> GetAuthorBooksCount()
        {
            ISet<string> authors = new HashSet<string>();

            foreach (var tuple in _books)
            {
                foreach (var author in tuple.Item2.Authors)
                {
                    authors.Add(author);
                }
            }

            ISet<Tuple<string, int>> result = new HashSet<Tuple<string, int>>();

            foreach (var author in authors)
            {
                int count = 0;

                foreach (var tuple in _books)
                {
                    if (tuple.Item2.Authors.Contains(author))
                    {
                        count++;
                    }
                }

                result.Add(Tuple.Create(author, count));
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_books).GetEnumerator();
        }
    }
}
