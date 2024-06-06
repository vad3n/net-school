namespace Task13
{
    public class Catalog<B>
    {
        public Dictionary<string, B> Books { get; set; }

        public Catalog()
        {

        }

        public Catalog(Dictionary<string, B> books)
        {
            Books = books;
        }

        public void AddBook(string identifier, B book)
        {
            if (Books.ContainsKey(identifier))
            {
                Console.WriteLine("Book with that identifier already exist.");
            }

            Books.Add(identifier, book);
        }
    }
}
