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

namespace DentalClinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для Service.xaml
    /// </summary>
    public partial class Service : Page
    {
        public Service()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ConclusionPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DiaryPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PatientsListPage()); 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PatientProfilePage());
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MKBListPage());
        }


        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PatientEditPage());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AppointmentPage());
        }
    }
}
