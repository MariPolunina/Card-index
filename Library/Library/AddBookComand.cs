using System;
using System.Windows.Input;

namespace Library
{
    public class AddBookComand:ICommand
    {
        public void Execute(object parameter)
        {
            AddBooks A = new AddBooks();
            A.Show();
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
