using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для PatientsListPage.xaml
    /// </summary>
    public partial class PatientsListPage : Page
    {
        Core db = new Core();
        List<patients> patientList;
        public PatientsListPage()
        {
            InitializeComponent();

           

            List<string> sortTypeList = new List<string>()
            {
                "А - Я", "Я - А"
            };
            SortComboBox.ItemsSource = sortTypeList;

            //patientList = new List<patients>
            //{
            //    new patients()
            //    {
            //        id_patient = 0,
            //        patient_first_name ="имя"
            //    }
            //};
            //patientList.AddRange(db.context.patients.ToList());
            //FilterComboBox.ItemsSource = patientList;

            patientList = db.context.patients.ToList();
            PatientListView.ItemsSource = patientList;

            foreach (var item in patientList)
            {
                Console.WriteLine(item.patient_first_name);
            }
            UpdateUI();
        }
       

        private void DescriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void AddPatientButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PatientListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UpdateUI()
        {
            //List<patients> displayProduct = GetRows().ToList();
            //PatientListView.ItemsSource = displayProduct; //db.context.Product.ToList();

        }

        //private List<patients> GetRows()
        //{
        //    List<patients> arrayPatients = db.context.patients.ToList();
        //    string searchData = SearchTextBox.Text.ToUpper();
        //    if (!String.IsNullOrEmpty(SearchTextBox.Text))
        //    {
        //        arrayPatients = arrayPatients.Where(x => x.patient_first_name.ToUpper().Split().Contains(searchData)).ToList();
        //        //arrayPatients = arrayPatients.Where(x => x.patient_last_name.ToUpper().Split().Contains(searchData)).ToList();
        //        //arrayProduct = arrayProduct.Where(x => LevenshteinDistance(x.Title.ToUpper(),searchData)<=6).ToList();
        //    }

        //    int filter = Convert.ToInt32(FilterComboBox.SelectedValue);
        //    if (FilterComboBox.SelectedIndex == 0 || filtercombobox.selecteditem == null) !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //    {
        //        arrayPatients = arrayPatients.ToList();
        //    }
        //    else
        //    {
        //        arrayPatients = arrayPatients.Where(x => x.id_patient == filter).ToList();
        //    }

        //    return arrayPatients;
        //}





        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateUI();
            

        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateUI();
        }

        private void GridViewColumn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EnrollButton_Click(object sender, RoutedEventArgs e)
        {
            Button activeButton = (Button)sender;
            patients activePatient = activeButton.DataContext as patients;
            Console.WriteLine(activePatient.id_patient);
            Properties.Settings.Default.patientSave = activePatient.id_patient;
            Properties.Settings.Default.Save();
            Console.WriteLine();
            this.NavigationService.Navigate(new PatientProfilePage());
        }

  
    }
}
