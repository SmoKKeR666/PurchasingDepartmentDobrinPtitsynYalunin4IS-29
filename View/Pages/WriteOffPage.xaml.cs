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
    /// Логика взаимодействия для WriteOffPage.xaml
    /// </summary>
    public partial class WriteOffPage : Page
    {
        public WriteOffPage()
        {
            InitializeComponent();
        }

        private void DataGr_Loaded(object sender, RoutedEventArgs e)
        {
            DataGr.ItemsSource = App.context.Order.ToList();
        }
    }
}
