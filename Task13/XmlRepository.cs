using System.Xml.Serialization;

namespace Task13
{
    public static class XmlRepository
    {
        public static void Save(Catalog<PaperBook> catalog, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog<PaperBook>));
            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, catalog);
            }
        }

        public static void Save(Catalog<EBook> catalog, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog<EBook>));
            using (var writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, catalog);
            }
        }

        public static Catalog<B> Restore<B>(string fileName)
        {
            Catalog<B> catalog = new Catalog<B>();
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog<B>));

            using (var reader = new StreamReader(fileName))
            {
                catalog = (Catalog<B>)serializer.Deserialize(reader)!;
            }

            return catalog;
        }
    }
}
