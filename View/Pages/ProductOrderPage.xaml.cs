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
    /// Логика взаимодействия для ProductOrderPage.xaml
    /// </summary>
    public partial class ProductOrderPage : Page
    {
        public ProductOrderPage()
        {
            InitializeComponent();

            UserCmb.SelectedValuePath = "Id";
            UserCmb.DisplayMemberPath = "FullName";
            UserCmb.ItemsSource = App.context.User.ToList();

            CategoryProductCmb.SelectedValuePath = "ID";
            CategoryProductCmb.DisplayMemberPath = "Name";
            CategoryProductCmb.ItemsSource = App.context.Category.ToList();

            ProductNameCmb.SelectedValuePath = "ID";
            ProductNameCmb.DisplayMemberPath = "Name";
            ProductNameCmb.ItemsSource = App.context.Products1.ToList();

            UnitOfMeasureCmb.SelectedValuePath = "ID";
            UnitOfMeasureCmb.DisplayMemberPath = "NameUnit";
            UnitOfMeasureCmb.ItemsSource = App.context.UnitOfMeasure.ToList();
        }

        private void OrderProductBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(CategoryProductCmb.Text))
            {
                mes += "Выберите категорию товара! ";
            }
            if (string.IsNullOrEmpty(ProductNameCmb.Text))
            {
                mes += "Выберите товар! ";
            }
            if (string.IsNullOrEmpty(ProductAmountTb.Text))
            {
                mes += "Введите количество! ";
            }
            if (string.IsNullOrEmpty(UnitOfMeasureCmb.Text))
            {
                mes += "Выберите единицу измерения! ";
            }
            if (string.IsNullOrEmpty(DateDeliveryDp.Text))
            {
                mes += "Выберите дату доставки! ";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Order order = new Order()
            {
                User = UserCmb.SelectedItem as User,
                Products1 = ProductNameCmb.SelectedItem as Products1,
                Quantity = Convert.ToInt32(ProductAmountTb.Text),
                UnitOfMeasure = UnitOfMeasureCmb.SelectedItem as UnitOfMeasure,
                DateOrder = DateTime.Now,
                DateDelivery = (DateTime)DateDeliveryDp.SelectedDate,
                IdStatusDelivery = 1,
            };

            App.context.Order.Add(order);
            App.context.SaveChanges();
            MessageBox.Show("Заказ оформлен");

            UserCmb.Text = "";
            CategoryProductCmb.Text = "";
            ProductNameCmb.Text = "";
            ProductAmountTb.Text = "";
            UnitOfMeasureCmb.Text = "";
            DateDeliveryDp.Text = "";
        }

        private void CategoryProductCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int SelectedCategory = Convert.ToInt32(CategoryProductCmb.SelectedValue);
            //ProductNameCmb.ItemsSource = App.context.Category.Where(x => x.Id == SelectedCategory).ToList();
        }
    }
}
