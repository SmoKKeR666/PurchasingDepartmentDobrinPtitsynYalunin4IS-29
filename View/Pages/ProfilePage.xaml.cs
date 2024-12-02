using Microsoft.Win32;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();

            ProfileGrid.DataContext = App.context.User.ToList();
        }

        private void ProfileBtn_GotFocus(object sender, RoutedEventArgs e)
        {
            ProfileBtn.Visibility = Visibility.Visible;
        }

        private void ProfileBtn_LostFocus(object sender, RoutedEventArgs e)
        {
            ProfileBtn.Visibility = Visibility.Collapsed;
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }

        private void SaveChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();

            MessageBox.Show("Информация успешно изменена");
        }
    }
}
