using System.Xml.Serialization;

namespace Task12
{
    public class XmlCatalogSerializer : ICatalogSerializer
    {
        public void Save(Catalog catalog, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, catalog);
            }
        }

        public Catalog Restore(string fileName)
        {
            Catalog catalog = new Catalog();
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
            using (var reader = new FileStream(fileName, FileMode.Open))
            {
                catalog = (Catalog)serializer.Deserialize(reader)!;
            }

            return catalog;
        }
    }
}
