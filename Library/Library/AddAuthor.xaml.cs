using System;
using System.Collections.Generic;
using System.Linq;
using MahApps.Metro.Controls;
using System.Windows.Input;

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для AddBook.xaml
    /// </summary>
    public partial class AddAuthor:MetroWindow 
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
