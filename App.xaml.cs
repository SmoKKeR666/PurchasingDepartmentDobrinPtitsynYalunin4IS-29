using PurchasingDepartmentDobrinPtitsynYalunin4IS_29.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PurchasingDepartmentDobrinPtitsynYalunin4IS_29
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static PurchasingDepartmentEntities context = new PurchasingDepartmentEntities();

        public static Products1 product;

        public static User currentUser;
    }
}
