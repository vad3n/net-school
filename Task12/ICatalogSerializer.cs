namespace Task12
{
    public interface ICatalogSerializer
    {
        void Save(Catalog catalog, string fileName);

        Catalog Restore(string fileName);
    }
}
