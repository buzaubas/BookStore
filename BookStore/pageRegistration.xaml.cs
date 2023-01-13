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
using BookStore.lib;

namespace BookStore
{
    /// <summary>
    /// Логика взаимодействия для pageRegistration.xaml
    /// </summary>
    /// 
    public partial class pageRegistration : Page
    {
        public pageRegistration()
        {
            InitializeComponent();
            gdRegisterForm.DataContext = new Users();

            UserService userService = new UserService();
            cbCity.ItemsSource = userService.GetCities();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Users users = (Users)gdRegisterForm.DataContext;
        }
    }
}
