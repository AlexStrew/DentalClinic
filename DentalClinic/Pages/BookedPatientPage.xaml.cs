using DentalClinic.Model;
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
    /// Логика взаимодействия для BookedPatientPage.xaml
    /// </summary>
    public partial class BookedPatientPage : Page
    {
        Core db = new Core();
        List<appointment> patientList;
        List<patients> patientId;
        public BookedPatientPage()
        {
            InitializeComponent();
            patientList = db.context.appointment.ToList();
            PatientListView.ItemsSource = patientList;

            foreach (var item in patientList)
            {
                Console.WriteLine(item.patient_id);
            }
        }

        private void PatientListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EnrollButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button selectedButton = (Button)sender;
                appointment item = selectedButton.DataContext as appointment;

                MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить строку?", "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    db.context.appointment.Remove(item);
                    db.context.SaveChanges();
                    MessageBox.Show("Данные удалены");
                }

                //обновление DataGri
                PatientListView.ItemsSource = db.context.appointment.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные не удалены. ");
            }

        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            PatientListView.ItemsSource = db.context.appointment.OrderBy(x => x.date_app).ToList();

        }

        private void ConButton_Click(object sender, RoutedEventArgs e)
        {
            //Button activeButton = (Button)sender;
            //patients activePatient = activeButton.DataContext as patients;
            //Console.WriteLine(activePatient.id_patient);
            //Properties.Settings.Default.patientSave = activePatient.id_patient;
            //Properties.Settings.Default.Save();
            //appointment clientID = db.context.patients
            //patients clientData = db.context.patients.Where(x => x.id_patient == clientID.patient_id).FirstOrDefault();
            Button selectedButton = (Button)sender;
            appointment item = selectedButton.DataContext as appointment;
            
            Properties.Settings.Default.patientFirst = item.patient_id;
            Console.WriteLine(Properties.Settings.Default.patientFirst);
            Properties.Settings.Default.Save();
            this.NavigationService.Navigate(new ConclusionPage());
        }
    }
}
