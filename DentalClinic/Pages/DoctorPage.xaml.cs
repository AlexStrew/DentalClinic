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
    /// Логика взаимодействия для DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Page
    {
        public DoctorPage()
        {
            InitializeComponent();
        }

        private void DiaryButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BookedPatientPage());
        }

        private void PatientListButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PatientsListPage());
        }

        private void MKBList_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MKBListPage());
        }
    }
}
