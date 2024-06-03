using System.Xml.Serialization;

namespace Task12
{
    public class Book
    {
        public string Title { get; set; }
        public DateOnly? PublicationDate { get; set; }
        public HashSet<Author> Authors { get; set; }

        public Book()
        {

        }

        public Book(string title, DateOnly? publicationDate, HashSet<Author> authors)
        {
            if (title == null || title.Length == 0)
            {
                throw new ArgumentException("Title must be not null and not empty.");
            }

            Title = title;
            PublicationDate = publicationDate;
            Authors = authors;
        }

        public override string ToString()
        {
            return $"Title = {Title}, Publication date = {PublicationDate}, Authors = {Authors}";
        }
    }
}
