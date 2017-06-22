using GalaSoft.MvvmLight;
using Library.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
        public string SelectedFilter { get; set; }
        public List<string> Menu { get; set; }
        public string SelectedMenu { get; set; }
        public ObservableCollection<string> Elements { get; set; }
        public ObservableCollection<string> Authors { get; set; }
        public ObservableCollection<string> Books { get; set; }
        public FindCommand F { get; set; }
        
        public MainViewModel()
        {
            Filter = new List<string>()
            {
                "по книге",
                "по автору"
            };
            F = new FindCommand();
            Books = new ObservableCollection<string>()
            {
                "Война и мир",
                "Анна Каренина",
                "Грпнптовый браслет",
                "Мертвые души"
            };
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}