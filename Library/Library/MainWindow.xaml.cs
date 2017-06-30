using System.Windows;
using Library.ViewModel;
using MahApps.Metro.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:MetroWindow
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
            DataContext = new MainViewModel();
            
        }

        private void CommandBinding_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Filter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
           
                CollectionViewSource.GetDefaultView(ListBooks.ItemsSource).Refresh();
                CollectionViewSource.GetDefaultView(ListAuthors.ItemsSource).Refresh();

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
             CollectionViewSource.GetDefaultView(ListBooks.ItemsSource).Filter = UserFilter;
             CollectionViewSource.GetDefaultView(ListAuthors.ItemsSource).Filter = UserFilter1;
        }
        private bool UserFilter(object item)
        {
            if (string.IsNullOrEmpty(LibraryFilter.Text)) return true;
            var library = (string)item;
            if ((string)bookORauthor.SelectedItem == "по книге")
            {
                return (library.StartsWith(LibraryFilter.Text, System.StringComparison.OrdinalIgnoreCase));
            }
            else
             if ((string)bookORauthor.SelectedItem == "по автору")
                return true;
            else
            {
                return (library.StartsWith(LibraryFilter.Text, System.StringComparison.OrdinalIgnoreCase));
            }
        }
        private bool UserFilter1(object item)
        {
            if (string.IsNullOrEmpty(LibraryFilter.Text)) return true;
            var library = (string)item;
                  if ((string)bookORauthor.SelectedItem == "по автору")
            {
                return (library.StartsWith(LibraryFilter.Text, System.StringComparison.OrdinalIgnoreCase));
            }
            else
              if ((string)bookORauthor.SelectedItem == "по книге")
                return true;
                  else
            {
                return (library.StartsWith(LibraryFilter.Text, System.StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}