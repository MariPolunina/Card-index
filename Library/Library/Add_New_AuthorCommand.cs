using System;
using System.Windows.Input;
using Library.ViewModel;
using System.Collections.ObjectModel;


namespace Library
{
    //Добавление автора-книгу, книгу-автора в бд
    public class Add_New_AuthorCommand:ICommand
    {
        public void Execute(object parameter)
        {
            int indexnewAuthor=0;
            int indexnewBook = 0;
            var p = parameter as MainViewModel;
            foreach (var x in p.Authors)
                if (p._author != x)
                    indexnewAuthor = indexnewAuthor + 1;
            if (indexnewAuthor == p.Authors.Count)
            {
                p.Authors.Add(p._author);
                indexnewAuthor = 0;
            }
            else indexnewAuthor = 0;
            foreach (var x in p.Elements)
            {
                if (p._name == x.Book)
                {
                    indexnewAuthor = 1;
                    x.Author.Add(p._author);
                }
            }
            if (indexnewAuthor != 1) p.Elements.Add(new Books_Authors(p._name, new ObservableCollection<string>() { p._author }));
            foreach (var x in p.ElementsAuthor)
            {
                if (p._author == x.Author)
                {
                    indexnewBook = 1;
                    x.Books.Add(p._name);
                }
            }
            if (indexnewBook != 1) p.ElementsAuthor.Add(new Authors_Books(p._author, new ObservableCollection<string>() { p._name }));
            foreach (var x in p.Books)
                if (p._name != x)
                    indexnewBook = indexnewBook + 1;
            if (indexnewBook == p.Books.Count)
            {
                p.Books.Add(p._name);
                indexnewBook = 0;
            }
            else indexnewBook = 0;
            p.ElementsAuthor.Add(new Authors_Books(p._author, new ObservableCollection<string>() { }));
            ///добавление в бд, которая не создается
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}

