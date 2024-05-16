using Task11;

ISet<string> set1 = new HashSet<string>();
set1.Add("Author1");
set1.Add("Author2");
set1.Add("Author4");

ISet<string> set2 = new HashSet<string>();
set2.Add("Author2");
set2.Add("Author4");

ISet<string> set3 = new HashSet<string>();
set3.Add("Author3");
set3.Add("Author5");

ISet<string> set4 = new HashSet<string>();
set4.Add("Author1");
set4.Add("Author5");

ISet<string> set5 = new HashSet<string>();
set5.Add("Author1");
set5.Add("Author2");
set5.Add("Author3");

Book book1 = new Book("A Book", new DateOnly(2000, 1, 15), set1);
Book book2 = new Book("T Book", new DateOnly(2022, 4, 20), set2);
Book book3 = new Book("D Book", new DateOnly(2018, 6, 2), set3);
Book book4 = new Book("H Book", new DateOnly(2012, 8, 28), set4);
Book book5 = new Book("G Book", new DateOnly(2015, 12, 8), set5);

Catalog catalog = new Catalog();
catalog.AddBook("123-5-28-456792-5", book1);
catalog.AddBook("123-5-28-456792-8", book2);
catalog.AddBook("1247984567927", book3);
catalog.AddBook("389-5-28-856792-5", book4);
catalog.AddBook("450-5-28-370916-4", book5);

Book test = new Book();
//catalog.AddBook("71-2-78-459602-4", test);
//catalog.AddBook("7145-2-78-459602-4", test);
//catalog.AddBook("714--78-459602-4", test);
//catalog.AddBook("714-24-78-459602-4", test);
//catalog.AddBook("714-2-7-459602-4", test);
//catalog.AddBook("714-2-788-459602-4", test);
//catalog.AddBook("714-2-78-45960-4", test);
//catalog.AddBook("714-2-78-4596011-4", test);
//catalog.AddBook("714-2-78-459601-", test);
//catalog.AddBook("714-2-78-459601-45", test);
//catalog.AddBook("7142-788-459601-4", test);
//catalog.AddBook("714--2-78-459601-4", test);
//catalog.AddBook("714-278-459601-4", test);
//catalog.AddBook("714-2--78-459601-4", test);
//catalog.AddBook("714-2-78459601-4", test);
//catalog.AddBook("714-2-78--459601-4", test);
//catalog.AddBook("714-2-78-4596014", test);
//catalog.AddBook("714-2-78-459601--4", test);
//catalog.AddBook("7A14-2-78-459601-4", test);
//catalog.AddBook("714-2c-78-459601-4", test);
//catalog.AddBook("714-2-78-459G601-4", test);
//catalog.AddBook("714-2-78-459601-4p", test);
//catalog.AddBook("714278459601", test);
//catalog.AddBook("71427845960148", test);

ISet<Book> sorted = catalog.GetSortedBooks();
ISet<Book> author = catalog.GetBooksByAuthor("Author2");
(string, int) count = catalog.GetAuthorBooksCount("Author3");
Console.WriteLine(count);