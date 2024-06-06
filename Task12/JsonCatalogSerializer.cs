using System.Text.Json;

namespace Task12
{
    public class JsonCatalogSerializer
    {
        public void Save(Catalog catalog)
        {
            HashSet<Author> authors = new HashSet<Author>();

            foreach (var book in catalog.Books)
            {
                foreach (var author in book.Book.Authors)
                {
                    authors.Add(author);
                }
            }

            foreach (var author in authors)
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var books = catalog.Books.Where(e => e.Book.Authors.Contains(author));
                string jsonString = JsonSerializer.Serialize(books, options);
                string fileName = author.FirstName.ToLower() + "-" + author.LastName.ToLower() + ".json";
                Console.WriteLine(jsonString);
                Console.WriteLine(fileName);
                File.WriteAllText(fileName, jsonString);
            }
        }

        public Catalog Restore(params string[] fileNames)
        {
            Catalog catalog = new Catalog();

            foreach (var fileName in fileNames)
            {
                string jsonString = File.ReadAllText(fileName);
                var books = JsonSerializer.Deserialize<IEnumerable<BookEntity>>(jsonString);

                foreach (var book in books)
                {
                    try
                    {
                        catalog[book.ISBN] = book.Book;
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            return catalog;
        }
    }
}
