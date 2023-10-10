using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidPractice
{
     public class Book
        {
          public string author;
          public string title;
          public Book(string Author, string Title)
          {
              author = Author;
              title = Title;
          }
          public override string ToString()
          {
              return $"{title} by {author}";
          }
     }
}
