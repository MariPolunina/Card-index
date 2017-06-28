using GalaSoft.MvvmLight;
using Library.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

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
                RaisePropertyChanged("NameOfBook");
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
                RaisePropertyChanged("NameOfAuthor");
                NameOfAuthor = value;
            }
        }
        private string selectedElement;
        public string _selectedElement
        {
            get
            {
                return selectedElement;
            }
            set
            {
                RaisePropertyChanged("selectedElement");
                selectedElement = value;
            }
        }
        public List<string> Filter{ get; set; }
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
        public ObservableCollection<Books_Authors> Elements { get; set; }
        public ObservableCollection<string> Authors { get; set; }
        public ObservableCollection<string> Books { get; set; }
        public FindCommand F { get; set; }
        public AddBookComand A { get; set; }
        public AddAuthorCommand Au { get; set; }
        public MainViewModel()
        {
            Filter = new List<string>()
            {
                "по книге",
                "по автору"
            };
            F = new FindCommand();
            A = new AddBookComand();
            Au = new AddAuthorCommand();
            Books = new ObservableCollection<string>()
            {
                "Война и мир",
                "Анна Каренина",
                "Гранатовый браслет",
                "Мертвые души"
            };
            Elements = new ObservableCollection<Books_Authors>();
            Elements.Add(new Books_Authors("Война и мир", "Л.Н.Толстой"));
            Elements.Add(new Books_Authors("Анна Каренина", "Л.Н.Толстой"));
            Elements.Add(new Books_Authors("Гранатовый браслет", "А.И.Куприн"));
            Elements.Add(new Books_Authors("Мертвые души", "Н.В.Гоголь"));
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}