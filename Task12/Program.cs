using Task12;

Author author1 = new Author("Robert", "Kiyosaki", new DateOnly(1947, 4, 8));
Author author2 = new Author("Sharon", "Lechter", new DateOnly(1954, 1, 12));
Author author3 = new Author("Rachel", "Caine", new DateOnly(1962, 4, 27));
Author author4 = new Author("Ann", "Aguirre", new DateOnly(1970, 8, 27));
Author author5 = new Author("Albert", "Camus", new DateOnly(1913, 11, 7));

HashSet<Author> set1 = new HashSet<Author>();
set1.Add(author1);
set1.Add(author2);
HashSet<Author> set2 = new HashSet<Author>();
set2.Add(author3);
set2.Add(author4);
HashSet<Author> set3 = new HashSet<Author>();
set3.Add(author5);

Book book1 = new Book("Rich Dad Poor Dad", new DateOnly(2000, 4, 1), set1);
Book book2 = new Book("Honor Among Thieves", null, set2);
Book book3 = new Book("Honor Bound", null, set2);
Book book4 = new Book("Honor Lost", null, set2);
Book book5 = new Book("The Stranger", new DateOnly(1942, 5, 19), set3);
Book book6 = new Book("The Plague", null, set3);

Catalog catalog = new Catalog();
catalog["111-1-11-111111-1"] = book1;
catalog["222-2-22-222222-2"] = book2;
catalog["3333333333333"] = book3;
catalog["4444444444444"] = book4;
catalog["555-5-55-555555-5"] = book5;
catalog["666-6-66-666666-6"] = book6;
Console.WriteLine(catalog["333-3-33-333333-3"]);
Console.WriteLine(catalog["4444444444444"]);
JsonCatalogSerializer serializer = new JsonCatalogSerializer();
//serializer.Save(catalog);
Catalog jsonCatalog = serializer.Restore("albert-camus.json", "ann-aguirre.json", "rachel-caine.json", "robert-kiyosaki.json", "sharon-lechter.json");
//ICatalogSerializer xmlSerializer = new XmlCatalogSerializer();
//xmlSerializer.Save(catalog, "catalog.xml");
//Catalog xmlCatalog = xmlSerializer.Restore("catalog.xml");