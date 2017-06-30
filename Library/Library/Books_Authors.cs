using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Library
{
   public class Books_Authors
    {
        public string Book { get; set; }
        public ObservableCollection<string> Author { get; set; }
        public Books_Authors(string book, ObservableCollection<String> author)
        {
            Book = book;
            Author = author;
        }
    }
}
