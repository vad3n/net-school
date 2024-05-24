namespace Task11
{
    public class Book
    {
        private string _title;
        private DateOnly? _publicationDate;
        private ISet<string> _authors;

        public string Title => _title;
        public DateOnly? PublicationDate => _publicationDate;
        public ISet<string> Authors => _authors;

        public Book()
        {

        }

        public Book(string title, DateOnly? publicationDate, ISet<string> authors)
        {
            if (title == null || title.Length == 0)
            {
                throw new ArgumentException("Title must be not null and not empty.");
            }

            _title = title;
            _publicationDate = publicationDate;
            _authors = authors;
        }

        public override string ToString()
        {
            return $"Title = {_title}, Publication date = {_publicationDate}, Authors = {_authors}";
        }
    }
}
