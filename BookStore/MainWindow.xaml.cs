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

namespace BookStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Source = new Uri("Pages/pageMain.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Source = new Uri("pageRegistration.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Label_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Source = new Uri("Pages/pageMain.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Label_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Source = new Uri("Pages/pageMain.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Label_MouseDoubleClick_3(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Source = new Uri("Pages/pageMain.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
