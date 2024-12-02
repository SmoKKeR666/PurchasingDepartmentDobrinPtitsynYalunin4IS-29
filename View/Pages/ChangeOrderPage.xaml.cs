using PurchasingDepartmentDobrinPtitsynYalunin4IS_29.Model;
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

namespace PurchasingDepartmentDobrinPtitsynYalunin4IS_29.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChangeOrderPage.xaml
    /// </summary>
    public partial class ChangeOrderPage : Page
    {
        public ChangeOrderPage()
        {
            InitializeComponent();

            SupplierCmb.SelectedValuePath = "Id";
            SupplierCmb.DisplayMemberPath = "FullName";
            SupplierCmb.ItemsSource = App.context.User.ToList();

            ProductCmb.SelectedValuePath = "Id";
            ProductCmb.DisplayMemberPath = "Name";
            ProductCmb.ItemsSource = App.context.Products1.ToList();

            StatusOrderCmb.SelectedValuePath = "Id";
            StatusOrderCmb.DisplayMemberPath = "NameStatus";
            StatusOrderCmb.ItemsSource = App.context.StatusDelivery.ToList();

            DataLv.ItemsSource = App.context.Order.ToList();
            InformationGrid.DataContext = App.context.Order.ToList();
        }

        private void DataGr_Loaded(object sender, RoutedEventArgs e)
        {
            DataLv.ItemsSource = App.context.Order.ToList();
        }

        private void ChangeOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();

            MessageBox.Show("Информация успешно изменена");
        }

        private void DataLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InformationGrid.DataContext = DataLv.SelectedItem as Order;
        }
    }
}
