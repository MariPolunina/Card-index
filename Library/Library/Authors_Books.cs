using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Library
{
   public class Authors_Books
    {
        //Авторы-книги
        public string Author { get; set; }
        public string Book { get; set; }
        public Authors_Books( string books, string author)
        {
            Author = author;
            Book = books;
        }
    }
}
