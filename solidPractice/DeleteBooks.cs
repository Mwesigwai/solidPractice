using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPractice
{
    public class DeleteBooks
    {
        public void deleteBook(string author, string title)
        {
            int indexToRemove = -1;
            Book bookToRemove = new(author, title);
            for (int i = 0; i < Library.bookCount; i++)
            {
                if (Library.catalog[i].title == bookToRemove.title && Library.catalog[i].author == bookToRemove.author)
                {
                    indexToRemove = i;
                    break;
                }
            }
            for (int i = indexToRemove; i < Library.catalog.Length - 1; i++)
            {
                Library.catalog[i] = Library.catalog[i + 1];
                Library.bookCount--;
            }
        }
    }
}
