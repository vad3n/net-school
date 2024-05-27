using System.Text.Json;

namespace Task12
{
    public class JsonCatalogSerializer : ICatalogSerializer
    {
        public void Save(Catalog catalog, string fileName)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(catalog, options);
            File.WriteAllText(fileName, jsonString);
        }

        public Catalog Restore(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Catalog>(jsonString)!;
        }
    }
}
