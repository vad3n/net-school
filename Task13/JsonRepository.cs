using System.Text.Json;

namespace Task13
{
    public static class JsonRepository
    {
        public static void Save(Catalog<PaperBook> catalog, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(catalog);

            File.WriteAllText(fileName, jsonString);
        }

        public static void Save(Catalog<EBook> catalog, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(catalog);

            File.WriteAllText(fileName, jsonString);
        }

        public static Catalog<B> Restore<B>(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Catalog<B>>(jsonString)!;
        }
    }
}
