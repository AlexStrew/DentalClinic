using DentalClinic.Model;
using DentalClinic.Model.PartialClasses;
using DentalClinic.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Excel = Microsoft.Office.Interop.Excel;
namespace DentalClinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для PatientProfilePage.xaml
    /// </summary>
    public partial class PatientProfilePage : System.Windows.Controls.Page
    {
        Core db = new Core();
        List<patients> arrayPatients;
        List<med_history> arrayMed;
        int clientID;
        public PatientProfilePage()
        {
            InitializeComponent();
            
            patients clientData = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientSave).FirstOrDefault();

            if (clientData != null)
            {
                int selectedPatient = clientData.id_patient;
                if (selectedPatient != null)
                {
                    patients patientsData = db.context.patients.Where(x => x.id_patient == selectedPatient).FirstOrDefault();
                    FirstNameTextBox.Text = (string)patientsData.patient_first_name;
                    LastNameTextBox.Text = (string)patientsData.patient_last_name;
                    AllergyTextBox.Text = (string)patientsData.allergy;

                }

                patients medHistory = db.context.patients.Where(x => x.id_patient == selectedPatient).FirstOrDefault();
                arrayMed = db.context.med_history.Where(x=> x.patient_id == selectedPatient).ToList();
                PatientMedHistory.ItemsSource = arrayMed;
               
                foreach (var item in arrayMed)
                {
                    Console.WriteLine(item.current_health);
                }
                clientID = selectedPatient;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void EnrollButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AppointmentPage());

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButtonPage_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PatientEditPage());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportExcelButton_Click(object sender, RoutedEventArgs e)
        {
            var exportExcel = db.context.med_history.Where(x => x.patient_id == clientID).ToList();
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = exportExcel.Count();
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);
            int startRow = 1;

            Excel.Worksheet worksheet = workbook.ActiveSheet;

            worksheet.Name = "Export";

            worksheet.Cells[1][1] = "x-ray";
            worksheet.Cells[2][1] = "fase";
            worksheet.Cells[3][1] = "desease";
            worksheet.Cells[4][1] = "current health";
            worksheet.Cells[5][1] = "description";
            worksheet.Cells[6][1] = "complication";
            worksheet.Cells[7][1] = "stage";
            worksheet.Cells[8][1] = "mkb";
            worksheet.Cells[9][1] = "cost";
            int rowIndex = 2; 
            foreach (var item in arrayMed)
            {
                worksheet.Cells[1][rowIndex] = item.x_ray;
                worksheet.Cells[2][rowIndex] = item.fase;
                worksheet.Cells[3][rowIndex] = item.desease;
                worksheet.Cells[4][rowIndex] = item.current_health;
                worksheet.Cells[5][rowIndex] = item.description;
                worksheet.Cells[6][rowIndex] = item.complication;
                worksheet.Cells[7][rowIndex] = item.stage;
                worksheet.Cells[8][rowIndex] = item.mkb;
                //worksheet.Cells[9][rowIndex] = item.cost;
                rowIndex++;
            }
            application.Visible = true;
        }

        private void AllergyEditButton_Click(object sender, RoutedEventArgs e)
        {
            patients clientData = db.context.patients.Where(x => x.id_patient == Properties.Settings.Default.patientSave).FirstOrDefault();
            int selectedPatient = clientData.id_patient;
            db.context.patients.Where(x => x.id_patient == selectedPatient).First().allergy = AllergyTextBox.Text.ToString();        
            db.context.SaveChanges();
            MessageBox.Show("Success");
        }

        private void TeethMapButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In developing...");
            TeethMapView win = new TeethMapView();
            if (win.ShowDialog() == true)
            {
                Console.WriteLine("ok");
            }
        }
    }
}
