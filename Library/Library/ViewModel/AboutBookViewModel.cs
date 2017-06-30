using GalaSoft.MvvmLight;
using Library.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Library.ViewModel
{
    public class AboutBookViewModel : ViewModelBase
    {
        private Books_Authors selectedElement;
        public Books_Authors _selectedElement
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
                RaisePropertyChanged("NameOfBook");
                NameOfBook = value;
            }
        }
        public ObservableCollection<string> Books { get; set; }
        public ObservableCollection<Books_Authors> Elements { get; set; }
        public AboutBookViewModel()
        {
            Books = new ObservableCollection<string>()
            {
                "Война и мир",
                "Анна Каренина",
                "Гранатовый браслет",
                "Мертвые души"
            };
            Elements = new ObservableCollection<Books_Authors>();
            Elements.Add(new Books_Authors("Война и мир", new ObservableCollection<string>() { "Л.Н.Толстой" }));
            Elements.Add(new Books_Authors("Анна Каренина", new ObservableCollection<string>() { "Л.Н.Толстой" }));
            Elements.Add(new Books_Authors("Гранатовый браслет", new ObservableCollection<string>() { "А.И.Куприн" }));
            Elements.Add(new Books_Authors("Мертвые души", new ObservableCollection<string>() { "Н.В.Гоголь", "Л.Н.Толстой" }));
        }
    }
}
