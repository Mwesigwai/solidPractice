namespace solidPractice
{
    public class ChangeLib
    {
        public void AddBook(string author, string title)
        {
            Book bookToAdd = new(author, title);
            
            if(Library.bookCount < Library.catalog.Length)
            {
                Library.catalog[Library.bookCount] = bookToAdd;
                Library.bookCount++;
            }
        }
    }
}
