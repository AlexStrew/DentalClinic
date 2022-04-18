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
    /// Логика взаимодействия для PatientProfilePage.xaml
    /// </summary>
    public partial class PatientProfilePage : Page
    {
        Core db = new Core();
        List<patients> arrayPatients;
        List<med_history> arrayMed;
        public PatientProfilePage()
        {
            InitializeComponent();
            
            patients clientData = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientSave).FirstOrDefault();

            if (clientData != null)
            {
                int selectedPatient = clientData.id_patient;
                if (selectedPatient != null)
                {
                    patients patientsData = db.context.patients.Where(x => x.id_patient == selectedPatient).First();
                    FirstNameTextBox.Text = (string)patientsData.patient_first_name;
                    LastNameTextBox.Text = (string)patientsData.patient_last_name;

                }
                patients medHistory = db.context.patients.Where(x => x.id_patient == selectedPatient).FirstOrDefault();
                arrayMed = db.context.med_history.ToList();
                PatientMedHistory.ItemsSource = arrayMed;

                foreach (var item in arrayMed)
                {
                    Console.WriteLine(item.current_health);
                }


            }

            

        }

        private void PatientMedHistory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LookMedHistoryButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EnrollButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AppointmentPage());

        }
    }
}
