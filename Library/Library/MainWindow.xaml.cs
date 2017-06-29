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
            CollectionViewSource.GetDefaultView(gridLibrary.ItemsSource).Refresh();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(gridLibrary.ItemsSource).Filter = UserFilter;
        }
        private bool UserFilter(object item)
        {
            if (string.IsNullOrEmpty(LibraryFilter.Text)) return true;
            var library = (Books_Authors)item;
            if ((string)bookORauthor.SelectedItem == "по книге")
            {
                return (library.Book.StartsWith(LibraryFilter.Text, System.StringComparison.OrdinalIgnoreCase));
            }
            else
           if ((string)bookORauthor.SelectedItem == "по автору")
            {
                return true;
            }
            else return true;
        }


    }
}