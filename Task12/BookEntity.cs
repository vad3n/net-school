namespace Task12
{
    public class BookEntity
    {
        public string ISBN { get; set; }
        public Book Book { get; set; }

        public BookEntity()
        {

        }

        public BookEntity(string isbn, Book book)
        {
            ISBN = isbn;
            Book = book;
        }
    }
}
