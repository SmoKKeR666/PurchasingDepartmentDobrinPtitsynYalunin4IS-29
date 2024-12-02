using PurchasingDepartmentDobrinPtitsynYalunin4IS_29.Model;
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

namespace PurchasingDepartmentDobrinPtitsynYalunin4IS_29.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();

            CategoryProductCmb.SelectedValuePath = "ID";
            CategoryProductCmb.DisplayMemberPath = "Name";
            CategoryProductCmb.ItemsSource = App.context.Category.ToList();
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Products1 products = new Products1()
                {
                    Name = NameProductTb.Text,
                    Category = CategoryProductCmb.SelectedItem as Category,
                    Price = Convert.ToDecimal(PriceProductTb.Text),
                    Description = DescriptionProductTb.Text
                };

                App.context.Products1.Add(products);
                App.context.SaveChanges();
                MessageBox.Show("Товар добавлен");
            }
            catch
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            

            NameProductTb.Text = "";
            PriceProductTb.Text = "";
            DescriptionProductTb.Text = "";
            CategoryProductCmb.Text = "";
        }
    }
}
