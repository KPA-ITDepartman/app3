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

namespace Raspored_emisija
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RegClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new System.Uri("Pages/RegistrationPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (EmailTB.Text == "Direktor")
                this.NavigationService.Navigate(new System.Uri("Pages/Direktor.xaml", UriKind.RelativeOrAbsolute));
            else if(EmailTB.Text == "Urednik")
                this.NavigationService.Navigate(new System.Uri("Pages/Urednik.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new System.Uri("Pages/Raspored.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
