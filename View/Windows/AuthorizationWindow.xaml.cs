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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            App.currentUser = App.context.User.FirstOrDefault(user => user.Login ==
                LoginTb.Text && user.Password == PasswordPb.Password);
            if (App.currentUser.IdRole == 2)
            {
                AdministrarorWindow administratorWindow = new AdministrarorWindow();
                administratorWindow.Show();
            Hide();
            }
            else if (App.currentUser.IdRole == 1)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            Hide();
            }
            else
            {
                MessageBox.Show("Роль пользователя не найдена! Доступ запрещён.");
            }
        }
    }
}
