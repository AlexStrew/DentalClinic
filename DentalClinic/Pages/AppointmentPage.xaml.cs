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
        public AppointmentPage()
        {
            InitializeComponent();

            patients clientData = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientSave).FirstOrDefault();
            if (clientData!=null)
            {
                int selectedPatient = clientData.id_patient;
                if (selectedPatient != null)
                {
                    patients patientsData = db.context.patients.Where(x => x.id_patient == selectedPatient).First();
                    FirstNameTextBox.Text = (string)patientsData.patient_first_name;
                    LastNameTextBox.Text = (string)patientsData.patient_last_name;

                }
            }
            
            

            string[] str = new string[] { "Диагностика", "Повторное", "Консультация"};

            serviceCombobox.ItemsSource = str;
            serviceCombobox.SelectedIndex = 0;
        }
    }
}
