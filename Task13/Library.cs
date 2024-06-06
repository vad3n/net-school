namespace Task13
{
    public class Library<B> : ILibrary
    {
        public Catalog<B> Catalog { get; set; }
        public HashSet<string> PressReleaseItems { get; set; }

        public Library()
        {

        }

        public Library(Catalog<B> catalog)
        {
            PressReleaseItems = new HashSet<string>();

            if (catalog is Catalog<PaperBook>)
            {
                foreach (var book in catalog.Books.Values)
                {
                    PressReleaseItems.Add((book as PaperBook)!.Publisher);
                }
            }

            else if (catalog is Catalog<EBook>)
            {
                foreach (var book in catalog.Books.Values)
                {
                    List<string> formats = (book as EBook)!.Formats;

                    foreach (var format in formats)
                    {
                        PressReleaseItems.Add(format);
                    }
                }
            }

            Catalog = catalog;
        }
    }
}
