using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPractice
{
    public class AddBooks
    {
         public void AddBook(string author, string title)
         {
            Book bookToAdd = new(author, title);

            if (Library.bookCount < Library.catalog.Length)
            {
                Library.catalog[Library.bookCount] = bookToAdd;
                Library.bookCount++;
            }
         }
    }
}
