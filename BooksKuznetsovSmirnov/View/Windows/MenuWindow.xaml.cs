using BooksKuznetsovSmirnov.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BooksKuznetsovSmirnov.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new DataGridPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void LbBTN_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new ListBoxPage());
        }

        private void LvBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new ListViewPage());
        }

        private void DgBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new DataGridPage());
        }
    }
}
