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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VM_m.Data;

namespace VM_management_st
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Repository _repos = new Repository();

            InitializeComponent();
            Terminals_ListBox.ItemsSource = _repos.Terminals;
            Products_ListBox.ItemsSource = _repos.Products;
        }

        private void terminals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void products_Click(object sender, RoutedEventArgs e)
        {

        }

        private void terminal_statistics_Click(object sender, RoutedEventArgs e)
        {

        }

        private void product_statistics_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
