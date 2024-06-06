namespace Task13
{
    public class PaperBookLibraryCreator : ILibraryCreator
    {
        public ILibrary CreateLibrary()
        {
            return new Library<PaperBook>();
        }
    }
}
