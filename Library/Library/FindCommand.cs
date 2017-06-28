using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Library.ViewModel;
using System.Collections.ObjectModel;

namespace Library
{
   public class FindCommand:ICommand
    {
        public void Execute(object parameter)
        {
            var vmFilter = parameter as MainViewModel;
            if (vmFilter == null) throw new ArgumentNullException("Модель представления не может быть равна null");
            var A = parameter as MainViewModel;
            int index;
            if(A._selectedElement== "по книге")
            {
                for(int i=0; i<A.Elements.Count; i++)
                {
                    if(A._find==A.Element)
                }
            }    
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }
}
