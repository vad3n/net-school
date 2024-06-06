namespace Task13
{
    public class EBookLibraryCreator : ILibraryCreator
    {
        private const string fileName = "books_info.csv";

        //csv file is hard for processing, unnecessary commas at the end of row
        //inconsistent format for creator, some have multiple names, some have dates, some have 3 letter words examples - aut, ill ???
        //not every field in row start and end with ", some fields are empty
        public ILibrary CreateLibrary()
        {
            return new Library<EBook>();
        }
    }
}
