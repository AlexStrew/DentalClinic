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
    /// Логика взаимодействия для PatientEditPage.xaml
    /// </summary>
    public partial class PatientEditPage : Page
    {
        Core db = new Core();
        int selectedPatient;


        public PatientEditPage()
        {
            InitializeComponent();
            
            patients clientData = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientSave).FirstOrDefault();
            
            if (clientData != null)
            {
                selectedPatient = clientData.id_patient;

                if (selectedPatient != null)
                {
                    patients patientsData = db.context.patients.Where(x => x.id_patient == selectedPatient).FirstOrDefault();
                    FirstNameTextBox.Text = (string)patientsData.patient_first_name;
                    LastNameTextBox.Text = (string)patientsData.patient_last_name;

                }
            }
            
           


        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            db.context.patients.Where(x => x.id_patient == selectedPatient).First().patient_first_name = FirstNameTextBox.Text.ToString();
            db.context.patients.Where(x => x.id_patient == selectedPatient).First().patient_last_name = LastNameTextBox.Text.ToString();
            db.context.SaveChanges();
            MessageBox.Show("Success");
            this.NavigationService.Navigate(new PatientProfilePage());
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
