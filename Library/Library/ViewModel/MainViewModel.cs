using GalaSoft.MvvmLight;
using Library.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
System.Data.DataRowView

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
        public ObservableCollection<string> Authors { get; set; }
        public ObservableCollection<string> Books { get; set; }
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
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}