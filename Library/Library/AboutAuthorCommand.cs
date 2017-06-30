using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library
{
    public class AboutAuthorCommand : ICommand
    {
        public void Execute(object parameter)
        {
            AboutAuthor A = new AboutAuthor();
            A.Show();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }
}
