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
    /// Логика взаимодействия для DeleteProductPage.xaml
    /// </summary>
    public partial class DeleteProductPage : Page
    {
        public DeleteProductPage()
        {
            InitializeComponent();

            CategoryProductCmb.SelectedValuePath = "ID";
            CategoryProductCmb.DisplayMemberPath = "Name";
            CategoryProductCmb.ItemsSource = App.context.Category.ToList();

            ProductNameCmb.SelectedValuePath = "ID";
            ProductNameCmb.DisplayMemberPath = "Name";
            ProductNameCmb.ItemsSource = App.context.Products1.ToList();
        }

        private void CategoryProductCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DeleteProductBtn_Click(object sender, RoutedEventArgs e)
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
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            /*int amount;
            amount = Convert.ToInt32(ProductAmountTb.Text);
            int difference = App.product.Quantity;

            Purchases purchases = new Purchases()
            {
                Quantity = difference - amount,
            };

            App.context.Purchases.Add(purchases);
            App.context.SaveChanges();*/
            MessageBox.Show("Товар списан");

            CategoryProductCmb.Text = "";
            ProductNameCmb.Text = "";
            ProductAmountTb.Text = "";

        }
    }
}
