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
        public string Author { get; set; }
        public ObservableCollection<string> Books { get; set; }
        public Authors_Books(string author, ObservableCollection<String> books)
        {
            Author = author;
            Books = books;
        }
    }
}
