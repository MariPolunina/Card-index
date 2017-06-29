using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Library.ViewModel;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Library
{
   public class FindCommand:ICommand
    {
        public void Execute(object parameter)
        {
            var vmFilter = parameter as MainViewModel;
            ObservableCollection<Books_Authors> newElements = new ObservableCollection<Books_Authors>();
            if (vmFilter == null) throw new ArgumentNullException("Модель представления не может быть равна null");
            if(vmFilter._selectedElement== "по книге")
            {
                var books = from v in vmFilter.Elements
                        where v.Book == vmFilter._find
                        select v;
              
                foreach(var b in books)
                {
                    newElements.Add(b);
                }
            }   
            else
            {
                var authors = from v in vmFilter.Elements
                        where v.Author == vmFilter._find
                        select v;
                foreach (var a in authors)
                {
                    newElements.Add(a);
                }
            }
            var prop = parameter.GetType().GetProperty("Elements", BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance);
            prop.SetValue(parameter, newElements);
            var meth = parameter.GetType().GetMethod("RaisePropertyChanged");
            if(meth!=null)
            {
                Object[] parameters = new object[] { "Elements" };
                meth.Invoke(parameter, parameters);
            }
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }
}
