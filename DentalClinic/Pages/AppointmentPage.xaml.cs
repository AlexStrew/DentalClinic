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
    /// Логика взаимодействия для AppointmentPage.xaml
    /// </summary>
    public partial class AppointmentPage : Page
    {
        Core db = new Core();
        
        int selectedPatient;
        public AppointmentPage()
        {
            InitializeComponent();

            patients clientData = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientSave).FirstOrDefault();
            if (clientData!=null)
            {
                selectedPatient = clientData.id_patient;
                if (selectedPatient != null)
                {
                    patients patientsData = db.context.patients.Where(x => x.id_patient == selectedPatient).First();
                    FirstNameTextBox.Text = (string)patientsData.patient_first_name;
                    LastNameTextBox.Text = (string)patientsData.patient_last_name;

                }
            }
            
            

            string[] str = new string[] { "Диагностика", "Повторное", "Консультация", "Лечение"};

            serviceCombobox.ItemsSource = str;
            serviceCombobox.SelectedIndex = 0;
        }

        private void Sample_Click(object sender, RoutedEventArgs e)
        {
            var selDate = DateTimePickerSelector.SelectedDateTime;
            Console.WriteLine(selDate.Value);
        }

        private void EnrollButton_Click(object sender, RoutedEventArgs e)
        {
            patients clientData = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientSave).FirstOrDefault();
            if (clientData != null)
            {
                int selectedPatient = clientData.id_patient;
                if (selectedPatient != null)
                {

                    appointment newApp = new appointment()
                    {
                        patient_id = selectedPatient,
                        date_app = DateTimePickerSelector.SelectedDateTime.Value,
                        reason = serviceCombobox.SelectedItem.ToString(),
                        description = DescriptionTextBox.Text
                    };
                    //db.context.appointment.Where(x => x.patient_id == selectedPatient).First().date_app = DateTimePickerSelector.SelectedDateTime.Value;
                    //db.context.appointment.Where(x => x.patient_id == selectedPatient).First().reason = serviceCombobox.SelectedItem.ToString();
                    //db.context.appointment.Where(x => x.patient_id == selectedPatient).First().description = DescriptionTextBox.Text;
                    if (serviceCombobox.SelectedItem != null && DescriptionTextBox.Text != null)
                    {
                        db.context.appointment.Add(newApp);
                        db.context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Fill the notes");
                    }
                    

                }
            }
            
            
           
            MessageBox.Show("Success");
            this.NavigationService.Navigate(new DoctorPage());
        }
    }
}
