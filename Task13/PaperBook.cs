namespace Task13
{
    public class PaperBook
    {
        public string Title { get; set; }
        public DateOnly? PublicationDate { get; set; }
        public List<string> ISBNs { get; set; }
        public string Publisher { get; set; }
        public List<Author> Authors { get; set; }

        public PaperBook()
        {

        }

        public PaperBook(string title, DateOnly? publicationDate, List<string> ISBNs, string publisher, List<Author> authors)
        {
            Title = title;
            PublicationDate = publicationDate;
            this.ISBNs = ISBNs;
            Publisher = publisher;
            Authors = authors;
        }
    }
}
