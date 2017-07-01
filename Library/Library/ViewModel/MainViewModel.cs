using GalaSoft.MvvmLight;
using Library.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Data;
using System.ComponentModel;
using System.Windows.Data;

namespace Library.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string find;
        public string _find
        {
            get
            {
                return find;
            }
            set
            {
                find = value;
            }
        }
        private string NameOfBook;
        public string _nameOfBook
        {
            get
            {
                return NameOfBook;
            }
            set
            {
                RaisePropertyChanged("_nameOfBook");
                NameOfBook = value;
            }
        }
        private string NameOfAuthor;
        public string _nameOfAuthor
        {
            get
            {
                return NameOfAuthor;
            }
            set
            {
                RaisePropertyChanged(" _nameOfAuthor");
                NameOfAuthor = value;
            }
        }
        public List<string> Filter { get; set; }
        private string SelectedFilter { get; set; }
        public string _selectedFilter
        {
            get
            {
                return SelectedFilter;
            }
            set
            {
                RaisePropertyChanged("SelectedFilter");
                SelectedFilter = value;
            }
        }
        public List<string> Menu { get; set; }
        public string SelectedMenu { get; set; }
        public ObservableCollection<string> Authors { get; set; }
        public ObservableCollection<Books_Authors> Elements { get; set; }
        public ObservableCollection<Authors_Books> ElementsAuthor { get; set; }
        public ObservableCollection<string> Books { get; set; }
        public ObservableCollection<string> AboutBooks { get; set; }
        public ObservableCollection<string> AboutAuthors { get; set; }
        public AboutBookCommand AboutBook { get; set; }
        public AboutAuthorCommand AboutAuthor { get; set; }
        public AddBookComand A { get; set; }
        public AddAuthorCommand Au { get; set; }
      
        public MainViewModel()
        {
            Filter = new List<string>()
            {
                "по книге",
                "по автору"
            };
            Elements = new ObservableCollection<Books_Authors>()
            {
                new Books_Authors("Война и мир", new ObservableCollection<string>() { "Л.Н.Толстой" }),
                 new Books_Authors("Анна Каренина", new ObservableCollection<string>() { "Л.Н.Толстой" }),
                   new Books_Authors( "Гранатовый браслет", new ObservableCollection<string>() { "Л.Н.Толстой",  "А.И.Куприн" }),
                   new Books_Authors(  "Мертвые души", new ObservableCollection<string>() { "Н.В.Гоголь" })
            };
            ElementsAuthor = new ObservableCollection<Authors_Books>()
            {
                new Authors_Books("Л.Н.Толстой", new ObservableCollection<string>() { "Анна Каренина","Война и мир","Гранатовый браслет" }),
                 new Authors_Books("Анна Каренина", new ObservableCollection<string>() { "Л.Н.Толстой" }),
                   new Authors_Books( "А.И.Куприн", new ObservableCollection<string>() { "Гранатовый браслет" }),
                   new Authors_Books(  "Н.В.Гоголь", new ObservableCollection<string>() { "Мертвые души" })
            };
            A = new AddBookComand();
            Au = new AddAuthorCommand();
            AboutBook = new AboutBookCommand();
            AboutAuthor = new AboutAuthorCommand();
            Books = new ObservableCollection<string>()
            {
                "Война и мир",
                "Анна Каренина",
                "Гранатовый браслет",
                "Мертвые души"
            };
            Authors = new ObservableCollection<string>()
            {
                "Л.Н.Толстой",
                "А.И.Куприн",
                "Н.В.Гоголь"
            };
            AboutBooks = new ObservableCollection<string>();
            AboutAuthors = new ObservableCollection<string>();
        }
        public ObservableCollection<string> Addauthor()
        {
            foreach (var x in Elements)
            {
                if (x.Book == _nameOfBook) AboutBooks = x.Author;
            }
            return AboutBooks;
        }
        public ObservableCollection<string> Addbook()
        {
            foreach (var x in ElementsAuthor)
            {
                if (x.Author == _nameOfAuthor) AboutAuthors = x.Books;
            }
            return AboutAuthors;
        }
        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}