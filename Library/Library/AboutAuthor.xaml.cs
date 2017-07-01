using System.Windows;
using Library.ViewModel;
using MahApps.Metro.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для AboutAuthor.xaml
    /// </summary>
    public partial class AboutAuthor:MetroWindow 
    {
        public AboutAuthor()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
            MainViewModel M = new MainViewModel();
            M._nameOfAuthor = NameOfAuthorForAboutAuthor.Text;
            Books.ItemsSource = M.Addbook();
        }

        private void Exit(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
