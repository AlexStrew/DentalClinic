using DentalClinic.Model;
using DentalClinic.Views;
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
    /// Логика взаимодействия для ConclusionPage.xaml
    /// </summary>
    public partial class ConclusionPage : Page
    {
        Core db = new Core();
        public ConclusionPage()
        {
            InitializeComponent();

            patients newPatients = new patients();
            patients clientID = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientFirst).FirstOrDefault();

            FirstNameTextBox.Text = clientID.patient_first_name;
            LastNameTextBox.Text = clientID.patient_last_name;

            //string[] mkbStr = new string[] { "K00", "M00", "B00", "L00" };
            string[] faseStr = new string[] { "-", "Любая", "Обострение", "Не знаю"};
            string[] complicStr = new string[] { "-", "Осложнение", "Без осложнения", "Не знаю"};
            string[] serviceStr = new string[] { "-", "Диагностика", "Повторное", "Консультация", "Лечение" };
            string[] stageStr = new string[] { "-", "Начальная", "Средняя", "Последняя", "Press F" };
            string[] healthStr = new string[] { "-", "Здоров", "Болен", "Не знаю" };
            string[] deseaseStr = new string[] { "-", "Кариес", "Пульпит", "Периодонтит", "Не знаю" };
            string[] xrayStr = new string[] { "-", "есть", "нет", "Не знаю" };

            //MKBCombo.ItemsSource = mkbStr;
            //MKBCombo.SelectedIndex = 0;

            FaseCombo.ItemsSource = faseStr;
            FaseCombo.SelectedIndex = 0;

            ComplicationCombo.ItemsSource = complicStr;
            ComplicationCombo.SelectedIndex = 0;

            ServiceCombo.ItemsSource = serviceStr;
            ServiceCombo.SelectedIndex = 0;

            StageCombo.ItemsSource = stageStr;
            StageCombo.SelectedIndex = 0;

            HealthCombo.ItemsSource = healthStr;
            HealthCombo.SelectedIndex = 0;

            DeseaseCombo.ItemsSource = deseaseStr;
            DeseaseCombo.SelectedItem = 0;

            xRayCombo.ItemsSource = xrayStr;
            xRayCombo.SelectedIndex = 0;

            



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
            }      
        }

        private void SelectMKB_Click(object sender, RoutedEventArgs e)
        {
            MKBWindow win = new MKBWindow();
            if (win.ShowDialog() == true)
            {
                TestText.Text = Properties.Settings.Default.MKBCode;                
                Console.WriteLine( "--" + Properties.Settings.Default.MKBCode + "--");
            }
            

        }

        private void ConclusionSaveButton_Click(object sender, RoutedEventArgs e)
        {
            consumables newCon = new consumables()
            {
                nozzle = Convert.ToInt32(NozzleTextBox.Text),
                anesthesia = Convert.ToInt32(AnestTextBox.Text),
                crown = Convert.ToInt32(CrownTextBox.Text),
                gel = Convert.ToInt32(GelTextBox.Text),
                vitamins = Convert.ToInt32(VitaTextBox.Text),
                basic_tools = Convert.ToInt32(BasicTextBox.Text),

            };
            
            db.context.consumables.Add(newCon);
            db.context.SaveChanges();

            med_history newPatient = new med_history()
            {
                patient_id = Properties.Settings.Default.patientFirst,
                x_ray = xRayCombo.SelectedItem.ToString(),
                fase = FaseCombo.SelectedItem.ToString(),
                desease = DeseaseCombo.SelectedValue.ToString(),
                current_health = HealthCombo.SelectedItem.ToString(),
                description = DescriptionTextBox.Text,
                complication = ComplicationCombo.SelectedItem.ToString(),
                stage = StageCombo.SelectedItem.ToString(),
                mkb = TestText.Text,
                cost = Convert.ToInt32(currencyTextBox.Text),
                consumable_id = newCon.id_consumable

            };

            

            
            db.context.med_history.Add(newPatient);
            db.context.SaveChanges();
            MessageBox.Show("Success");


            ////var item = PatientListView.SelectedItem as patients;
            //patients clientData = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientFirst).FirstOrDefault();
            //appointment app_id_pat = new appointment();
            //if (clientData != null)
            //{
            //    int selectedPatient = clientData.id_patient;           
            //    app_id_pat.patient_id = selectedPatient;
            //    db.context.appointment.Remove(app_id_pat);
            //    db.context.SaveChanges();
            //}
            
            this.NavigationService.Navigate(new DoctorPage());
        }

   

     
    }
}
