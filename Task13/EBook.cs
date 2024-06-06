namespace Task13
{
    public class EBook
    {
        public string Title { get; set; }
        public string Resource { get; set; }
        public List<string> Formats { get; set; }
        public List<Author> Authors { get; set; }

        public EBook()
        {

        }

        public EBook(string title, string resource, List<string> formats, List<Author> authors)
        {
            Title = title;
            Resource = resource;
            Formats = formats;
            Authors = authors;
        }
    }
}
