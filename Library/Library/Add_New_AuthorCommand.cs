using System;
using System.Windows.Input;
using Library.ViewModel;
using System.Collections.ObjectModel;
using Library;


namespace Library
{
    //Добавление автора-книгу, книгу-автора в бд
    public class Add_New_AuthorCommand:ICommand
    {
        public void Execute(object parameter)
        {
            using (LibraryDataBase DataBase = new LibraryDataBase())
            {
                Book newbook; Author newauthor;
                int indexnewAuthor = 0;
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
                    if ((p._name == x.Book) && (p._author == x.Author))
                    {
                        indexnewAuthor = 1;
                    }
                }
                if (indexnewAuthor != 1)
                {
                    p.Elements.Add(new Authors_Books(p._name, p._author));
                }
                foreach (var x in p.Books)
                    if (p._name != x)
                        indexnewBook = indexnewBook + 1;
                if (indexnewBook == p.Books.Count)
                {
                    p.Books.Add(p._name);
                    indexnewBook = 0;
                }
                else indexnewBook = 0;
            }
            
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

