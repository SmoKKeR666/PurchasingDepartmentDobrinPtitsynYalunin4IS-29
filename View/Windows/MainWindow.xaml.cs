using PurchasingDepartmentDobrinPtitsynYalunin4IS_29.Appdata;
using PurchasingDepartmentDobrinPtitsynYalunin4IS_29.Model;
using PurchasingDepartmentDobrinPtitsynYalunin4IS_29.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

namespace PurchasingDepartmentDobrinPtitsynYalunin4IS_29
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.FunctionalFrame = FunctionalFrame;
            ClassFrame.FunctionalFrame.Navigate(new StartPage());

        }

        private void ViewProductBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FunctionalFrame = FunctionalFrame;
            ClassFrame.FunctionalFrame.Navigate(new ViewProductsPage());
        }

        private void OrderProductBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FunctionalFrame = FunctionalFrame;
            ClassFrame.FunctionalFrame.Navigate(new ProductOrderPage());
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FunctionalFrame = FunctionalFrame;
            ClassFrame.FunctionalFrame.Navigate(new AddProductPage());
        }

        private void DeleteProductBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FunctionalFrame = FunctionalFrame;
            ClassFrame.FunctionalFrame.Navigate(new DeleteProductPage());
        }

        private void WriteOffProductBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FunctionalFrame = FunctionalFrame;
            ClassFrame.FunctionalFrame.Navigate(new WriteOffPage());
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SearchTxb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTxb.Text == "Найти")
            {
                SearchTxb.Text = "";
            }
        }

        private void SearchTxb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTxb.Text == "")
            {
                SearchTxb.Text = "Найти";
            }
        }

        private void ChangeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FunctionalFrame = FunctionalFrame;
            ClassFrame.FunctionalFrame.Navigate(new ChangeOrderPage());
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FunctionalFrame = FunctionalFrame;
            ClassFrame.FunctionalFrame.Navigate(new ProfilePage());
        }
    }
}
