using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library
{
    public class AboutBookCommand : ICommand
    {
        public void Execute(object parameter)
        {
           AboutBook A = new AboutBook();
            A.Show();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }
}
