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
using System.Windows.Shapes;

namespace PurchasingDepartmentDobrinPtitsynYalunin4IS_29.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdministrarorWindow.xaml
    /// </summary>
    public partial class AdministrarorWindow : Window
    {
        public AdministrarorWindow()
        {
            InitializeComponent();

            RoleCmb.SelectedValuePath = "Id";
            RoleCmb.DisplayMemberPath = "NameRole";
            RoleCmb.ItemsSource = App.context.Role.ToList();            
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                FullName = FullnameTxb.Text,
                Login = LoginTxb.Text,
                Password = PasswordTxb.Text,
                Role = RoleCmb.SelectedItem as Role
            };

            App.context.User.Add(user);
            App.context.SaveChanges();
            MessageBox.Show("Пользователь добавлен");

            FullnameTxb.Text = "";
            LoginTxb.Text = "";
            PasswordTxb.Text = "";
            RoleCmb.Text = "";
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
