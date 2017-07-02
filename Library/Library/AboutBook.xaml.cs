using System.Windows;
using Library.ViewModel;
using MahApps.Metro.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для AboutBook.xaml
    /// </summary>
    public partial class AboutBook : MetroWindow
    {
        //Действия точно такие же, как и об авторе
        public AboutBook()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
            MainViewModel M = new MainViewModel();
           M._nameOfBook = NameOfBookFORaboutBook.Text;
           Authors.ItemsSource= M.Addauthor();
        }

        private void Exit(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
