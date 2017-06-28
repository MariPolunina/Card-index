using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class Books_Authors
    {
        public string Book { get; set; }
        public string Author { get; set; }
        public Books_Authors(string book, string author)
        {
            Book = book;
            Author = author;
        }
    }
}
