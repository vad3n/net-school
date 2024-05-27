namespace Task12
{
    public class BookTuple
    {
        public string ISBN { get; set; }
        public Book Book { get; set; }

        public BookTuple()
        {

        }

        public BookTuple(string isbn, Book book)
        {
            ISBN = isbn;
            Book = book;
        }
    }
}
