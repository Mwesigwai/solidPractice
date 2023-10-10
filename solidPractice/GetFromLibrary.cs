using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPractice
{
    public class GetFromLibrary
    {
        Library library = new();
        public void ShowBooks()
        {
            foreach(Book book in Library.catalog)
            {
                Console.WriteLine(book);
            }
        }
    }
}
