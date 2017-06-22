using System;
using System.Windows.Input;

namespace Library
{
    public class AddAuthorCommand:ICommand
    {
        public void Execute(object parameter)
        {
            AddAuthor A = new AddAuthor();
            A.Show();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }

}
